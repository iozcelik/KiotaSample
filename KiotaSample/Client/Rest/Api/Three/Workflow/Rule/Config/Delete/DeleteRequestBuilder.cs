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
namespace AtlassianClient.Rest.Api.Three.Workflow.Rule.Config.Delete {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\workflow\rule\config\delete
    /// </summary>
    public class DeleteRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new DeleteRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeleteRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/workflow/rule/config/delete", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new DeleteRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public DeleteRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/workflow/rule/config/delete", rawUrl) {
        }
        /// <summary>
        /// Deletes workflow transition rules from one or more workflows. These rule types are supported: *  [post functions](https://developer.atlassian.com/cloud/jira/platform/modules/workflow-post-function/) *  [conditions](https://developer.atlassian.com/cloud/jira/platform/modules/workflow-condition/) *  [validators](https://developer.atlassian.com/cloud/jira/platform/modules/workflow-validator/)Only rules created by the calling Connect app can be deleted.**[Permissions](#permissions) required:** Only Connect apps can use this operation.
        /// </summary>
        /// <param name="body">Details of workflows and their transition rules to delete.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<WorkflowTransitionRulesUpdateErrors?> PutAsync(WorkflowsWithTransitionRulesDetails body, Action<DeleteRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<WorkflowTransitionRulesUpdateErrors> PutAsync(WorkflowsWithTransitionRulesDetails body, Action<DeleteRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"403", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<WorkflowTransitionRulesUpdateErrors>(requestInfo, WorkflowTransitionRulesUpdateErrors.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes workflow transition rules from one or more workflows. These rule types are supported: *  [post functions](https://developer.atlassian.com/cloud/jira/platform/modules/workflow-post-function/) *  [conditions](https://developer.atlassian.com/cloud/jira/platform/modules/workflow-condition/) *  [validators](https://developer.atlassian.com/cloud/jira/platform/modules/workflow-validator/)Only rules created by the calling Connect app can be deleted.**[Permissions](#permissions) required:** Only Connect apps can use this operation.
        /// </summary>
        /// <param name="body">Details of workflows and their transition rules to delete.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(WorkflowsWithTransitionRulesDetails body, Action<DeleteRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(WorkflowsWithTransitionRulesDetails body, Action<DeleteRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new DeleteRequestBuilderPutRequestConfiguration();
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
        public DeleteRequestBuilder WithUrl(string rawUrl) {
            return new DeleteRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class DeleteRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new deleteRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public DeleteRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
