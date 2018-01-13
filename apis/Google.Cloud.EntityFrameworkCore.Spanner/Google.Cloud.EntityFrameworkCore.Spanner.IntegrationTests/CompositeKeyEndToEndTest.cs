﻿// Copyright 2017 Google Inc. All Rights Reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Utilities;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace Google.Cloud.EntityFrameworkCore.Spanner.IntegrationTests
{
    public class CompositeKeyEndToEndTest : IDisposable
    {
        public CompositeKeyEndToEndTest() => TestStore = SpannerTestStore.Create("compositekeyendtoendtest");

        public virtual void Dispose() => TestStore.Dispose();

        private class BronieContext : DbContext
        {
            private readonly string _databaseName;
            private readonly IServiceProvider _serviceProvider;

            public BronieContext(IServiceProvider serviceProvider, string databaseName)
            {
                _serviceProvider = serviceProvider;
                _databaseName = databaseName;
            }

            public DbSet<Pegasus> Pegasuses { get; set; }
            public DbSet<Unicorn> Unicorns { get; set; }
            public DbSet<EarthPony> EarthPonies { get; set; }

            protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
                => optionsBuilder
                    .UseSpanner(SpannerTestStore.CreateConnectionString(_databaseName), b => b.ApplyConfiguration())
                    .UseInternalServiceProvider(_serviceProvider);

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Pegasus>(b =>
                {
                    b.ToTable("Pegasus");
                    b.HasKey(e => new {e.Id1, e.Id2});
                });

                modelBuilder.Entity<Unicorn>(b =>
                {
                    b.ToTable("Unicorn");
                    b.HasKey(e => new {e.Id1, e.Id2, e.Id3});
                    b.Property(e => e.Id1).HasValueGenerator<IntGenerator>();
                    b.Property(e => e.Id3).HasValueGenerator<GuidGenerator>();
                });

                modelBuilder.Entity<EarthPony>(b =>
                {
                    b.ToTable("EarthPony");
                    b.HasKey(e => new {e.Id1, e.Id2});
                    b.Property(e => e.Id1).HasValueGenerator<IntGenerator>();
                });
            }
        }

        class GuidGenerator : ValueGenerator<Guid>
        {
            public override Guid Next(EntityEntry entry)
            {
                return Guid.NewGuid();
            }

            public override bool GeneratesTemporaryValues { get; } = false;
        }

        private class Pegasus
        {
            public long Id1 { get; set; }
            public long Id2 { get; set; }
            public string Name { get; set; }
        }

        private class Unicorn
        {
            public int Id1 { get; set; }
            public string Id2 { get; set; }
            public Guid Id3 { get; set; }
            public string Name { get; set; }
        }

        private class EarthPony
        {
            public int Id1 { get; set; }
            public int Id2 { get; set; }
            public string Name { get; set; }
        }

        protected SpannerTestStore TestStore { get; }

        [Fact(Skip = "possibly lack of full generated value support in Spanner.")]
        public async Task Can_use_generated_values_in_composite_key_end_to_end()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .BuildServiceProvider();

            long id1;
            var id2 = DateTime.UtcNow.Ticks.ToString(CultureInfo.InvariantCulture);
            Guid id3;

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                context.Database.EnsureCreated();

                var added = context.Add(new Unicorn {Id2 = id2, Name = "Rarity"}).Entity;

                Assert.True(added.Id1 > 0);
                Assert.NotEqual(Guid.Empty, added.Id3);

                await context.SaveChangesAsync();

                id1 = added.Id1;
                id3 = added.Id3;
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                Assert.Equal(1, context.Unicorns.Count(e => e.Id1 == id1 && e.Id2 == id2 && e.Id3 == id3));
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                var unicorn = context.Unicorns.Single(e => e.Id1 == id1 && e.Id2 == id2 && e.Id3 == id3);

                unicorn.Name = "Bad Hair Day";

                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                var unicorn = context.Unicorns.Single(e => e.Id1 == id1 && e.Id2 == id2 && e.Id3 == id3);

                Assert.Equal("Bad Hair Day", unicorn.Name);

                context.Unicorns.Remove(unicorn);

                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                Assert.Equal(0, context.Unicorns.Count(e => e.Id1 == id1 && e.Id2 == id2 && e.Id3 == id3));
            }
        }

        [Fact]
        public async Task Can_use_two_non_generated_integers_as_composite_key_end_to_end()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .BuildServiceProvider();

            var ticks = DateTime.UtcNow.Ticks;

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                context.Database.EnsureCreated();

                context.Add(new Pegasus {Id1 = ticks, Id2 = ticks + 1, Name = "Rainbow Dash"});
                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                var pegasus = context.Pegasuses.Single(e => e.Id1 == ticks && e.Id2 == ticks + 1);

                pegasus.Name = "Rainbow Crash";

                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                var pegasus = context.Pegasuses.Single(e => e.Id1 == ticks && e.Id2 == ticks + 1);

                Assert.Equal("Rainbow Crash", pegasus.Name);

                context.Pegasuses.Remove(pegasus);

                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                Assert.Equal(0, context.Pegasuses.Count(e => e.Id1 == ticks && e.Id2 == ticks + 1));
            }
        }

        [Fact]
        public async Task Only_one_part_of_a_composite_key_needs_to_vary_for_uniquness()
        {
            var serviceProvider = new ServiceCollection()
                .AddEntityFrameworkSpanner()
                .BuildServiceProvider();

            var ids = new int[3];

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                await context.Database.EnsureCreatedAsync();

                var pony1 = context.Add(new EarthPony {Id2 = 7, Name = "Apple Jack 1"}).Entity;
                var pony2 = context.Add(new EarthPony {Id2 = 7, Name = "Apple Jack 2"}).Entity;
                var pony3 = context.Add(new EarthPony {Id2 = 7, Name = "Apple Jack 3"}).Entity;

                await context.SaveChangesAsync();

                ids[0] = pony1.Id1;
                ids[1] = pony2.Id1;
                ids[2] = pony3.Id1;
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                var ponies = context.EarthPonies.ToList();
                Assert.Equal(ponies.Count, ponies.Count(e => e.Name == "Apple Jack 1") * 3);

                Assert.Equal("Apple Jack 1", ponies.Single(e => e.Id1 == ids[0]).Name);
                Assert.Equal("Apple Jack 2", ponies.Single(e => e.Id1 == ids[1]).Name);
                Assert.Equal("Apple Jack 3", ponies.Single(e => e.Id1 == ids[2]).Name);

                ponies.Single(e => e.Id1 == ids[1]).Name = "Pinky Pie 2";

                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                var ponies = context.EarthPonies.ToArray();
                Assert.Equal(ponies.Length, ponies.Count(e => e.Name == "Apple Jack 1") * 3);

                Assert.Equal("Apple Jack 1", ponies.Single(e => e.Id1 == ids[0]).Name);
                Assert.Equal("Pinky Pie 2", ponies.Single(e => e.Id1 == ids[1]).Name);
                Assert.Equal("Apple Jack 3", ponies.Single(e => e.Id1 == ids[2]).Name);

                context.EarthPonies.RemoveRange(ponies);

                await context.SaveChangesAsync();
            }

            using (var context = new BronieContext(serviceProvider, TestStore.Name))
            {
                Assert.Equal(0, context.EarthPonies.Count());
            }
        }
    }
}