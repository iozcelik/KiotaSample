// <auto-generated/>
using AtlassianClient.Models;
using AtlassianClient.Rest.Api.Three.Workflows.Update.Validation;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace AtlassianClient.Rest.Api.Three.Workflows.Update {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\workflows\update
    /// </summary>
    public class UpdateRequestBuilder : BaseRequestBuilder {
        /// <summary>The validation property</summary>
        public ValidationRequestBuilder Validation { get =>
            new ValidationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new UpdateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdateRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/workflows/update{?expand*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UpdateRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdateRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/workflows/update{?expand*}", rawUrl) {
        }
        /// <summary>
        /// Update workflows and related statuses.**[Permissions](#permissions) required:** *  *Administer Jira* project permission to create all, including global-scoped, workflows *  *Administer projects* project permissions to create project-scoped workflows
        /// </summary>
        /// <param name="body">The update workflows payload.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkflowUpdateResponse?> PostAsync(WorkflowUpdateRequest body, Action<UpdateRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkflowUpdateResponse> PostAsync(WorkflowUpdateRequest body, Action<UpdateRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<WorkflowUpdateResponse>(requestInfo, WorkflowUpdateResponse.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Update workflows and related statuses.**[Permissions](#permissions) required:** *  *Administer Jira* project permission to create all, including global-scoped, workflows *  *Administer projects* project permissions to create project-scoped workflows
        /// </summary>
        /// <param name="body">The update workflows payload.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(WorkflowUpdateRequest body, Action<UpdateRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(WorkflowUpdateRequest body, Action<UpdateRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new UpdateRequestBuilderPostRequestConfiguration();
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
        public UpdateRequestBuilder WithUrl(string rawUrl) {
            return new UpdateRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Update workflows and related statuses.**[Permissions](#permissions) required:** *  *Administer Jira* project permission to create all, including global-scoped, workflows *  *Administer projects* project permissions to create project-scoped workflows
        /// </summary>
        public class UpdateRequestBuilderPostQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts a comma-separated list. Expand options include: *  `workflows.usages` Returns the project and issue types that each workflow is associated with. *  `statuses.usages` Returns the project and issue types that each status is associated with.</summary>
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
        public class UpdateRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UpdateRequestBuilderPostQueryParameters QueryParameters { get; set; } = new UpdateRequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new updateRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public UpdateRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
