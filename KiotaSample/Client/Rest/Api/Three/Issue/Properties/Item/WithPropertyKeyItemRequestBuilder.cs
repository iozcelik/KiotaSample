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
namespace AtlassianClient.Rest.Api.Three.Issue.Properties.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issue\properties\{propertyKey}
    /// </summary>
    public class WithPropertyKeyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithPropertyKeyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPropertyKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/properties/{propertyKey}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithPropertyKeyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPropertyKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issue/properties/{propertyKey}", rawUrl) {
        }
        /// <summary>
        /// Deletes a property value from multiple issues. The issues to be updated can be specified by filter criteria.The criteria the filter used to identify eligible issues are: *  `entityIds` Only issues from this list are eligible. *  `currentValue` Only issues with the property set to this value are eligible.If both criteria is specified, they are joined with the logical *AND*: only issues that satisfy both criteria are considered eligible.If no filter criteria are specified, all the issues visible to the user and where the user has the EDIT\_ISSUES permission for the issue are considered eligible.This operation is: *  transactional, either the property is deleted from all eligible issues or, when errors occur, no properties are deleted. *  [asynchronous](#async). Follow the `location` link in the response to determine the status of the task and use [Get task](#api-rest-api-3-task-taskId-get) to obtain subsequent updates.**[Permissions](#permissions) required:** *  *Browse projects* [ project permission](https://confluence.atlassian.com/x/yodKLg) for each project containing issues. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  *Edit issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for each issue.
        /// </summary>
        /// <param name="body">Bulk operation filter details.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> DeleteAsync(IssueFilterForBulkPropertyDelete body, Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> DeleteAsync(IssueFilterForBulkPropertyDelete body, Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToDeleteRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Sets a property value on multiple issues.The value set can be a constant or determined by a [Jira expression](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/). Expressions must be computable with constant complexity when applied to a set of issues. Expressions must also comply with the [restrictions](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/#restrictions) that apply to all Jira expressions.The issues to be updated can be specified by a filter.The filter identifies issues eligible for update using these criteria: *  `entityIds` Only issues from this list are eligible. *  `currentValue` Only issues with the property set to this value are eligible. *  `hasProperty`:         *  If *true*, only issues with the property are eligible.     *  If *false*, only issues without the property are eligible.If more than one criteria is specified, they are joined with the logical *AND*: only issues that satisfy all criteria are eligible.If an invalid combination of criteria is provided, an error is returned. For example, specifying a `currentValue` and `hasProperty` as *false* would not match any issues (because without the property the property cannot have a value).The filter is optional. Without the filter all the issues visible to the user and where the user has the EDIT\_ISSUES permission for the issue are considered eligible.This operation is: *  transactional, either all eligible issues are updated or, when errors occur, none are updated. *  [asynchronous](#async). Follow the `location` link in the response to determine the status of the task and use [Get task](#api-rest-api-3-task-taskId-get) to obtain subsequent updates.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for each project containing issues. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  *Edit issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for each issue.
        /// </summary>
        /// <param name="body">Bulk issue property update request details.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<Stream?> PutAsync(BulkIssuePropertyUpdateRequest body, Action<WithPropertyKeyItemRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<Stream> PutAsync(BulkIssuePropertyUpdateRequest body, Action<WithPropertyKeyItemRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendPrimitiveAsync<Stream>(requestInfo, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a property value from multiple issues. The issues to be updated can be specified by filter criteria.The criteria the filter used to identify eligible issues are: *  `entityIds` Only issues from this list are eligible. *  `currentValue` Only issues with the property set to this value are eligible.If both criteria is specified, they are joined with the logical *AND*: only issues that satisfy both criteria are considered eligible.If no filter criteria are specified, all the issues visible to the user and where the user has the EDIT\_ISSUES permission for the issue are considered eligible.This operation is: *  transactional, either the property is deleted from all eligible issues or, when errors occur, no properties are deleted. *  [asynchronous](#async). Follow the `location` link in the response to determine the status of the task and use [Get task](#api-rest-api-3-task-taskId-get) to obtain subsequent updates.**[Permissions](#permissions) required:** *  *Browse projects* [ project permission](https://confluence.atlassian.com/x/yodKLg) for each project containing issues. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  *Edit issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for each issue.
        /// </summary>
        /// <param name="body">Bulk operation filter details.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(IssueFilterForBulkPropertyDelete body, Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(IssueFilterForBulkPropertyDelete body, Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Sets a property value on multiple issues.The value set can be a constant or determined by a [Jira expression](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/). Expressions must be computable with constant complexity when applied to a set of issues. Expressions must also comply with the [restrictions](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/#restrictions) that apply to all Jira expressions.The issues to be updated can be specified by a filter.The filter identifies issues eligible for update using these criteria: *  `entityIds` Only issues from this list are eligible. *  `currentValue` Only issues with the property set to this value are eligible. *  `hasProperty`:         *  If *true*, only issues with the property are eligible.     *  If *false*, only issues without the property are eligible.If more than one criteria is specified, they are joined with the logical *AND*: only issues that satisfy all criteria are eligible.If an invalid combination of criteria is provided, an error is returned. For example, specifying a `currentValue` and `hasProperty` as *false* would not match any issues (because without the property the property cannot have a value).The filter is optional. Without the filter all the issues visible to the user and where the user has the EDIT\_ISSUES permission for the issue are considered eligible.This operation is: *  transactional, either all eligible issues are updated or, when errors occur, none are updated. *  [asynchronous](#async). Follow the `location` link in the response to determine the status of the task and use [Get task](#api-rest-api-3-task-taskId-get) to obtain subsequent updates.**[Permissions](#permissions) required:** *  *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for each project containing issues. *  If [issue-level security](https://confluence.atlassian.com/x/J4lKLg) is configured, issue-level security permission to view the issue. *  *Edit issues* [project permission](https://confluence.atlassian.com/x/yodKLg) for each issue.
        /// </summary>
        /// <param name="body">Bulk issue property update request details.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(BulkIssuePropertyUpdateRequest body, Action<WithPropertyKeyItemRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(BulkIssuePropertyUpdateRequest body, Action<WithPropertyKeyItemRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new WithPropertyKeyItemRequestBuilderPutRequestConfiguration();
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
        public WithPropertyKeyItemRequestBuilder WithUrl(string rawUrl) {
            return new WithPropertyKeyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithPropertyKeyItemRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new WithPropertyKeyItemRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public WithPropertyKeyItemRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
