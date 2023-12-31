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
namespace AtlassianClient.Rest.Api.Three.User.Assignable.MultiProjectSearch {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\user\assignable\multiProjectSearch
    /// </summary>
    public class MultiProjectSearchRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new MultiProjectSearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultiProjectSearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/assignable/multiProjectSearch{?query*,username*,accountId*,projectKeys*,startAt*,maxResults*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MultiProjectSearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MultiProjectSearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/assignable/multiProjectSearch{?query*,username*,accountId*,projectKeys*,startAt*,maxResults*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of users who can be assigned issues in one or more projects. The list may be restricted to users whose attributes match a string.This operation takes the users in the range defined by `startAt` and `maxResults`, up to the thousandth user, and then returns only the users from that range that can be assigned issues in the projects. This means the operation usually returns fewer users than specified in `maxResults`. To get all the users who can be assigned issues in the projects, use [Get all users](#api-rest-api-3-users-search-get) and filter the records in your code.Privacy controls are applied to the response based on the users&apos; preferences. This could mean, for example, that the user&apos;s email address is hidden. See the [Profile visibility overview](https://developer.atlassian.com/cloud/jira/platform/profile-visibility/) for more details.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<List<AtlassianClient.Models.User>?> GetAsync(Action<MultiProjectSearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<List<AtlassianClient.Models.User>> GetAsync(Action<MultiProjectSearchRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var collectionResult = await RequestAdapter.SendCollectionAsync<AtlassianClient.Models.User>(requestInfo, AtlassianClient.Models.User.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
            return collectionResult?.ToList();
        }
        /// <summary>
        /// Returns a list of users who can be assigned issues in one or more projects. The list may be restricted to users whose attributes match a string.This operation takes the users in the range defined by `startAt` and `maxResults`, up to the thousandth user, and then returns only the users from that range that can be assigned issues in the projects. This means the operation usually returns fewer users than specified in `maxResults`. To get all the users who can be assigned issues in the projects, use [Get all users](#api-rest-api-3-users-search-get) and filter the records in your code.Privacy controls are applied to the response based on the users&apos; preferences. This could mean, for example, that the user&apos;s email address is hidden. See the [Profile visibility overview](https://developer.atlassian.com/cloud/jira/platform/profile-visibility/) for more details.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MultiProjectSearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MultiProjectSearchRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MultiProjectSearchRequestBuilderGetRequestConfiguration();
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
        public MultiProjectSearchRequestBuilder WithUrl(string rawUrl) {
            return new MultiProjectSearchRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of users who can be assigned issues in one or more projects. The list may be restricted to users whose attributes match a string.This operation takes the users in the range defined by `startAt` and `maxResults`, up to the thousandth user, and then returns only the users from that range that can be assigned issues in the projects. This means the operation usually returns fewer users than specified in `maxResults`. To get all the users who can be assigned issues in the projects, use [Get all users](#api-rest-api-3-users-search-get) and filter the records in your code.Privacy controls are applied to the response based on the users&apos; preferences. This could mean, for example, that the user&apos;s email address is hidden. See the [Profile visibility overview](https://developer.atlassian.com/cloud/jira/platform/profile-visibility/) for more details.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        public class MultiProjectSearchRequestBuilderGetQueryParameters {
            /// <summary>A query string that is matched exactly against user `accountId`. Required, unless `query` is specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("accountId")]
            public string? AccountId { get; set; }
#nullable restore
#else
            [QueryParameter("accountId")]
            public string AccountId { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>A list of project keys (case sensitive). This parameter accepts a comma-separated list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("projectKeys")]
            public string? ProjectKeys { get; set; }
#nullable restore
#else
            [QueryParameter("projectKeys")]
            public string ProjectKeys { get; set; }
#endif
            /// <summary>A query string that is matched against user attributes, such as `displayName` and `emailAddress`, to find relevant users. The string can match the prefix of the attribute&apos;s value. For example, *query=john* matches a user with a `displayName` of *John Smith* and a user with an `emailAddress` of *johnson@example.com*. Required, unless `accountId` is specified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public int? StartAt { get; set; }
            /// <summary>This parameter is no longer available. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("username")]
            public string? Username { get; set; }
#nullable restore
#else
            [QueryParameter("username")]
            public string Username { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MultiProjectSearchRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MultiProjectSearchRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MultiProjectSearchRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new multiProjectSearchRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MultiProjectSearchRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
