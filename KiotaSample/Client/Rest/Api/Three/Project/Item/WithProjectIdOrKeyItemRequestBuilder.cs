// <auto-generated/>
using AtlassianClient.Models;
using AtlassianClient.Rest.Api.Three.Project.Item.Archive;
using AtlassianClient.Rest.Api.Three.Project.Item.Avatar2;
using AtlassianClient.Rest.Api.Three.Project.Item.Avatar;
using AtlassianClient.Rest.Api.Three.Project.Item.Avatars;
using AtlassianClient.Rest.Api.Three.Project.Item.Component;
using AtlassianClient.Rest.Api.Three.Project.Item.Components;
using AtlassianClient.Rest.Api.Three.Project.Item.Delete;
using AtlassianClient.Rest.Api.Three.Project.Item.Email;
using AtlassianClient.Rest.Api.Three.Project.Item.Features;
using AtlassianClient.Rest.Api.Three.Project.Item.Hierarchy;
using AtlassianClient.Rest.Api.Three.Project.Item.Issuesecuritylevelscheme;
using AtlassianClient.Rest.Api.Three.Project.Item.Notificationscheme;
using AtlassianClient.Rest.Api.Three.Project.Item.Permissionscheme;
using AtlassianClient.Rest.Api.Three.Project.Item.Properties;
using AtlassianClient.Rest.Api.Three.Project.Item.Restore;
using AtlassianClient.Rest.Api.Three.Project.Item.Role;
using AtlassianClient.Rest.Api.Three.Project.Item.Roledetails;
using AtlassianClient.Rest.Api.Three.Project.Item.Securitylevel;
using AtlassianClient.Rest.Api.Three.Project.Item.Statuses;
using AtlassianClient.Rest.Api.Three.Project.Item.VersionNamespace;
using AtlassianClient.Rest.Api.Three.Project.Item.Versions;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace AtlassianClient.Rest.Api.Three.Project.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\project\{projectIdOrKey}
    /// </summary>
    public class WithProjectIdOrKeyItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The archive property</summary>
        public ArchiveRequestBuilder Archive { get =>
            new ArchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The avatar property</summary>
        public AvatarRequestBuilder Avatar { get =>
            new AvatarRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The avatar2 property</summary>
        public Avatar2RequestBuilder Avatar2 { get =>
            new Avatar2RequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The avatars property</summary>
        public AvatarsRequestBuilder Avatars { get =>
            new AvatarsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The component property</summary>
        public ComponentRequestBuilder Component { get =>
            new ComponentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The components property</summary>
        public ComponentsRequestBuilder Components { get =>
            new ComponentsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The deletePath property</summary>
        public DeleteRequestBuilder DeletePath { get =>
            new DeleteRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The email property</summary>
        public EmailRequestBuilder Email { get =>
            new EmailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The features property</summary>
        public FeaturesRequestBuilder Features { get =>
            new FeaturesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The hierarchy property</summary>
        public HierarchyRequestBuilder Hierarchy { get =>
            new HierarchyRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The issuesecuritylevelscheme property</summary>
        public IssuesecuritylevelschemeRequestBuilder Issuesecuritylevelscheme { get =>
            new IssuesecuritylevelschemeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The notificationscheme property</summary>
        public NotificationschemeRequestBuilder Notificationscheme { get =>
            new NotificationschemeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The permissionscheme property</summary>
        public PermissionschemeRequestBuilder Permissionscheme { get =>
            new PermissionschemeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The properties property</summary>
        public PropertiesRequestBuilder Properties { get =>
            new PropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The restore property</summary>
        public RestoreRequestBuilder Restore { get =>
            new RestoreRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The role property</summary>
        public RoleRequestBuilder Role { get =>
            new RoleRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The roledetails property</summary>
        public RoledetailsRequestBuilder Roledetails { get =>
            new RoledetailsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The securitylevel property</summary>
        public SecuritylevelRequestBuilder Securitylevel { get =>
            new SecuritylevelRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The statuses property</summary>
        public StatusesRequestBuilder Statuses { get =>
            new StatusesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The version property</summary>
        public VersionRequestBuilder Version { get =>
            new VersionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The versions property</summary>
        public VersionsRequestBuilder Versions { get =>
            new VersionsRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithProjectIdOrKeyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProjectIdOrKeyItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/project/{projectIdOrKey}{?expand*,properties*,enableUndo*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithProjectIdOrKeyItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithProjectIdOrKeyItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/project/{projectIdOrKey}{?expand*,properties*,enableUndo*}", rawUrl) {
        }
        /// <summary>
        /// Deletes a project.You can&apos;t delete a project if it&apos;s archived. To delete an archived project, restore the project and then delete it. To restore a project, use the Jira UI.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task DeleteAsync(Action<WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task DeleteAsync(Action<WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToDeleteRequestInformation(requestConfiguration);
            await RequestAdapter.SendNoContentAsync(requestInfo, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns the [project details](https://confluence.atlassian.com/x/ahLpNw) for a project.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AtlassianClient.Models.Project?> GetAsync(Action<WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AtlassianClient.Models.Project> GetAsync(Action<WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<AtlassianClient.Models.Project>(requestInfo, AtlassianClient.Models.Project.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Updates the [project details](https://confluence.atlassian.com/x/ahLpNw) of a project.All parameters are optional in the body of the request. Schemes will only be updated if they are included in the request, any omitted schemes will be left unchanged.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). is only needed when changing the schemes or project key. Otherwise you will only need *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg)
        /// </summary>
        /// <param name="body">Details about the project.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AtlassianClient.Models.Project?> PutAsync(UpdateProjectDetails body, Action<WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AtlassianClient.Models.Project> PutAsync(UpdateProjectDetails body, Action<WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<AtlassianClient.Models.Project>(requestInfo, AtlassianClient.Models.Project.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Deletes a project.You can&apos;t delete a project if it&apos;s archived. To delete an archived project, restore the project and then delete it. To restore a project, use the Jira UI.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToDeleteRequestInformation(Action<WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToDeleteRequestInformation(Action<WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.DELETE,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            if (requestConfiguration != null) {
                var requestConfig = new WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns the [project details](https://confluence.atlassian.com/x/ahLpNw) for a project.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Updates the [project details](https://confluence.atlassian.com/x/ahLpNw) of a project.All parameters are optional in the body of the request. Schemes will only be updated if they are included in the request, any omitted schemes will be left unchanged.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). is only needed when changing the schemes or project key. Otherwise you will only need *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg)
        /// </summary>
        /// <param name="body">Details about the project.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(UpdateProjectDetails body, Action<WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(UpdateProjectDetails body, Action<WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration();
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
        public WithProjectIdOrKeyItemRequestBuilder WithUrl(string rawUrl) {
            return new WithProjectIdOrKeyItemRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Deletes a project.You can&apos;t delete a project if it&apos;s archived. To delete an archived project, restore the project and then delete it. To restore a project, use the Jira UI.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class WithProjectIdOrKeyItemRequestBuilderDeleteQueryParameters {
            /// <summary>Whether this project is placed in the Jira recycle bin where it will be available for restoration.</summary>
            [QueryParameter("enableUndo")]
            public bool? EnableUndo { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithProjectIdOrKeyItemRequestBuilderDeleteQueryParameters QueryParameters { get; set; } = new WithProjectIdOrKeyItemRequestBuilderDeleteQueryParameters();
            /// <summary>
            /// Instantiates a new WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration and sets the default values.
            /// </summary>
            public WithProjectIdOrKeyItemRequestBuilderDeleteRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Returns the [project details](https://confluence.atlassian.com/x/ahLpNw) for a project.This operation can be accessed anonymously.**[Permissions](#permissions) required:** *Browse projects* [project permission](https://confluence.atlassian.com/x/yodKLg) for the project.
        /// </summary>
        public class WithProjectIdOrKeyItemRequestBuilderGetQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts a comma-separated list. Note that the project description, issue types, and project lead are included in all responses by default. Expand options include: *  `description` The project description. *  `issueTypes` The issue types associated with the project. *  `lead` The project lead. *  `projectKeys` All project keys associated with the project. *  `issueTypeHierarchy` The project issue type hierarchy.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>A list of project properties to return for the project. This parameter accepts a comma-separated list.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("properties")]
            public string[]? Properties { get; set; }
#nullable restore
#else
            [QueryParameter("properties")]
            public string[] Properties { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithProjectIdOrKeyItemRequestBuilderGetQueryParameters QueryParameters { get; set; } = new WithProjectIdOrKeyItemRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public WithProjectIdOrKeyItemRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
        /// <summary>
        /// Updates the [project details](https://confluence.atlassian.com/x/ahLpNw) of a project.All parameters are optional in the body of the request. Schemes will only be updated if they are included in the request, any omitted schemes will be left unchanged.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg). is only needed when changing the schemes or project key. Otherwise you will only need *Administer Projects* [project permission](https://confluence.atlassian.com/x/yodKLg)
        /// </summary>
        public class WithProjectIdOrKeyItemRequestBuilderPutQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information in the response. This parameter accepts a comma-separated list. Note that the project description, issue types, and project lead are included in all responses by default. Expand options include: *  `description` The project description. *  `issueTypes` The issue types associated with the project. *  `lead` The project lead. *  `projectKeys` All project keys associated with the project.</summary>
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
        public class WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public WithProjectIdOrKeyItemRequestBuilderPutQueryParameters QueryParameters { get; set; } = new WithProjectIdOrKeyItemRequestBuilderPutQueryParameters();
            /// <summary>
            /// Instantiates a new WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public WithProjectIdOrKeyItemRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
