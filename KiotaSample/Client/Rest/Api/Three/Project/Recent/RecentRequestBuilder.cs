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
namespace AtlassianClient.Rest.Api.Three.Project.Recent {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\project\recent
    /// </summary>
    public class RecentRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new RecentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/project/recent{?expand*,properties*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new RecentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public RecentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/project/recent{?expand*,properties*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of up to 20 projects recently viewed by the user that are still visible to the user.This operation can be accessed anonymously.**[Permissions](#permissions) required:** Projects are returned only where the user has one of: *  *Browse Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project. *  *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project. *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<AtlassianClient.Models.Project>?> GetAsync(Action<RecentRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<AtlassianClient.Models.Project>> GetAsync(Action<RecentRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<AtlassianClient.Models.Project>(requestInfo, AtlassianClient.Models.Project.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns a list of up to 20 projects recently viewed by the user that are still visible to the user.This operation can be accessed anonymously.**[Permissions](#permissions) required:** Projects are returned only where the user has one of: *  *Browse Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project. *  *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project. *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<RecentRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<RecentRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new RecentRequestBuilderGetRequestConfiguration();
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
        public RecentRequestBuilder WithUrl(string rawUrl) {
            return new RecentRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of up to 20 projects recently viewed by the user that are still visible to the user.This operation can be accessed anonymously.**[Permissions](#permissions) required:** Projects are returned only where the user has one of: *  *Browse Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project. *  *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project. *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class RecentRequestBuilderGetQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts a comma-separated list. Expanded options include: *  `description` Returns the project description. *  `projectKeys` Returns all project keys associated with a project. *  `lead` Returns information about the project lead. *  `issueTypes` Returns all issue types associated with the project. *  `url` Returns the URL associated with the project. *  `permissions` Returns the permissions associated with the project. *  `insight` EXPERIMENTAL. Returns the insight details of total issue count and last issue update time for the project. *  `*` Returns the project with all available expand options.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>EXPERIMENTAL. A list of project properties to return for the project. This parameter accepts a comma-separated list. Invalid property names are ignored.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("properties")]
            public string[]? Properties { get; set; }
#nullable restore
#else
            [QueryParameter("properties")]
            public string[] Properties { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class RecentRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public RecentRequestBuilderGetQueryParameters QueryParameters { get; set; } = new RecentRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new recentRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public RecentRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}