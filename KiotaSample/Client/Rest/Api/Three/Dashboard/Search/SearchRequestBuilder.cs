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
namespace AtlassianClient.Rest.Api.Three.Dashboard.Search {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\dashboard\search
    /// </summary>
    public class SearchRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/search{?dashboardName*,accountId*,owner*,groupname*,groupId*,projectId*,orderBy*,startAt*,maxResults*,status*,expand*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/search{?dashboardName*,accountId*,owner*,groupname*,groupId*,projectId*,orderBy*,startAt*,maxResults*,status*,expand*}", rawUrl) {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of dashboards. This operation is similar to [Get dashboards](#api-rest-api-3-dashboard-get) except that the results can be refined to include dashboards that have specific attributes. For example, dashboards with a particular name. When multiple attributes are specified only filters matching all attributes are returned.This operation can be accessed anonymously.**[Permissions](#permissions) required:** The following dashboards that match the query parameters are returned: *  Dashboards owned by the user. Not returned for anonymous users. *  Dashboards shared with a group that the user is a member of. Not returned for anonymous users. *  Dashboards shared with a private project that the user can browse. Not returned for anonymous users. *  Dashboards shared with a public project. *  Dashboards shared with the public.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanDashboard?> GetAsync(Action<SearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PageBeanDashboard> GetAsync(Action<SearchRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PageBeanDashboard>(requestInfo, PageBeanDashboard.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of dashboards. This operation is similar to [Get dashboards](#api-rest-api-3-dashboard-get) except that the results can be refined to include dashboards that have specific attributes. For example, dashboards with a particular name. When multiple attributes are specified only filters matching all attributes are returned.This operation can be accessed anonymously.**[Permissions](#permissions) required:** The following dashboards that match the query parameters are returned: *  Dashboards owned by the user. Not returned for anonymous users. *  Dashboards shared with a group that the user is a member of. Not returned for anonymous users. *  Dashboards shared with a private project that the user can browse. Not returned for anonymous users. *  Dashboards shared with a public project. *  Dashboards shared with the public.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<SearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<SearchRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new SearchRequestBuilderGetRequestConfiguration();
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
        public SearchRequestBuilder WithUrl(string rawUrl) {
            return new SearchRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of dashboards. This operation is similar to [Get dashboards](#api-rest-api-3-dashboard-get) except that the results can be refined to include dashboards that have specific attributes. For example, dashboards with a particular name. When multiple attributes are specified only filters matching all attributes are returned.This operation can be accessed anonymously.**[Permissions](#permissions) required:** The following dashboards that match the query parameters are returned: *  Dashboards owned by the user. Not returned for anonymous users. *  Dashboards shared with a group that the user is a member of. Not returned for anonymous users. *  Dashboards shared with a private project that the user can browse. Not returned for anonymous users. *  Dashboards shared with a public project. *  Dashboards shared with the public.
        /// </summary>
        public class SearchRequestBuilderGetQueryParameters {
            /// <summary>User account ID used to return dashboards with the matching `owner.accountId`. This parameter cannot be used with the `owner` parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("accountId")]
            public string? AccountId { get; set; }
#nullable restore
#else
            [QueryParameter("accountId")]
            public string AccountId { get; set; }
#endif
            /// <summary>String used to perform a case-insensitive partial match with `name`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("dashboardName")]
            public string? DashboardName { get; set; }
#nullable restore
#else
            [QueryParameter("dashboardName")]
            public string DashboardName { get; set; }
#endif
            /// <summary>Use [expand](#expansion) to include additional information about dashboard in the response. This parameter accepts a comma-separated list. Expand options include: *  `description` Returns the description of the dashboard. *  `owner` Returns the owner of the dashboard. *  `viewUrl` Returns the URL that is used to view the dashboard. *  `favourite` Returns `isFavourite`, an indicator of whether the user has set the dashboard as a favorite. *  `favouritedCount` Returns `popularity`, a count of how many users have set this dashboard as a favorite. *  `sharePermissions` Returns details of the share permissions defined for the dashboard. *  `editPermissions` Returns details of the edit permissions defined for the dashboard. *  `isWritable` Returns whether the current user has permission to edit the dashboard.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>Group ID used to return dashboards that are shared with a group that matches `sharePermissions.group.groupId`. This parameter cannot be used with the `groupname` parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("groupId")]
            public string? GroupId { get; set; }
#nullable restore
#else
            [QueryParameter("groupId")]
            public string GroupId { get; set; }
#endif
            /// <summary>As a group&apos;s name can change, use of `groupId` is recommended. Group name used to return dashboards that are shared with a group that matches `sharePermissions.group.name`. This parameter cannot be used with the `groupId` parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("groupname")]
            public string? Groupname { get; set; }
#nullable restore
#else
            [QueryParameter("groupname")]
            public string Groupname { get; set; }
#endif
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>[Order](#ordering) the results by a field: *  `description` Sorts by dashboard description. Note that this sort works independently of whether the expand to display the description field is in use. *  `favourite_count` Sorts by dashboard popularity. *  `id` Sorts by dashboard ID. *  `is_favourite` Sorts by whether the dashboard is marked as a favorite. *  `name` Sorts by dashboard name. *  `owner` Sorts by dashboard owner name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderBy")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("orderBy")]
            public string OrderBy { get; set; }
#endif
            /// <summary>This parameter is deprecated because of privacy changes. Use `accountId` instead. See the [migration guide](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details. User name used to return dashboards with the matching `owner.name`. This parameter cannot be used with the `accountId` parameter.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("owner")]
            public string? Owner { get; set; }
#nullable restore
#else
            [QueryParameter("owner")]
            public string Owner { get; set; }
#endif
            /// <summary>Project ID used to returns dashboards that are shared with a project that matches `sharePermissions.project.id`.</summary>
            [QueryParameter("projectId")]
            public long? ProjectId { get; set; }
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
            /// <summary>The status to filter by. It may be active, archived or deleted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("status")]
            public string? Status { get; set; }
#nullable restore
#else
            [QueryParameter("status")]
            public string Status { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class SearchRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public SearchRequestBuilderGetQueryParameters QueryParameters { get; set; } = new SearchRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new searchRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public SearchRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
