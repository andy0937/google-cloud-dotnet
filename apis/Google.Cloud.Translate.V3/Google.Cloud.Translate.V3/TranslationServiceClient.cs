// Copyright 2019 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Translate.V3
{
    /// <summary>
    /// Settings for a <see cref="TranslationServiceClient"/>.
    /// </summary>
    public sealed partial class TranslationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="TranslationServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="TranslationServiceSettings"/>.
        /// </returns>
        public static TranslationServiceSettings GetDefault() => new TranslationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="TranslationServiceSettings"/> object with default settings.
        /// </summary>
        public TranslationServiceSettings() { }

        private TranslationServiceSettings(TranslationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            TranslateTextSettings = existing.TranslateTextSettings;
            DetectLanguageSettings = existing.DetectLanguageSettings;
            GetSupportedLanguagesSettings = existing.GetSupportedLanguagesSettings;
            BatchTranslateTextSettings = existing.BatchTranslateTextSettings;
            BatchTranslateTextOperationsSettings = existing.BatchTranslateTextOperationsSettings?.Clone();
            CreateGlossarySettings = existing.CreateGlossarySettings;
            CreateGlossaryOperationsSettings = existing.CreateGlossaryOperationsSettings?.Clone();
            ListGlossariesSettings = existing.ListGlossariesSettings;
            GetGlossarySettings = existing.GetGlossarySettings;
            DeleteGlossarySettings = existing.DeleteGlossarySettings;
            DeleteGlossaryOperationsSettings = existing.DeleteGlossaryOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(TranslationServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="TranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="TranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="TranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="TranslationServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="TranslationServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="TranslationServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="TranslationServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="TranslationServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.TranslateText</c> and <c>TranslationServiceClient.TranslateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.TranslateText</c> and
        /// <c>TranslationServiceClient.TranslateTextAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings TranslateTextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.DetectLanguage</c> and <c>TranslationServiceClient.DetectLanguageAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.DetectLanguage</c> and
        /// <c>TranslationServiceClient.DetectLanguageAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DetectLanguageSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.GetSupportedLanguages</c> and <c>TranslationServiceClient.GetSupportedLanguagesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.GetSupportedLanguages</c> and
        /// <c>TranslationServiceClient.GetSupportedLanguagesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetSupportedLanguagesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.BatchTranslateText</c> and <c>TranslationServiceClient.BatchTranslateTextAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.BatchTranslateText</c> and
        /// <c>TranslationServiceClient.BatchTranslateTextAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings BatchTranslateTextSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.BatchTranslateText</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings BatchTranslateTextOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.CreateGlossary</c> and <c>TranslationServiceClient.CreateGlossaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.CreateGlossary</c> and
        /// <c>TranslationServiceClient.CreateGlossaryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings CreateGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.CreateGlossary</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings CreateGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.ListGlossaries</c> and <c>TranslationServiceClient.ListGlossariesAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.ListGlossaries</c> and
        /// <c>TranslationServiceClient.ListGlossariesAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings ListGlossariesSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.GetGlossary</c> and <c>TranslationServiceClient.GetGlossaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.GetGlossary</c> and
        /// <c>TranslationServiceClient.GetGlossaryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>TranslationServiceClient.DeleteGlossary</c> and <c>TranslationServiceClient.DeleteGlossaryAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>TranslationServiceClient.DeleteGlossary</c> and
        /// <c>TranslationServiceClient.DeleteGlossaryAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings DeleteGlossarySettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>TranslationServiceClient.DeleteGlossary</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 500 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 5000 milliseconds</description></item>
        /// <item><description>Total timeout: 300000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings DeleteGlossaryOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(300000L)),
                sys::TimeSpan.FromMilliseconds(500L),
                1.5,
                sys::TimeSpan.FromMilliseconds(5000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="TranslationServiceSettings"/> object.</returns>
        public TranslationServiceSettings Clone() => new TranslationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="TranslationServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class TranslationServiceClientBuilder : gaxgrpc::ClientBuilderBase<TranslationServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public TranslationServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override TranslationServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return TranslationServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<TranslationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return TranslationServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => TranslationServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => TranslationServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => TranslationServiceClient.ChannelPool;
    }

    /// <summary>
    /// TranslationService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class TranslationServiceClient
    {
        /// <summary>
        /// The default endpoint for the TranslationService service, which is a host of "translate.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("translate.googleapis.com", 443);

        /// <summary>
        /// The default TranslationService scopes.
        /// </summary>
        /// <remarks>
        /// The default TranslationService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// <item><description>"https://www.googleapis.com/auth/cloud-translation"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
            "https://www.googleapis.com/auth/cloud-translation",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="TranslationServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Translate.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// TranslationServiceClient client = await TranslationServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Translate.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     TranslationServiceClient.DefaultEndpoint.Host, TranslationServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TranslationServiceClient client = TranslationServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TranslationServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="TranslationServiceClient"/>.</returns>
        public static async stt::Task<TranslationServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, TranslationServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="TranslationServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.Translate.V3;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// TranslationServiceClient client = TranslationServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.Translate.V3;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     TranslationServiceClient.DefaultEndpoint.Host, TranslationServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// TranslationServiceClient client = TranslationServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="TranslationServiceSettings"/>.</param>
        /// <returns>The created <see cref="TranslationServiceClient"/>.</returns>
        public static TranslationServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, TranslationServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="TranslationServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TranslationServiceSettings"/>.</param>
        /// <returns>The created <see cref="TranslationServiceClient"/>.</returns>
        public static TranslationServiceClient Create(grpccore::Channel channel, TranslationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="TranslationServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="TranslationServiceSettings"/>.</param>
        /// <returns>The created <see cref="TranslationServiceClient"/>.</returns>
        public static TranslationServiceClient Create(grpccore::CallInvoker callInvoker, TranslationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            TranslationService.TranslationServiceClient grpcClient = new TranslationService.TranslationServiceClient(callInvoker);
            return new TranslationServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, TranslationServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TranslationServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, TranslationServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, TranslationServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC TranslationService client.
        /// </summary>
        public virtual TranslationService.TranslationServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(
            TranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<TranslateTextResponse> TranslateTextAsync(
            TranslateTextRequest request,
            st::CancellationToken cancellationToken) => TranslateTextAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual TranslateTextResponse TranslateText(
            TranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}/locations/{location-id}` or
        /// `projects/{project-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        ///
        /// Format:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/{model-id}`
        ///
        /// Only one language detection model is currently supported:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/default`.
        ///
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="labels">
        /// Optional. The labels with user-defined metadata for the request.
        ///
        /// Label keys and values can be no longer than 63 characters
        /// (Unicode codepoints), can only contain lowercase letters, numeric
        /// characters, underscores and dashes. International characters are allowed.
        /// Label values are optional. Label keys must start with a letter.
        ///
        /// See https://cloud.google.com/translate/docs/labels for more information.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            LocationName parent,
            string model,
            string mimeType,
            scg::IDictionary<string, string> labels,
            gaxgrpc::CallSettings callSettings = null) => DetectLanguageAsync(
                new DetectLanguageRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Model = model ?? "", // Optional
                    MimeType = mimeType ?? "", // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}/locations/{location-id}` or
        /// `projects/{project-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        ///
        /// Format:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/{model-id}`
        ///
        /// Only one language detection model is currently supported:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/default`.
        ///
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="labels">
        /// Optional. The labels with user-defined metadata for the request.
        ///
        /// Label keys and values can be no longer than 63 characters
        /// (Unicode codepoints), can only contain lowercase letters, numeric
        /// characters, underscores and dashes. International characters are allowed.
        /// Label values are optional. Label keys must start with a letter.
        ///
        /// See https://cloud.google.com/translate/docs/labels for more information.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            LocationName parent,
            string model,
            string mimeType,
            scg::IDictionary<string, string> labels,
            st::CancellationToken cancellationToken) => DetectLanguageAsync(
                parent,
                model,
                mimeType,
                labels,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}/locations/{location-id}` or
        /// `projects/{project-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        ///
        /// Format:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/{model-id}`
        ///
        /// Only one language detection model is currently supported:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/default`.
        ///
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="labels">
        /// Optional. The labels with user-defined metadata for the request.
        ///
        /// Label keys and values can be no longer than 63 characters
        /// (Unicode codepoints), can only contain lowercase letters, numeric
        /// characters, underscores and dashes. International characters are allowed.
        /// Label values are optional. Label keys must start with a letter.
        ///
        /// See https://cloud.google.com/translate/docs/labels for more information.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DetectLanguageResponse DetectLanguage(
            LocationName parent,
            string model,
            string mimeType,
            scg::IDictionary<string, string> labels,
            gaxgrpc::CallSettings callSettings = null) => DetectLanguage(
                new DetectLanguageRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Model = model ?? "", // Optional
                    MimeType = mimeType ?? "", // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}/locations/{location-id}` or
        /// `projects/{project-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        ///
        /// Format:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/{model-id}`
        ///
        /// Only one language detection model is currently supported:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/default`.
        ///
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="labels">
        /// Optional. The labels with user-defined metadata for the request.
        ///
        /// Label keys and values can be no longer than 63 characters
        /// (Unicode codepoints), can only contain lowercase letters, numeric
        /// characters, underscores and dashes. International characters are allowed.
        /// Label values are optional. Label keys must start with a letter.
        ///
        /// See https://cloud.google.com/translate/docs/labels for more information.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            string parent,
            string model,
            string mimeType,
            scg::IDictionary<string, string> labels,
            gaxgrpc::CallSettings callSettings = null) => DetectLanguageAsync(
                new DetectLanguageRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Model = model ?? "", // Optional
                    MimeType = mimeType ?? "", // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}/locations/{location-id}` or
        /// `projects/{project-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        ///
        /// Format:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/{model-id}`
        ///
        /// Only one language detection model is currently supported:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/default`.
        ///
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="labels">
        /// Optional. The labels with user-defined metadata for the request.
        ///
        /// Label keys and values can be no longer than 63 characters
        /// (Unicode codepoints), can only contain lowercase letters, numeric
        /// characters, underscores and dashes. International characters are allowed.
        /// Label values are optional. Label keys must start with a letter.
        ///
        /// See https://cloud.google.com/translate/docs/labels for more information.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            string parent,
            string model,
            string mimeType,
            scg::IDictionary<string, string> labels,
            st::CancellationToken cancellationToken) => DetectLanguageAsync(
                parent,
                model,
                mimeType,
                labels,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}/locations/{location-id}` or
        /// `projects/{project-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Only models within the same region (has same location-id) can be used.
        /// Otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="model">
        /// Optional. The language detection model to be used.
        ///
        /// Format:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/{model-id}`
        ///
        /// Only one language detection model is currently supported:
        /// `projects/{project-id}/locations/{location-id}/models/language-detection/default`.
        ///
        /// If not specified, the default model is used.
        /// </param>
        /// <param name="mimeType">
        /// Optional. The format of the source text, for example, "text/html",
        /// "text/plain". If left blank, the MIME type defaults to "text/html".
        /// </param>
        /// <param name="labels">
        /// Optional. The labels with user-defined metadata for the request.
        ///
        /// Label keys and values can be no longer than 63 characters
        /// (Unicode codepoints), can only contain lowercase letters, numeric
        /// characters, underscores and dashes. International characters are allowed.
        /// Label values are optional. Label keys must start with a letter.
        ///
        /// See https://cloud.google.com/translate/docs/labels for more information.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DetectLanguageResponse DetectLanguage(
            string parent,
            string model,
            string mimeType,
            scg::IDictionary<string, string> labels,
            gaxgrpc::CallSettings callSettings = null) => DetectLanguage(
                new DetectLanguageRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Model = model ?? "", // Optional
                    MimeType = mimeType ?? "", // Optional
                    Labels = { labels ?? gax::EmptyDictionary<string, string>.Instance }, // Optional
                },
                callSettings);

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            DetectLanguageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            DetectLanguageRequest request,
            st::CancellationToken cancellationToken) => DetectLanguageAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual DetectLanguageResponse DetectLanguage(
            DetectLanguageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}` or
        /// `projects/{project-id}/locations/{location-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Non-global location is required for AutoML models.
        ///
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        ///
        /// The format depends on model type:
        ///
        /// - AutoML Translation models:
        ///   `projects/{project-id}/locations/{location-id}/models/{model-id}`
        ///
        /// - General (built-in) models:
        ///   `projects/{project-id}/locations/{location-id}/models/general/nmt`,
        ///   `projects/{project-id}/locations/{location-id}/models/general/base`
        ///
        ///
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general base (PBMT) model.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            LocationName parent,
            string displayLanguageCode,
            string model,
            gaxgrpc::CallSettings callSettings = null) => GetSupportedLanguagesAsync(
                new GetSupportedLanguagesRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    DisplayLanguageCode = displayLanguageCode ?? "", // Optional
                    Model = model ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}` or
        /// `projects/{project-id}/locations/{location-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Non-global location is required for AutoML models.
        ///
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        ///
        /// The format depends on model type:
        ///
        /// - AutoML Translation models:
        ///   `projects/{project-id}/locations/{location-id}/models/{model-id}`
        ///
        /// - General (built-in) models:
        ///   `projects/{project-id}/locations/{location-id}/models/general/nmt`,
        ///   `projects/{project-id}/locations/{location-id}/models/general/base`
        ///
        ///
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general base (PBMT) model.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            LocationName parent,
            string displayLanguageCode,
            string model,
            st::CancellationToken cancellationToken) => GetSupportedLanguagesAsync(
                parent,
                displayLanguageCode,
                model,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}` or
        /// `projects/{project-id}/locations/{location-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Non-global location is required for AutoML models.
        ///
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        ///
        /// The format depends on model type:
        ///
        /// - AutoML Translation models:
        ///   `projects/{project-id}/locations/{location-id}/models/{model-id}`
        ///
        /// - General (built-in) models:
        ///   `projects/{project-id}/locations/{location-id}/models/general/nmt`,
        ///   `projects/{project-id}/locations/{location-id}/models/general/base`
        ///
        ///
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general base (PBMT) model.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SupportedLanguages GetSupportedLanguages(
            LocationName parent,
            string displayLanguageCode,
            string model,
            gaxgrpc::CallSettings callSettings = null) => GetSupportedLanguages(
                new GetSupportedLanguagesRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    DisplayLanguageCode = displayLanguageCode ?? "", // Optional
                    Model = model ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}` or
        /// `projects/{project-id}/locations/{location-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Non-global location is required for AutoML models.
        ///
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        ///
        /// The format depends on model type:
        ///
        /// - AutoML Translation models:
        ///   `projects/{project-id}/locations/{location-id}/models/{model-id}`
        ///
        /// - General (built-in) models:
        ///   `projects/{project-id}/locations/{location-id}/models/general/nmt`,
        ///   `projects/{project-id}/locations/{location-id}/models/general/base`
        ///
        ///
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general base (PBMT) model.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            string parent,
            string displayLanguageCode,
            string model,
            gaxgrpc::CallSettings callSettings = null) => GetSupportedLanguagesAsync(
                new GetSupportedLanguagesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    DisplayLanguageCode = displayLanguageCode ?? "", // Optional
                    Model = model ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}` or
        /// `projects/{project-id}/locations/{location-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Non-global location is required for AutoML models.
        ///
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        ///
        /// The format depends on model type:
        ///
        /// - AutoML Translation models:
        ///   `projects/{project-id}/locations/{location-id}/models/{model-id}`
        ///
        /// - General (built-in) models:
        ///   `projects/{project-id}/locations/{location-id}/models/general/nmt`,
        ///   `projects/{project-id}/locations/{location-id}/models/general/base`
        ///
        ///
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general base (PBMT) model.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            string parent,
            string displayLanguageCode,
            string model,
            st::CancellationToken cancellationToken) => GetSupportedLanguagesAsync(
                parent,
                displayLanguageCode,
                model,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="parent">
        /// Required. Project or location to make a call. Must refer to a caller's
        /// project.
        ///
        /// Format: `projects/{project-id}` or
        /// `projects/{project-id}/locations/{location-id}`.
        ///
        /// For global calls, use `projects/{project-id}/locations/global` or
        /// `projects/{project-id}`.
        ///
        /// Non-global location is required for AutoML models.
        ///
        /// Only models within the same region (have same location-id) can be used,
        /// otherwise an INVALID_ARGUMENT (400) error is returned.
        /// </param>
        /// <param name="displayLanguageCode">
        /// Optional. The language to use to return localized, human readable names
        /// of supported languages. If missing, then display names are not returned
        /// in a response.
        /// </param>
        /// <param name="model">
        /// Optional. Get supported languages of this model.
        ///
        /// The format depends on model type:
        ///
        /// - AutoML Translation models:
        ///   `projects/{project-id}/locations/{location-id}/models/{model-id}`
        ///
        /// - General (built-in) models:
        ///   `projects/{project-id}/locations/{location-id}/models/general/nmt`,
        ///   `projects/{project-id}/locations/{location-id}/models/general/base`
        ///
        ///
        /// Returns languages supported by the specified model.
        /// If missing, we get supported languages of Google general base (PBMT) model.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SupportedLanguages GetSupportedLanguages(
            string parent,
            string displayLanguageCode,
            string model,
            gaxgrpc::CallSettings callSettings = null) => GetSupportedLanguages(
                new GetSupportedLanguagesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    DisplayLanguageCode = displayLanguageCode ?? "", // Optional
                    Model = model ?? "", // Optional
                },
                callSettings);

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            GetSupportedLanguagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            GetSupportedLanguagesRequest request,
            st::CancellationToken cancellationToken) => GetSupportedLanguagesAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual SupportedLanguages GetSupportedLanguages(
            GetSupportedLanguagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        ///
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> BatchTranslateTextAsync(
            BatchTranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchTranslateTextAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> PollOnceBatchTranslateTextAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchTranslateTextOperationsClient,
                callSettings);

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        ///
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<BatchTranslateResponse, BatchTranslateMetadata> BatchTranslateText(
            BatchTranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>BatchTranslateText</c>.
        /// </summary>
        public virtual lro::OperationsClient BatchTranslateTextOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>BatchTranslateText</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<BatchTranslateResponse, BatchTranslateMetadata> PollOnceBatchTranslateText(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                BatchTranslateTextOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(
            LocationName parent,
            Glossary glossary,
            gaxgrpc::CallSettings callSettings = null) => CreateGlossaryAsync(
                new CreateGlossaryRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
                },
                callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(
            LocationName parent,
            Glossary glossary,
            st::CancellationToken cancellationToken) => CreateGlossaryAsync(
                parent,
                glossary,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(
            LocationName parent,
            Glossary glossary,
            gaxgrpc::CallSettings callSettings = null) => CreateGlossary(
                new CreateGlossaryRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
                },
                callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(
            string parent,
            Glossary glossary,
            gaxgrpc::CallSettings callSettings = null) => CreateGlossaryAsync(
                new CreateGlossaryRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
                },
                callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(
            string parent,
            Glossary glossary,
            st::CancellationToken cancellationToken) => CreateGlossaryAsync(
                parent,
                glossary,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The project name.
        /// </param>
        /// <param name="glossary">
        /// Required. The glossary to create.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(
            string parent,
            Glossary glossary,
            gaxgrpc::CallSettings callSettings = null) => CreateGlossary(
                new CreateGlossaryRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Glossary = gax::GaxPreconditions.CheckNotNull(glossary, nameof(glossary)),
                },
                callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(
            CreateGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGlossaryAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> PollOnceCreateGlossaryAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Glossary, CreateGlossaryMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateGlossaryOperationsClient,
                callSettings);

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(
            CreateGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>CreateGlossary</c>.
        /// </summary>
        public virtual lro::OperationsClient CreateGlossaryOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateGlossary</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Glossary, CreateGlossaryMetadata> PollOnceCreateGlossary(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<Glossary, CreateGlossaryMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                CreateGlossaryOperationsClient,
                callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
        /// </param>
        /// <param name="filter">
        /// Optional. Filter specifying constraints of a list operation.
        /// Filtering is not supported yet, and the parameter currently has no effect.
        /// If missing, no filtering is performed.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(
            LocationName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGlossariesAsync(
                new ListGlossariesRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
        /// </param>
        /// <param name="filter">
        /// Optional. Filter specifying constraints of a list operation.
        /// Filtering is not supported yet, and the parameter currently has no effect.
        /// If missing, no filtering is performed.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(
            LocationName parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGlossaries(
                new ListGlossariesRequest
                {
                    ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
        /// </param>
        /// <param name="filter">
        /// Optional. Filter specifying constraints of a list operation.
        /// Filtering is not supported yet, and the parameter currently has no effect.
        /// If missing, no filtering is performed.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGlossariesAsync(
                new ListGlossariesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the project from which to list all of the glossaries.
        /// </param>
        /// <param name="filter">
        /// Optional. Filter specifying constraints of a list operation.
        /// Filtering is not supported yet, and the parameter currently has no effect.
        /// If missing, no filtering is performed.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request.
        /// A value of <c>null</c> or an empty string retrieves the first page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller.
        /// A value of <c>null</c> or 0 uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(
            string parent,
            string filter,
            string pageToken = null,
            int? pageSize = null,
            gaxgrpc::CallSettings callSettings = null) => ListGlossaries(
                new ListGlossariesRequest
                {
                    Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                    Filter = filter ?? "", // Optional
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(
            ListGlossariesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(
            ListGlossariesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(
            GlossaryName name,
            gaxgrpc::CallSettings callSettings = null) => GetGlossaryAsync(
                new GetGlossaryRequest
                {
                    GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(
            GlossaryName name,
            st::CancellationToken cancellationToken) => GetGlossaryAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Glossary GetGlossary(
            GlossaryName name,
            gaxgrpc::CallSettings callSettings = null) => GetGlossary(
                new GetGlossaryRequest
                {
                    GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetGlossaryAsync(
                new GetGlossaryRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(
            string name,
            st::CancellationToken cancellationToken) => GetGlossaryAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to retrieve.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Glossary GetGlossary(
            string name,
            gaxgrpc::CallSettings callSettings = null) => GetGlossary(
                new GetGlossaryRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(
            GetGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<Glossary> GetGlossaryAsync(
            GetGlossaryRequest request,
            st::CancellationToken cancellationToken) => GetGlossaryAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual Glossary GetGlossary(
            GetGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(
            GlossaryName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGlossaryAsync(
                new DeleteGlossaryRequest
                {
                    GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(
            GlossaryName name,
            st::CancellationToken cancellationToken) => DeleteGlossaryAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(
            GlossaryName name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGlossary(
                new DeleteGlossaryRequest
                {
                    GlossaryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGlossaryAsync(
                new DeleteGlossaryRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(
            string name,
            st::CancellationToken cancellationToken) => DeleteGlossaryAsync(
                name,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the glossary to delete.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(
            string name,
            gaxgrpc::CallSettings callSettings = null) => DeleteGlossary(
                new DeleteGlossaryRequest
                {
                    Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                },
                callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(
            DeleteGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGlossaryAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> PollOnceDeleteGlossaryAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DeleteGlossaryOperationsClient,
                callSettings);

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(
            DeleteGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>DeleteGlossary</c>.
        /// </summary>
        public virtual lro::OperationsClient DeleteGlossaryOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteGlossary</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> PollOnceDeleteGlossary(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                DeleteGlossaryOperationsClient,
                callSettings);

    }

    /// <summary>
    /// TranslationService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class TranslationServiceClientImpl : TranslationServiceClient
    {
        private readonly gaxgrpc::ApiCall<TranslateTextRequest, TranslateTextResponse> _callTranslateText;
        private readonly gaxgrpc::ApiCall<DetectLanguageRequest, DetectLanguageResponse> _callDetectLanguage;
        private readonly gaxgrpc::ApiCall<GetSupportedLanguagesRequest, SupportedLanguages> _callGetSupportedLanguages;
        private readonly gaxgrpc::ApiCall<BatchTranslateTextRequest, lro::Operation> _callBatchTranslateText;
        private readonly gaxgrpc::ApiCall<CreateGlossaryRequest, lro::Operation> _callCreateGlossary;
        private readonly gaxgrpc::ApiCall<ListGlossariesRequest, ListGlossariesResponse> _callListGlossaries;
        private readonly gaxgrpc::ApiCall<GetGlossaryRequest, Glossary> _callGetGlossary;
        private readonly gaxgrpc::ApiCall<DeleteGlossaryRequest, lro::Operation> _callDeleteGlossary;

        /// <summary>
        /// Constructs a client wrapper for the TranslationService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="TranslationServiceSettings"/> used within this client </param>
        public TranslationServiceClientImpl(TranslationService.TranslationServiceClient grpcClient, TranslationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            TranslationServiceSettings effectiveSettings = settings ?? TranslationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            BatchTranslateTextOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.BatchTranslateTextOperationsSettings);
            CreateGlossaryOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.CreateGlossaryOperationsSettings);
            DeleteGlossaryOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.DeleteGlossaryOperationsSettings);
            _callTranslateText = clientHelper.BuildApiCall<TranslateTextRequest, TranslateTextResponse>(
                GrpcClient.TranslateTextAsync, GrpcClient.TranslateText, effectiveSettings.TranslateTextSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callDetectLanguage = clientHelper.BuildApiCall<DetectLanguageRequest, DetectLanguageResponse>(
                GrpcClient.DetectLanguageAsync, GrpcClient.DetectLanguage, effectiveSettings.DetectLanguageSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetSupportedLanguages = clientHelper.BuildApiCall<GetSupportedLanguagesRequest, SupportedLanguages>(
                GrpcClient.GetSupportedLanguagesAsync, GrpcClient.GetSupportedLanguages, effectiveSettings.GetSupportedLanguagesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callBatchTranslateText = clientHelper.BuildApiCall<BatchTranslateTextRequest, lro::Operation>(
                GrpcClient.BatchTranslateTextAsync, GrpcClient.BatchTranslateText, effectiveSettings.BatchTranslateTextSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callCreateGlossary = clientHelper.BuildApiCall<CreateGlossaryRequest, lro::Operation>(
                GrpcClient.CreateGlossaryAsync, GrpcClient.CreateGlossary, effectiveSettings.CreateGlossarySettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callListGlossaries = clientHelper.BuildApiCall<ListGlossariesRequest, ListGlossariesResponse>(
                GrpcClient.ListGlossariesAsync, GrpcClient.ListGlossaries, effectiveSettings.ListGlossariesSettings)
                .WithGoogleRequestParam("parent", request => request.Parent);
            _callGetGlossary = clientHelper.BuildApiCall<GetGlossaryRequest, Glossary>(
                GrpcClient.GetGlossaryAsync, GrpcClient.GetGlossary, effectiveSettings.GetGlossarySettings)
                .WithGoogleRequestParam("name", request => request.Name);
            _callDeleteGlossary = clientHelper.BuildApiCall<DeleteGlossaryRequest, lro::Operation>(
                GrpcClient.DeleteGlossaryAsync, GrpcClient.DeleteGlossary, effectiveSettings.DeleteGlossarySettings)
                .WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callTranslateText);
            Modify_TranslateTextApiCall(ref _callTranslateText);
            Modify_ApiCall(ref _callDetectLanguage);
            Modify_DetectLanguageApiCall(ref _callDetectLanguage);
            Modify_ApiCall(ref _callGetSupportedLanguages);
            Modify_GetSupportedLanguagesApiCall(ref _callGetSupportedLanguages);
            Modify_ApiCall(ref _callBatchTranslateText);
            Modify_BatchTranslateTextApiCall(ref _callBatchTranslateText);
            Modify_ApiCall(ref _callCreateGlossary);
            Modify_CreateGlossaryApiCall(ref _callCreateGlossary);
            Modify_ApiCall(ref _callListGlossaries);
            Modify_ListGlossariesApiCall(ref _callListGlossaries);
            Modify_ApiCall(ref _callGetGlossary);
            Modify_GetGlossaryApiCall(ref _callGetGlossary);
            Modify_ApiCall(ref _callDeleteGlossary);
            Modify_DeleteGlossaryApiCall(ref _callDeleteGlossary);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_TranslateTextApiCall(ref gaxgrpc::ApiCall<TranslateTextRequest, TranslateTextResponse> call);
        partial void Modify_DetectLanguageApiCall(ref gaxgrpc::ApiCall<DetectLanguageRequest, DetectLanguageResponse> call);
        partial void Modify_GetSupportedLanguagesApiCall(ref gaxgrpc::ApiCall<GetSupportedLanguagesRequest, SupportedLanguages> call);
        partial void Modify_BatchTranslateTextApiCall(ref gaxgrpc::ApiCall<BatchTranslateTextRequest, lro::Operation> call);
        partial void Modify_CreateGlossaryApiCall(ref gaxgrpc::ApiCall<CreateGlossaryRequest, lro::Operation> call);
        partial void Modify_ListGlossariesApiCall(ref gaxgrpc::ApiCall<ListGlossariesRequest, ListGlossariesResponse> call);
        partial void Modify_GetGlossaryApiCall(ref gaxgrpc::ApiCall<GetGlossaryRequest, Glossary> call);
        partial void Modify_DeleteGlossaryApiCall(ref gaxgrpc::ApiCall<DeleteGlossaryRequest, lro::Operation> call);
        partial void OnConstruction(TranslationService.TranslationServiceClient grpcClient, TranslationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC TranslationService client.
        /// </summary>
        public override TranslationService.TranslationServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_TranslateTextRequest(ref TranslateTextRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DetectLanguageRequest(ref DetectLanguageRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetSupportedLanguagesRequest(ref GetSupportedLanguagesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_BatchTranslateTextRequest(ref BatchTranslateTextRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_CreateGlossaryRequest(ref CreateGlossaryRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_ListGlossariesRequest(ref ListGlossariesRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_GetGlossaryRequest(ref GetGlossaryRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_DeleteGlossaryRequest(ref DeleteGlossaryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<TranslateTextResponse> TranslateTextAsync(
            TranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TranslateTextRequest(ref request, ref callSettings);
            return _callTranslateText.Async(request, callSettings);
        }

        /// <summary>
        /// Translates input text and returns translated text.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override TranslateTextResponse TranslateText(
            TranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TranslateTextRequest(ref request, ref callSettings);
            return _callTranslateText.Sync(request, callSettings);
        }

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<DetectLanguageResponse> DetectLanguageAsync(
            DetectLanguageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectLanguageRequest(ref request, ref callSettings);
            return _callDetectLanguage.Async(request, callSettings);
        }

        /// <summary>
        /// Detects the language of text within a request.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override DetectLanguageResponse DetectLanguage(
            DetectLanguageRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DetectLanguageRequest(ref request, ref callSettings);
            return _callDetectLanguage.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<SupportedLanguages> GetSupportedLanguagesAsync(
            GetSupportedLanguagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSupportedLanguagesRequest(ref request, ref callSettings);
            return _callGetSupportedLanguages.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of supported languages for translation.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override SupportedLanguages GetSupportedLanguages(
            GetSupportedLanguagesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSupportedLanguagesRequest(ref request, ref callSettings);
            return _callGetSupportedLanguages.Sync(request, callSettings);
        }

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        ///
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async stt::Task<lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>> BatchTranslateTextAsync(
            BatchTranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTranslateTextRequest(ref request, ref callSettings);
            return new lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>(
                await _callBatchTranslateText.Async(request, callSettings).ConfigureAwait(false), BatchTranslateTextOperationsClient);
        }

        /// <summary>
        /// Translates a large volume of text in asynchronous batch mode.
        /// This function provides real-time output as the inputs are being processed.
        /// If caller cancels a request, the partial results (for an input file, it's
        /// all or nothing) may still be available on the specified output location.
        ///
        /// This call returns immediately and you can
        /// use google.longrunning.Operation.name to poll the status of the call.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation<BatchTranslateResponse, BatchTranslateMetadata> BatchTranslateText(
            BatchTranslateTextRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_BatchTranslateTextRequest(ref request, ref callSettings);
            return new lro::Operation<BatchTranslateResponse, BatchTranslateMetadata>(
                _callBatchTranslateText.Sync(request, callSettings), BatchTranslateTextOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>BatchTranslateText</c>.
        /// </summary>
        public override lro::OperationsClient BatchTranslateTextOperationsClient { get; }

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async stt::Task<lro::Operation<Glossary, CreateGlossaryMetadata>> CreateGlossaryAsync(
            CreateGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, CreateGlossaryMetadata>(
                await _callCreateGlossary.Async(request, callSettings).ConfigureAwait(false), CreateGlossaryOperationsClient);
        }

        /// <summary>
        /// Creates a glossary and returns the long-running operation. Returns
        /// NOT_FOUND, if the project doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation<Glossary, CreateGlossaryMetadata> CreateGlossary(
            CreateGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<Glossary, CreateGlossaryMetadata>(
                _callCreateGlossary.Sync(request, callSettings), CreateGlossaryOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>CreateGlossary</c>.
        /// </summary>
        public override lro::OperationsClient CreateGlossaryOperationsClient { get; }

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListGlossariesResponse, Glossary> ListGlossariesAsync(
            ListGlossariesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListGlossariesRequest, ListGlossariesResponse, Glossary>(_callListGlossaries, request, callSettings);
        }

        /// <summary>
        /// Lists glossaries in a project. Returns NOT_FOUND, if the project doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A pageable sequence of <see cref="Glossary"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListGlossariesResponse, Glossary> ListGlossaries(
            ListGlossariesRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListGlossariesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListGlossariesRequest, ListGlossariesResponse, Glossary>(_callListGlossaries, request, callSettings);
        }

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<Glossary> GetGlossaryAsync(
            GetGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryRequest(ref request, ref callSettings);
            return _callGetGlossary.Async(request, callSettings);
        }

        /// <summary>
        /// Gets a glossary. Returns NOT_FOUND, if the glossary doesn't
        /// exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override Glossary GetGlossary(
            GetGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGlossaryRequest(ref request, ref callSettings);
            return _callGetGlossary.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override async stt::Task<lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>> DeleteGlossaryAsync(
            DeleteGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>(
                await _callDeleteGlossary.Async(request, callSettings).ConfigureAwait(false), DeleteGlossaryOperationsClient);
        }

        /// <summary>
        /// Deletes a glossary, or cancels glossary construction
        /// if the glossary isn't created yet.
        /// Returns NOT_FOUND, if the glossary doesn't exist.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata> DeleteGlossary(
            DeleteGlossaryRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteGlossaryRequest(ref request, ref callSettings);
            return new lro::Operation<DeleteGlossaryResponse, DeleteGlossaryMetadata>(
                _callDeleteGlossary.Sync(request, callSettings), DeleteGlossaryOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>DeleteGlossary</c>.
        /// </summary>
        public override lro::OperationsClient DeleteGlossaryOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    public partial class ListGlossariesRequest : gaxgrpc::IPageRequest { }
    public partial class ListGlossariesResponse : gaxgrpc::IPageResponse<Glossary>
    {
        /// <summary>
        /// Returns an enumerator that iterates through the resources in this response.
        /// </summary>
        public scg::IEnumerator<Glossary> GetEnumerator() => Glossaries.GetEnumerator();

        /// <inheritdoc/>
        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    // Partial Grpc class to enable LRO client creation
    public static partial class TranslationService
    {
        public partial class TranslationServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
