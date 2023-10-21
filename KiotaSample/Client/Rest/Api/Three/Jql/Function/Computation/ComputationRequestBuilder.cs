// <auto-generated/>
using AtlassianClient.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace AtlassianClient.Rest.Api.Three.Jql.Function.Computation {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\jql\function\computation
    /// </summary>
    public class ComputationRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ComputationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ComputationRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql/function/computation{?functionKey*,startAt*,maxResults*,orderBy*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ComputationRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ComputationRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql/function/computation{?functionKey*,startAt*,maxResults*,orderBy*}", rawUrl) {
        }
        /// <summary>
        /// Returns the list of a function&apos;s precomputations along with information about when they were created, updated, and last used. Each precomputation has a `value` \- the JQL fragment to replace the custom function clause with.**[Permissions](#permissions) required:** This API is only accessible to apps and apps can only inspect their own functions.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanJqlFunctionPrecomputationBean?> GetAsync(Action<ComputationRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PageBeanJqlFunctionPrecomputationBean> GetAsync(Action<ComputationRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanJqlFunctionPrecomputationBean>(requestInfo, PageBeanJqlFunctionPrecomputationBean.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update the precomputation value of a function created by a Forge/Connect app.**[Permissions](#permissions) required:** An API for apps to update their own precomputations.
        /// </summary>
        /// <param name="body">List of pairs (id and value) for precomputation updates.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PostAsync(JqlFunctionPrecomputationUpdateRequestBean body, Action<ComputationRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PostAsync(JqlFunctionPrecomputationUpdateRequestBean body, Action<ComputationRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the list of a function&apos;s precomputations along with information about when they were created, updated, and last used. Each precomputation has a `value` \- the JQL fragment to replace the custom function clause with.**[Permissions](#permissions) required:** This API is only accessible to apps and apps can only inspect their own functions.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ComputationRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ComputationRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ComputationRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Update the precomputation value of a function created by a Forge/Connect app.**[Permissions](#permissions) required:** An API for apps to update their own precomputations.
        /// </summary>
        /// <param name="body">List of pairs (id and value) for precomputation updates.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(JqlFunctionPrecomputationUpdateRequestBean body, Action<ComputationRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(JqlFunctionPrecomputationUpdateRequestBean body, Action<ComputationRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ComputationRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ComputationRequestBuilder WithUrl(string rawUrl) {
            return new ComputationRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns the list of a function&apos;s precomputations along with information about when they were created, updated, and last used. Each precomputation has a `value` \- the JQL fragment to replace the custom function clause with.**[Permissions](#permissions) required:** This API is only accessible to apps and apps can only inspect their own functions.
        /// </summary>
        public class ComputationRequestBuilderGetQueryParameters {
            /// <summary>The function key in format: *  Forge: `ari:cloud:ecosystem::extension/[App ID]/[Environment ID]/static/[Function key from manifest]` *  Connect: `[App key]__[Module key]`</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("functionKey")]
            public string[]? FunctionKey { get; set; }
#nullable restore
#else
            [QueryParameter("functionKey")]
            public string[] FunctionKey { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>[Order](#ordering) the results by a field: *  `functionKey` Sorts by the functionKey. *  `used` Sorts by the used timestamp. *  `created` Sorts by the created timestamp. *  `updated` Sorts by the updated timestamp.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderBy")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("orderBy")]
            public string OrderBy { get; set; }
#endif
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ComputationRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ComputationRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ComputationRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new computationRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ComputationRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ComputationRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new computationRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ComputationRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}