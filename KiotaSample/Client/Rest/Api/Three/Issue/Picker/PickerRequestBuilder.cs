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
namespace AtlassianClient.Rest.Api.Three.Issue.Picker {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issue\picker
    /// </summary>
    public class PickerRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new PickerRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PickerRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/picker{?query*,currentJQL*,currentIssueKey*,currentProjectId*,showSubTasks*,showSubTaskParent*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new PickerRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public PickerRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/picker{?query*,currentJQL*,currentIssueKey*,currentProjectId*,showSubTasks*,showSubTaskParent*}", rawUrl) {
        }
        /// <summary>
        /// Returns lists of issues matching a query string. Use this resource to provide auto-completion suggestions when the user is looking for an issue using a word or string.This operation returns two lists: *  `History Search` which includes issues from the user&apos;s history of created, edited, or viewed issues that contain the string in the `query` parameter. *  `Current Search` which includes issues that match the JQL expression in `currentJQL` and contain the string in the `query` parameter.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<IssuePickerSuggestions?> GetAsync(Action<PickerRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<IssuePickerSuggestions> GetAsync(Action<PickerRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<IssuePickerSuggestions>(requestInfo, IssuePickerSuggestions.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns lists of issues matching a query string. Use this resource to provide auto-completion suggestions when the user is looking for an issue using a word or string.This operation returns two lists: *  `History Search` which includes issues from the user&apos;s history of created, edited, or viewed issues that contain the string in the `query` parameter. *  `Current Search` which includes issues that match the JQL expression in `currentJQL` and contain the string in the `query` parameter.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<PickerRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<PickerRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new PickerRequestBuilderGetRequestConfiguration();
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
        public PickerRequestBuilder WithUrl(string rawUrl) {
            return new PickerRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns lists of issues matching a query string. Use this resource to provide auto-completion suggestions when the user is looking for an issue using a word or string.This operation returns two lists: *  `History Search` which includes issues from the user&apos;s history of created, edited, or viewed issues that contain the string in the `query` parameter. *  `Current Search` which includes issues that match the JQL expression in `currentJQL` and contain the string in the `query` parameter.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        public class PickerRequestBuilderGetQueryParameters {
            /// <summary>The key of an issue to exclude from search results. For example, the issue the user is viewing when they perform this query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("currentIssueKey")]
            public string? CurrentIssueKey { get; set; }
#nullable restore
#else
            [QueryParameter("currentIssueKey")]
            public string CurrentIssueKey { get; set; }
#endif
            /// <summary>A JQL query defining a list of issues to search for the query term. Note that `username` and `userkey` cannot be used as search terms for this parameter, due to privacy reasons. Use `accountId` instead.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("currentJQL")]
            public string? CurrentJQL { get; set; }
#nullable restore
#else
            [QueryParameter("currentJQL")]
            public string CurrentJQL { get; set; }
#endif
            /// <summary>The ID of a project that suggested issues must belong to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("currentProjectId")]
            public string? CurrentProjectId { get; set; }
#nullable restore
#else
            [QueryParameter("currentProjectId")]
            public string CurrentProjectId { get; set; }
#endif
            /// <summary>A string to match against text fields in the issue such as title, description, or comments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("query")]
            public string? Query { get; set; }
#nullable restore
#else
            [QueryParameter("query")]
            public string Query { get; set; }
#endif
            /// <summary>When `currentIssueKey` is a subtask, whether to include the parent issue in the suggestions if it matches the query.</summary>
            [QueryParameter("showSubTaskParent")]
            public bool? ShowSubTaskParent { get; set; }
            /// <summary>Indicate whether to include subtasks in the suggestions list.</summary>
            [QueryParameter("showSubTasks")]
            public bool? ShowSubTasks { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class PickerRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public PickerRequestBuilderGetQueryParameters QueryParameters { get; set; } = new PickerRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new pickerRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public PickerRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
