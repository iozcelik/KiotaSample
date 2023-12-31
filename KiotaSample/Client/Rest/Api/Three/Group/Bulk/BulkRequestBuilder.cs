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
namespace AtlassianClient.Rest.Api.Three.Group.Bulk {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\group\bulk
    /// </summary>
    public class BulkRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new BulkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/group/bulk{?startAt*,maxResults*,groupId*,groupName*,accessType*,applicationKey*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BulkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/group/bulk{?startAt*,maxResults*,groupId*,groupName*,accessType*,applicationKey*}", rawUrl) {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of groups.**[Permissions](#permissions) required:** *Browse users and groups* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanGroupDetails?> GetAsync(Action<BulkRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PageBeanGroupDetails> GetAsync(Action<BulkRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanGroupDetails>(requestInfo, PageBeanGroupDetails.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of groups.**[Permissions](#permissions) required:** *Browse users and groups* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<BulkRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<BulkRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new BulkRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public BulkRequestBuilder WithUrl(string rawUrl) {
            return new BulkRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of groups.**[Permissions](#permissions) required:** *Browse users and groups* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class BulkRequestBuilderGetQueryParameters {
            /// <summary>The access level of a group. Valid values: &apos;site-admin&apos;, &apos;admin&apos;, &apos;user&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("accessType")]
            public string? AccessType { get; set; }
#nullable restore
#else
            [QueryParameter("accessType")]
            public string AccessType { get; set; }
#endif
            /// <summary>The application key of the product user groups to search for. Valid values: &apos;jira-servicedesk&apos;, &apos;jira-software&apos;, &apos;jira-product-discovery&apos;, &apos;jira-core&apos;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("applicationKey")]
            public string? ApplicationKey { get; set; }
#nullable restore
#else
            [QueryParameter("applicationKey")]
            public string ApplicationKey { get; set; }
#endif
            /// <summary>The ID of a group. To specify multiple IDs, pass multiple `groupId` parameters. For example, `groupId=5b10a2844c20165700ede21g&amp;groupId=5b10ac8d82e05b22cc7d4ef5`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("groupId")]
            public string[]? GroupId { get; set; }
#nullable restore
#else
            [QueryParameter("groupId")]
            public string[] GroupId { get; set; }
#endif
            /// <summary>The name of a group. To specify multiple names, pass multiple `groupName` parameters. For example, `groupName=administrators&amp;groupName=jira-software-users`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("groupName")]
            public string[]? GroupName { get; set; }
#nullable restore
#else
            [QueryParameter("groupName")]
            public string[] GroupName { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class BulkRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public BulkRequestBuilderGetQueryParameters QueryParameters { get; set; } = new BulkRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new bulkRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public BulkRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
