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

namespace Google.Cloud.VideoIntelligence.V1
{
    /// <summary>
    /// Settings for a <see cref="VideoIntelligenceServiceClient"/>.
    /// </summary>
    public sealed partial class VideoIntelligenceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="VideoIntelligenceServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="VideoIntelligenceServiceSettings"/>.
        /// </returns>
        public static VideoIntelligenceServiceSettings GetDefault() => new VideoIntelligenceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="VideoIntelligenceServiceSettings"/> object with default settings.
        /// </summary>
        public VideoIntelligenceServiceSettings() { }

        private VideoIntelligenceServiceSettings(VideoIntelligenceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            AnnotateVideoSettings = existing.AnnotateVideoSettings;
            AnnotateVideoOperationsSettings = existing.AnnotateVideoOperationsSettings?.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(VideoIntelligenceServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="VideoIntelligenceServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="VideoIntelligenceServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="VideoIntelligenceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="VideoIntelligenceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="VideoIntelligenceServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="VideoIntelligenceServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="VideoIntelligenceServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="VideoIntelligenceServiceClient"/> RPC methods is defined as:
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
        /// <c>VideoIntelligenceServiceClient.AnnotateVideo</c> and <c>VideoIntelligenceServiceClient.AnnotateVideoAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>VideoIntelligenceServiceClient.AnnotateVideo</c> and
        /// <c>VideoIntelligenceServiceClient.AnnotateVideoAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings AnnotateVideoSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Long Running Operation settings for calls to <c>VideoIntelligenceServiceClient.AnnotateVideo</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45000 milliseconds</description></item>
        /// <item><description>Total timeout: 86400000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings AnnotateVideoOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(
                gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(86400000L)),
                sys::TimeSpan.FromMilliseconds(20000L),
                1.5,
                sys::TimeSpan.FromMilliseconds(45000L))
        };

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="VideoIntelligenceServiceSettings"/> object.</returns>
        public VideoIntelligenceServiceSettings Clone() => new VideoIntelligenceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="VideoIntelligenceServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class VideoIntelligenceServiceClientBuilder : gaxgrpc::ClientBuilderBase<VideoIntelligenceServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public VideoIntelligenceServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override VideoIntelligenceServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return VideoIntelligenceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<VideoIntelligenceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return VideoIntelligenceServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => VideoIntelligenceServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => VideoIntelligenceServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => VideoIntelligenceServiceClient.ChannelPool;
    }

    /// <summary>
    /// VideoIntelligenceService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class VideoIntelligenceServiceClient
    {
        /// <summary>
        /// The default endpoint for the VideoIntelligenceService service, which is a host of "videointelligence.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("videointelligence.googleapis.com", 443);

        /// <summary>
        /// The default VideoIntelligenceService scopes.
        /// </summary>
        /// <remarks>
        /// The default VideoIntelligenceService scopes are:
        /// <list type="bullet">
        /// <item><description>"https://www.googleapis.com/auth/cloud-platform"</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="VideoIntelligenceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.VideoIntelligence.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// VideoIntelligenceServiceClient client = await VideoIntelligenceServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.VideoIntelligence.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     VideoIntelligenceServiceClient.DefaultEndpoint.Host, VideoIntelligenceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// VideoIntelligenceServiceClient client = VideoIntelligenceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="VideoIntelligenceServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        public static async stt::Task<VideoIntelligenceServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, VideoIntelligenceServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="VideoIntelligenceServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Cloud.VideoIntelligence.V1;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// VideoIntelligenceServiceClient client = VideoIntelligenceServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Cloud.VideoIntelligence.V1;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     VideoIntelligenceServiceClient.DefaultEndpoint.Host, VideoIntelligenceServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// VideoIntelligenceServiceClient client = VideoIntelligenceServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="VideoIntelligenceServiceSettings"/>.</param>
        /// <returns>The created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        public static VideoIntelligenceServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, VideoIntelligenceServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="VideoIntelligenceServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="VideoIntelligenceServiceSettings"/>.</param>
        /// <returns>The created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        public static VideoIntelligenceServiceClient Create(grpccore::Channel channel, VideoIntelligenceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="VideoIntelligenceServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="VideoIntelligenceServiceSettings"/>.</param>
        /// <returns>The created <see cref="VideoIntelligenceServiceClient"/>.</returns>
        public static VideoIntelligenceServiceClient Create(grpccore::CallInvoker callInvoker, VideoIntelligenceServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            VideoIntelligenceService.VideoIntelligenceServiceClient grpcClient = new VideoIntelligenceService.VideoIntelligenceServiceClient(callInvoker);
            return new VideoIntelligenceServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, VideoIntelligenceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, VideoIntelligenceServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, VideoIntelligenceServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, VideoIntelligenceServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC VideoIntelligenceService client.
        /// </summary>
        public virtual VideoIntelligenceService.VideoIntelligenceServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="inputUri">
        /// Input video location. Currently, only
        /// [Google Cloud Storage](https://cloud.google.com/storage/) URIs are
        /// supported, which must be specified in the following format:
        /// `gs://bucket-id/object-id` (other URI formats return
        /// [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more information, see
        /// [Request URIs](/storage/docs/reference-uris).
        /// A video URI may include wildcards in `object-id`, and thus identify
        /// multiple videos. Supported wildcards: '*' to match 0 or more characters;
        /// '?' to match 1 character. If unset, the input video should be embedded
        /// in the request as `input_content`. If set, `input_content` should be unset.
        /// </param>
        /// <param name="features">
        /// Required. Requested video annotation features.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(
            string inputUri,
            scg::IEnumerable<Feature> features,
            gaxgrpc::CallSettings callSettings = null) => AnnotateVideoAsync(
                new AnnotateVideoRequest
                {
                    InputUri = inputUri ?? "", // Optional
                    Features = { gax::GaxPreconditions.CheckNotNull(features, nameof(features)) },
                },
                callSettings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="inputUri">
        /// Input video location. Currently, only
        /// [Google Cloud Storage](https://cloud.google.com/storage/) URIs are
        /// supported, which must be specified in the following format:
        /// `gs://bucket-id/object-id` (other URI formats return
        /// [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more information, see
        /// [Request URIs](/storage/docs/reference-uris).
        /// A video URI may include wildcards in `object-id`, and thus identify
        /// multiple videos. Supported wildcards: '*' to match 0 or more characters;
        /// '?' to match 1 character. If unset, the input video should be embedded
        /// in the request as `input_content`. If set, `input_content` should be unset.
        /// </param>
        /// <param name="features">
        /// Required. Requested video annotation features.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(
            string inputUri,
            scg::IEnumerable<Feature> features,
            st::CancellationToken cancellationToken) => AnnotateVideoAsync(
                inputUri,
                features,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
        /// </summary>
        /// <param name="inputUri">
        /// Input video location. Currently, only
        /// [Google Cloud Storage](https://cloud.google.com/storage/) URIs are
        /// supported, which must be specified in the following format:
        /// `gs://bucket-id/object-id` (other URI formats return
        /// [google.rpc.Code.INVALID_ARGUMENT][google.rpc.Code.INVALID_ARGUMENT]). For more information, see
        /// [Request URIs](/storage/docs/reference-uris).
        /// A video URI may include wildcards in `object-id`, and thus identify
        /// multiple videos. Supported wildcards: '*' to match 0 or more characters;
        /// '?' to match 1 character. If unset, the input video should be embedded
        /// in the request as `input_content`. If set, `input_content` should be unset.
        /// </param>
        /// <param name="features">
        /// Required. Requested video annotation features.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> AnnotateVideo(
            string inputUri,
            scg::IEnumerable<Feature> features,
            gaxgrpc::CallSettings callSettings = null) => AnnotateVideo(
                new AnnotateVideoRequest
                {
                    InputUri = inputUri ?? "", // Optional
                    Features = { gax::GaxPreconditions.CheckNotNull(features, nameof(features)) },
                },
                callSettings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
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
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(
            AnnotateVideoRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnnotateVideoAsync</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> PollOnceAnnotateVideoAsync(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>.PollOnceFromNameAsync(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                AnnotateVideoOperationsClient,
                callSettings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
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
        public virtual lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> AnnotateVideo(
            AnnotateVideoRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// The long-running operations client for <c>AnnotateVideo</c>.
        /// </summary>
        public virtual lro::OperationsClient AnnotateVideoOperationsClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AnnotateVideo</c>.
        /// </summary>
        /// <param name="operationName">The name of a previously invoked operation. Must not be <c>null</c> or empty.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> PollOnceAnnotateVideo(
            string operationName,
            gaxgrpc::CallSettings callSettings = null) => lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>.PollOnceFromName(
                gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)),
                AnnotateVideoOperationsClient,
                callSettings);

    }

    /// <summary>
    /// VideoIntelligenceService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class VideoIntelligenceServiceClientImpl : VideoIntelligenceServiceClient
    {
        private readonly gaxgrpc::ApiCall<AnnotateVideoRequest, lro::Operation> _callAnnotateVideo;

        /// <summary>
        /// Constructs a client wrapper for the VideoIntelligenceService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="VideoIntelligenceServiceSettings"/> used within this client </param>
        public VideoIntelligenceServiceClientImpl(VideoIntelligenceService.VideoIntelligenceServiceClient grpcClient, VideoIntelligenceServiceSettings settings)
        {
            GrpcClient = grpcClient;
            VideoIntelligenceServiceSettings effectiveSettings = settings ?? VideoIntelligenceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            AnnotateVideoOperationsClient = new lro::OperationsClientImpl(
                grpcClient.CreateOperationsClient(), effectiveSettings.AnnotateVideoOperationsSettings);
            _callAnnotateVideo = clientHelper.BuildApiCall<AnnotateVideoRequest, lro::Operation>(
                GrpcClient.AnnotateVideoAsync, GrpcClient.AnnotateVideo, effectiveSettings.AnnotateVideoSettings);
            Modify_ApiCall(ref _callAnnotateVideo);
            Modify_AnnotateVideoApiCall(ref _callAnnotateVideo);
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
        partial void Modify_AnnotateVideoApiCall(ref gaxgrpc::ApiCall<AnnotateVideoRequest, lro::Operation> call);
        partial void OnConstruction(VideoIntelligenceService.VideoIntelligenceServiceClient grpcClient, VideoIntelligenceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC VideoIntelligenceService client.
        /// </summary>
        public override VideoIntelligenceService.VideoIntelligenceServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_AnnotateVideoRequest(ref AnnotateVideoRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
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
        public override async stt::Task<lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>> AnnotateVideoAsync(
            AnnotateVideoRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateVideoRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>(
                await _callAnnotateVideo.Async(request, callSettings).ConfigureAwait(false), AnnotateVideoOperationsClient);
        }

        /// <summary>
        /// Performs asynchronous video annotation. Progress and results can be
        /// retrieved through the `google.longrunning.Operations` interface.
        /// `Operation.metadata` contains `AnnotateVideoProgress` (progress).
        /// `Operation.response` contains `AnnotateVideoResponse` (results).
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
        public override lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress> AnnotateVideo(
            AnnotateVideoRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AnnotateVideoRequest(ref request, ref callSettings);
            return new lro::Operation<AnnotateVideoResponse, AnnotateVideoProgress>(
                _callAnnotateVideo.Sync(request, callSettings), AnnotateVideoOperationsClient);
        }

        /// <summary>
        /// The long-running operations client for <c>AnnotateVideo</c>.
        /// </summary>
        public override lro::OperationsClient AnnotateVideoOperationsClient { get; }

    }

    // Partial classes to enable page-streaming

    // Partial Grpc class to enable LRO client creation
    public static partial class VideoIntelligenceService
    {
        public partial class VideoIntelligenceServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() => new lro::Operations.OperationsClient(CallInvoker);
        }
    }


}
