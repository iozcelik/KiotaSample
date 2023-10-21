// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Mypreferences.Locale;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace AtlassianClient.Rest.Api.Three.Mypreferences {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\mypreferences
    /// </summary>
    public class MypreferencesRequestBuilder : BaseRequestBuilder {
        /// <summary>The locale property</summary>
        public LocaleRequestBuilder Locale { get =>
            new LocaleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new MypreferencesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MypreferencesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/mypreferences{?key*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new MypreferencesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public MypreferencesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/mypreferences{?key*}", rawUrl) {
        }
        /// <summary>
        /// Deletes a preference of the user, which restores the default value of system defined settings.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default, not set. The user takes the instance locale. *  *jira.user.timezone* The time zone of the user. By default, not set. The user takes the instance timezone.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<MypreferencesRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<MypreferencesRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the value of a preference of the current user.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default this is not set and the user takes the locale of the instance. *  *jira.user.timezone* The time zone of the user. By default this is not set and the user takes the timezone of the instance.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<string?> GetAsync(Action<MypreferencesRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<string> GetAsync(Action<MypreferencesRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendPrimitiveAsync<string>(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Creates a preference for the user or updates a preference&apos;s value by sending a plain text string. For example, `false`. An arbitrary preference can be created with the value containing up to 255 characters. In addition, the following keys define system preferences that can be set or created: *  *user.notifications.mimetype* The mime type used in notifications sent to the user. Defaults to `html`. *  *user.notify.own.changes* Whether the user gets notified of their own changes. Defaults to `false`. *  *user.default.share.private* Whether new [ filters](https://confluence.atlassian.com/x/eQiiLQ) are set to private. Defaults to `true`. *  *user.keyboard.shortcuts.disabled* Whether keyboard shortcuts are disabled. Defaults to `false`. *  *user.autowatch.disabled* Whether the user automatically watches issues they create or add a comment to. By default, not set: the user takes the instance autowatch setting.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default, not set. The user takes the instance locale. *  *jira.user.timezone* The time zone of the user. By default, not set. The user takes the instance timezone.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task PutAsync(string body, Action<MypreferencesRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task PutAsync(string body, Action<MypreferencesRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            if(string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a preference of the user, which restores the default value of system defined settings.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default, not set. The user takes the instance locale. *  *jira.user.timezone* The time zone of the user. By default, not set. The user takes the instance timezone.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<MypreferencesRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<MypreferencesRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new MypreferencesRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns the value of a preference of the current user.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default this is not set and the user takes the locale of the instance. *  *jira.user.timezone* The time zone of the user. By default this is not set and the user takes the timezone of the instance.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<MypreferencesRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<MypreferencesRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new MypreferencesRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Creates a preference for the user or updates a preference&apos;s value by sending a plain text string. For example, `false`. An arbitrary preference can be created with the value containing up to 255 characters. In addition, the following keys define system preferences that can be set or created: *  *user.notifications.mimetype* The mime type used in notifications sent to the user. Defaults to `html`. *  *user.notify.own.changes* Whether the user gets notified of their own changes. Defaults to `false`. *  *user.default.share.private* Whether new [ filters](https://confluence.atlassian.com/x/eQiiLQ) are set to private. Defaults to `true`. *  *user.keyboard.shortcuts.disabled* Whether keyboard shortcuts are disabled. Defaults to `false`. *  *user.autowatch.disabled* Whether the user automatically watches issues they create or add a comment to. By default, not set: the user takes the instance autowatch setting.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default, not set. The user takes the instance locale. *  *jira.user.timezone* The time zone of the user. By default, not set. The user takes the instance timezone.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        /// <param name="body">The request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(string body, Action<MypreferencesRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(string body, Action<MypreferencesRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
#endif
            if(string.IsNullOrEmpty(body)) throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.PUT,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.SetContentFromScalar(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new MypreferencesRequestBuilderPutRequestConfiguration();
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
        public MypreferencesRequestBuilder WithUrl(string rawUrl) {
            return new MypreferencesRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deletes a preference of the user, which restores the default value of system defined settings.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default, not set. The user takes the instance locale. *  *jira.user.timezone* The time zone of the user. By default, not set. The user takes the instance timezone.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        public class MypreferencesRequestBuilderDeleteQueryParameters {
            /// <summary>The key of the preference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("key")]
            public string? Key { get; set; }
#nullable restore
#else
            [QueryParameter("key")]
            public string Key { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MypreferencesRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MypreferencesRequestBuilderDeleteQueryParameters QueryParameters { get; set; } = new MypreferencesRequestBuilderDeleteQueryParameters();
            /// <summary>
            /// Instantiates a new mypreferencesRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public MypreferencesRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Returns the value of a preference of the current user.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default this is not set and the user takes the locale of the instance. *  *jira.user.timezone* The time zone of the user. By default this is not set and the user takes the timezone of the instance.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        public class MypreferencesRequestBuilderGetQueryParameters {
            /// <summary>The key of the preference.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("key")]
            public string? Key { get; set; }
#nullable restore
#else
            [QueryParameter("key")]
            public string Key { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MypreferencesRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MypreferencesRequestBuilderGetQueryParameters QueryParameters { get; set; } = new MypreferencesRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new mypreferencesRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public MypreferencesRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Creates a preference for the user or updates a preference&apos;s value by sending a plain text string. For example, `false`. An arbitrary preference can be created with the value containing up to 255 characters. In addition, the following keys define system preferences that can be set or created: *  *user.notifications.mimetype* The mime type used in notifications sent to the user. Defaults to `html`. *  *user.notify.own.changes* Whether the user gets notified of their own changes. Defaults to `false`. *  *user.default.share.private* Whether new [ filters](https://confluence.atlassian.com/x/eQiiLQ) are set to private. Defaults to `true`. *  *user.keyboard.shortcuts.disabled* Whether keyboard shortcuts are disabled. Defaults to `false`. *  *user.autowatch.disabled* Whether the user automatically watches issues they create or add a comment to. By default, not set: the user takes the instance autowatch setting.Note that these keys are deprecated: *  *jira.user.locale* The locale of the user. By default, not set. The user takes the instance locale. *  *jira.user.timezone* The time zone of the user. By default, not set. The user takes the instance timezone.Use [ Update a user profile](https://developer.atlassian.com/cloud/admin/user-management/rest/#api-users-account-id-manage-profile-patch) from the user management REST API to manage timezone and locale instead.**[Permissions](#permissions) required:** Permission to access Jira.
        /// </summary>
        public class MypreferencesRequestBuilderPutQueryParameters {
            /// <summary>The key of the preference. The maximum length is 255 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("key")]
            public string? Key { get; set; }
#nullable restore
#else
            [QueryParameter("key")]
            public string Key { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class MypreferencesRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public MypreferencesRequestBuilderPutQueryParameters QueryParameters { get; set; } = new MypreferencesRequestBuilderPutQueryParameters();
            /// <summary>
            /// Instantiates a new mypreferencesRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public MypreferencesRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}