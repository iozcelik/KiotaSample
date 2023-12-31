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
namespace AtlassianClient.Rest.Api.Three.Workflow.Search {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\workflow\search
    /// </summary>
    public class SearchRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new SearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/workflow/search{?startAt*,maxResults*,workflowName*,expand*,queryString*,orderBy*,isActive*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SearchRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SearchRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/workflow/search{?startAt*,maxResults*,workflowName*,expand*,queryString*,orderBy*,isActive*}", rawUrl) {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of published classic workflows. When workflow names are specified, details of those workflows are returned. Otherwise, all published classic workflows are returned.This operation does not return next-gen workflows.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanWorkflow?> GetAsync(Action<SearchRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PageBeanWorkflow> GetAsync(Action<SearchRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"403", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<PageBeanWorkflow>(requestInfo, PageBeanWorkflow.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of published classic workflows. When workflow names are specified, details of those workflows are returned. Otherwise, all published classic workflows are returned.This operation does not return next-gen workflows.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
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
        /// Returns a [paginated](#pagination) list of published classic workflows. When workflow names are specified, details of those workflows are returned. Otherwise, all published classic workflows are returned.This operation does not return next-gen workflows.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class SearchRequestBuilderGetQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts a comma-separated list. Expand options include: *  `transitions` For each workflow, returns information about the transitions inside the workflow. *  `transitions.rules` For each workflow transition, returns information about its rules. Transitions are included automatically if this expand is requested. *  `transitions.properties` For each workflow transition, returns information about its properties. Transitions are included automatically if this expand is requested. *  `statuses` For each workflow, returns information about the statuses inside the workflow. *  `statuses.properties` For each workflow status, returns information about its properties. Statuses are included automatically if this expand is requested. *  `default` For each workflow, returns information about whether this is the default workflow. *  `schemes` For each workflow, returns information about the workflow schemes the workflow is assigned to. *  `projects` For each workflow, returns information about the projects the workflow is assigned to, through workflow schemes. *  `hasDraftWorkflow` For each workflow, returns information about whether the workflow has a draft version. *  `operations` For each workflow, returns information about the actions that can be undertaken on the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>Filters active and inactive workflows.</summary>
            [QueryParameter("isActive")]
            public bool? IsActive { get; set; }
            /// <summary>The maximum number of items to return per page.</summary>
            [QueryParameter("maxResults")]
            public int? MaxResults { get; set; }
            /// <summary>[Order](#ordering) the results by a field: *  `name` Sorts by workflow name. *  `created` Sorts by create time. *  `updated` Sorts by update time.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("orderBy")]
            public string? OrderBy { get; set; }
#nullable restore
#else
            [QueryParameter("orderBy")]
            public string OrderBy { get; set; }
#endif
            /// <summary>String used to perform a case-insensitive partial match with workflow name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("queryString")]
            public string? QueryString { get; set; }
#nullable restore
#else
            [QueryParameter("queryString")]
            public string QueryString { get; set; }
#endif
            /// <summary>The index of the first item to return in a page of results (page offset).</summary>
            [QueryParameter("startAt")]
            public long? StartAt { get; set; }
            /// <summary>The name of a workflow to return. To include multiple workflows, provide an ampersand-separated list. For example, `workflowName=name1&amp;workflowName=name2`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("workflowName")]
            public string[]? WorkflowName { get; set; }
#nullable restore
#else
            [QueryParameter("workflowName")]
            public string[] WorkflowName { get; set; }
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
