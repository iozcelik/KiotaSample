// <auto-generated/>
using AtlassianClient.Models;
using AtlassianClient.Rest.Api.Three.Field.Item.Context.DefaultValue;
using AtlassianClient.Rest.Api.Three.Field.Item.Context.Issuetypemapping;
using AtlassianClient.Rest.Api.Three.Field.Item.Context.Item;
using AtlassianClient.Rest.Api.Three.Field.Item.Context.Mapping;
using AtlassianClient.Rest.Api.Three.Field.Item.Context.Projectmapping;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace AtlassianClient.Rest.Api.Three.Field.Item.Context {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\field\{fieldId}\context
    /// </summary>
    public class ContextRequestBuilder : BaseRequestBuilder {
        /// <summary>The defaultValue property</summary>
        public DefaultValueRequestBuilder DefaultValue { get =>
            new DefaultValueRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issuetypemapping property</summary>
        public IssuetypemappingRequestBuilder Issuetypemapping { get =>
            new IssuetypemappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The mapping property</summary>
        public MappingRequestBuilder Mapping { get =>
            new MappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The projectmapping property</summary>
        public ProjectmappingRequestBuilder Projectmapping { get =>
            new ProjectmappingRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.field.item.context.item collection</summary>
        /// <param name="position">The ID of the context.</param>
        public WithContextIdItemRequestBuilder this[long position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("contextId", position);
            return new WithContextIdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.field.item.context.item collection</summary>
        /// <param name="position">The ID of the context.</param>
        [Obsolete("This indexer is deprecated and will be removed in the next major version. Use the one with the typed parameter instead.")]
        public WithContextIdItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            if (!string.IsNullOrWhiteSpace(position)) urlTplParams.Add("contextId", position);
            return new WithContextIdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ContextRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContextRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{fieldId}/context{?isAnyIssueType*,isGlobalContext*,contextId*,startAt*,maxResults*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ContextRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContextRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{fieldId}/context{?isAnyIssueType*,isGlobalContext*,contextId*,startAt*,maxResults*}", rawUrl) {
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of [ contexts](https://confluence.atlassian.com/adminjiracloud/what-are-custom-field-contexts-991923859.html) for a custom field. Contexts can be returned as follows: *  With no other parameters set, all contexts. *  By defining `id` only, all contexts from the list of IDs. *  By defining `isAnyIssueType`, limit the list of contexts returned to either those that apply to all issue types (true) or those that apply to only a subset of issue types (false) *  By defining `isGlobalContext`, limit the list of contexts return to either those that apply to all projects (global contexts) (true) or those that apply to only a subset of projects (false).**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<PageBeanCustomFieldContext?> GetAsync(Action<ContextRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<PageBeanCustomFieldContext> GetAsync(Action<ContextRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<PageBeanCustomFieldContext>(requestInfo, PageBeanCustomFieldContext.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a custom field context.If `projectIds` is empty, a global context is created. A global context is one that applies to all project. If `issueTypeIds` is empty, the context applies to all issue types.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="body">The details of a created custom field context.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<CreateCustomFieldContext?> PostAsync(CreateCustomFieldContext body, Action<ContextRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<CreateCustomFieldContext> PostAsync(CreateCustomFieldContext body, Action<ContextRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<CreateCustomFieldContext>(requestInfo, CreateCustomFieldContext.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of [ contexts](https://confluence.atlassian.com/adminjiracloud/what-are-custom-field-contexts-991923859.html) for a custom field. Contexts can be returned as follows: *  With no other parameters set, all contexts. *  By defining `id` only, all contexts from the list of IDs. *  By defining `isAnyIssueType`, limit the list of contexts returned to either those that apply to all issue types (true) or those that apply to only a subset of issue types (false) *  By defining `isGlobalContext`, limit the list of contexts return to either those that apply to all projects (global contexts) (true) or those that apply to only a subset of projects (false).**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<ContextRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<ContextRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new ContextRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Creates a custom field context.If `projectIds` is empty, a global context is created. A global context is one that applies to all project. If `issueTypeIds` is empty, the context applies to all issue types.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="body">The details of a created custom field context.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(CreateCustomFieldContext body, Action<ContextRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(CreateCustomFieldContext body, Action<ContextRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new ContextRequestBuilderPostRequestConfiguration();
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
        public ContextRequestBuilder WithUrl(string rawUrl) {
            return new ContextRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a [paginated](#pagination) list of [ contexts](https://confluence.atlassian.com/adminjiracloud/what-are-custom-field-contexts-991923859.html) for a custom field. Contexts can be returned as follows: *  With no other parameters set, all contexts. *  By defining `id` only, all contexts from the list of IDs. *  By defining `isAnyIssueType`, limit the list of contexts returned to either those that apply to all issue types (true) or those that apply to only a subset of issue types (false) *  By defining `isGlobalContext`, limit the list of contexts return to either those that apply to all projects (global contexts) (true) or those that apply to only a subset of projects (false).**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class ContextRequestBuilderGetQueryParameters {
            /// <summary>The list of context IDs. To include multiple contexts, separate IDs with ampersand: `contextId=10000&amp;contextId=10001`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("contextId")]
            public long?[]? ContextId { get; set; }
#nullable restore
#else
            [QueryParameter("contextId")]
            public long?[] ContextId { get; set; }
#endif
            /// <summary>Whether to return contexts that apply to all issue types.</summary>
            [QueryParameter("isAnyIssueType")]
            public bool? IsAnyIssueType { get; set; }
            /// <summary>Whether to return contexts that apply to all projects.</summary>
            [QueryParameter("isGlobalContext")]
            public bool? IsGlobalContext { get; set; }
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
        public class ContextRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ContextRequestBuilderGetQueryParameters QueryParameters { get; set; } = new ContextRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new contextRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public ContextRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ContextRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new contextRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ContextRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
