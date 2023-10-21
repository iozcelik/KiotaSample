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
namespace AtlassianClient.Rest.Api.Three.User.Properties.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\user\properties\{propertyKey}
    /// </summary>
    public class WithPropertyKeyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new WithPropertyKeyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPropertyKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/properties/{propertyKey}{?accountId*,userKey*,username*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithPropertyKeyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithPropertyKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/user/properties/{propertyKey}{?accountId*,userKey*,username*}", rawUrl) {
        }
        /// <summary>
        /// Deletes a property from a user.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to delete a property from any user. *  Access to Jira, to delete a property from the calling user&apos;s record.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the value of a user&apos;s property. If no property key is provided [Get user property keys](#api-rest-api-3-user-properties-get) is called.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to get a property from any user. *  Access to Jira, to get a property from the calling user&apos;s record.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<EntityProperty?> GetAsync(Action<WithPropertyKeyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<EntityProperty> GetAsync(Action<WithPropertyKeyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<EntityProperty>(requestInfo, EntityProperty.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a property from a user.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to delete a property from any user. *  Access to Jira, to delete a property from the calling user&apos;s record.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns the value of a user&apos;s property. If no property key is provided [Get user property keys](#api-rest-api-3-user-properties-get) is called.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to get a property from any user. *  Access to Jira, to get a property from the calling user&apos;s record.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithPropertyKeyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithPropertyKeyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithPropertyKeyItemRequestBuilderGetRequestConfiguration();
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
        public WithPropertyKeyItemRequestBuilder WithUrl(string rawUrl) {
            return new WithPropertyKeyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deletes a property from a user.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to delete a property from any user. *  Access to Jira, to delete a property from the calling user&apos;s record.
        /// </summary>
        public class WithPropertyKeyItemRequestBuilderDeleteQueryParameters {
            /// <summary>The account ID of the user, which uniquely identifies the user across all Atlassian products. For example, *5b10ac8d82e05b22cc7d4ef5*.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("accountId")]
            public string? AccountId { get; set; }
#nullable restore
#else
            [QueryParameter("accountId")]
            public string AccountId { get; set; }
#endif
            /// <summary>This parameter is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("userKey")]
            public string? UserKey { get; set; }
#nullable restore
#else
            [QueryParameter("userKey")]
            public string UserKey { get; set; }
#endif
            /// <summary>This parameter is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
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
        public class WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithPropertyKeyItemRequestBuilderDeleteQueryParameters QueryParameters { get; set; } = new WithPropertyKeyItemRequestBuilderDeleteQueryParameters();
            /// <summary>
            /// Instantiates a new WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WithPropertyKeyItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Returns the value of a user&apos;s property. If no property key is provided [Get user property keys](#api-rest-api-3-user-properties-get) is called.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to get a property from any user. *  Access to Jira, to get a property from the calling user&apos;s record.
        /// </summary>
        public class WithPropertyKeyItemRequestBuilderGetQueryParameters {
            /// <summary>The account ID of the user, which uniquely identifies the user across all Atlassian products. For example, *5b10ac8d82e05b22cc7d4ef5*.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("accountId")]
            public string? AccountId { get; set; }
#nullable restore
#else
            [QueryParameter("accountId")]
            public string AccountId { get; set; }
#endif
            /// <summary>This parameter is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("userKey")]
            public string? UserKey { get; set; }
#nullable restore
#else
            [QueryParameter("userKey")]
            public string UserKey { get; set; }
#endif
            /// <summary>This parameter is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
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
        public class WithPropertyKeyItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithPropertyKeyItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithPropertyKeyItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithPropertyKeyItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithPropertyKeyItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Sets the value of a user&apos;s property. Use this resource to store custom data against a user.Note: This operation does not access the [user properties](https://confluence.atlassian.com/x/8YxjL) created and maintained in Jira.**[Permissions](#permissions) required:** *  *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg), to set a property on any user. *  Access to Jira, to set a property on the calling user&apos;s record.
        /// </summary>
        public class WithPropertyKeyItemRequestBuilderPutQueryParameters {
            /// <summary>The account ID of the user, which uniquely identifies the user across all Atlassian products. For example, *5b10ac8d82e05b22cc7d4ef5*.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("accountId")]
            public string? AccountId { get; set; }
#nullable restore
#else
            [QueryParameter("accountId")]
            public string AccountId { get; set; }
#endif
            /// <summary>This parameter is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("userKey")]
            public string? UserKey { get; set; }
#nullable restore
#else
            [QueryParameter("userKey")]
            public string UserKey { get; set; }
#endif
            /// <summary>This parameter is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
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
        public class WithPropertyKeyItemRequestBuilderPutRequestConfiguration {
        }
    }
}
