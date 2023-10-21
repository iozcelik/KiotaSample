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
namespace AtlassianClient.Rest.Api.Three.Comment.List {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\comment\list
    /// </summary>
    public class ListRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ListRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/comment/list{?expand*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ListRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ListRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/comment/list{?expand*}", rawUrl) {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of comments specified by a list of comment IDs.This operation can be accessed anonymously.**[Permissions](#permissions) required:** Comments are returned where the user: *  has *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project containing the comment. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  If the comment has visibility restrictions, belongs to the group or has the role visibility is restricted to.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanComment?> PostAsync(IssueCommentListRequestBean body, Action<ListRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PageBeanComment> PostAsync(IssueCommentListRequestBean body, Action<ListRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanComment>(requestInfo, PageBeanComment.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of comments specified by a list of comment IDs.This operation can be accessed anonymously.**[Permissions](#permissions) required:** Comments are returned where the user: *  has *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project containing the comment. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  If the comment has visibility restrictions, belongs to the group or has the role visibility is restricted to.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(IssueCommentListRequestBean body, Action<ListRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(IssueCommentListRequestBean body, Action<ListRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ListRequestBuilderPostRequestConfiguration();
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
        public ListRequestBuilder WithUrl(string rawUrl) {
            return new ListRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of comments specified by a list of comment IDs.This operation can be accessed anonymously.**[Permissions](#permissions) required:** Comments are returned where the user: *  has *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project containing the comment. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  If the comment has visibility restrictions, belongs to the group or has the role visibility is restricted to.
        /// </summary>
        public class ListRequestBuilderPostQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information about comments in the response. This parameter accepts a comma-separated list. Expand options include: *  `renderedBody` Returns the comment body rendered in HTML. *  `properties` Returns the comment&apos;s properties.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ListRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ListRequestBuilderPostQueryParameters QueryParameters { get; set; } = new ListRequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new listRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ListRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}