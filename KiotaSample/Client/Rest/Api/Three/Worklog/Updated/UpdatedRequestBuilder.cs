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
namespace AtlassianClient.Rest.Api.Three.Worklog.Updated {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\worklog\updated
    /// </summary>
    public class UpdatedRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new UpdatedRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdatedRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/worklog/updated{?since*,expand*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new UpdatedRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public UpdatedRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/worklog/updated{?since*,expand*}", rawUrl) {
        }
        /// <summary>
        /// Returns a list of IDs and update timestamps for worklogs updated after a date and time.This resource is paginated, with a limit of 1000 worklogs per page. Each page lists worklogs from oldest to youngest. If the number of items in the date range exceeds 1000, `until` indicates the timestamp of the youngest item on the page. Also, `nextPage` provides the URL for the next page of worklogs. The `lastPage` parameter is set to true on the last page of worklogs.This resource does not return worklogs updated during the minute preceding the request.**[Permissions](#permissions) required:** Permission to access Jira, however, worklogs are only returned where either of the following is true: *  the worklog is set as *Viewable by All Users*. *  the user is a member of a project role or group with permission to view the worklog.
        /// </summary>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ChangedWorklogs?> GetAsync(Action<UpdatedRequestBuilderGetRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ChangedWorklogs> GetAsync(Action<UpdatedRequestBuilderGetRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            var requestInfo = ToGetRequestInformation(requestConfiguration);
            return await RequestAdapter.SendAsync<ChangedWorklogs>(requestInfo, ChangedWorklogs.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Returns a list of IDs and update timestamps for worklogs updated after a date and time.This resource is paginated, with a limit of 1000 worklogs per page. Each page lists worklogs from oldest to youngest. If the number of items in the date range exceeds 1000, `until` indicates the timestamp of the youngest item on the page. Also, `nextPage` provides the URL for the next page of worklogs. The `lastPage` parameter is set to true on the last page of worklogs.This resource does not return worklogs updated during the minute preceding the request.**[Permissions](#permissions) required:** Permission to access Jira, however, worklogs are only returned where either of the following is true: *  the worklog is set as *Viewable by All Users*. *  the user is a member of a project role or group with permission to view the worklog.
        /// </summary>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToGetRequestInformation(Action<UpdatedRequestBuilderGetRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToGetRequestInformation(Action<UpdatedRequestBuilderGetRequestConfiguration> requestConfiguration = default) {
#endif
            var requestInfo = new RequestInformation {
                HttpMethod = Method.GET,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            if (requestConfiguration != null) {
                var requestConfig = new UpdatedRequestBuilderGetRequestConfiguration();
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
        public UpdatedRequestBuilder WithUrl(string rawUrl) {
            return new UpdatedRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Returns a list of IDs and update timestamps for worklogs updated after a date and time.This resource is paginated, with a limit of 1000 worklogs per page. Each page lists worklogs from oldest to youngest. If the number of items in the date range exceeds 1000, `until` indicates the timestamp of the youngest item on the page. Also, `nextPage` provides the URL for the next page of worklogs. The `lastPage` parameter is set to true on the last page of worklogs.This resource does not return worklogs updated during the minute preceding the request.**[Permissions](#permissions) required:** Permission to access Jira, however, worklogs are only returned where either of the following is true: *  the worklog is set as *Viewable by All Users*. *  the user is a member of a project role or group with permission to view the worklog.
        /// </summary>
        public class UpdatedRequestBuilderGetQueryParameters {
            /// <summary>Use [expand](#expansion) to include additional information about worklogs in the response. This parameter accepts `properties` that returns the properties of each worklog.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("expand")]
            public string? Expand { get; set; }
#nullable restore
#else
            [QueryParameter("expand")]
            public string Expand { get; set; }
#endif
            /// <summary>The date and time, as a UNIX timestamp in milliseconds, after which updated worklogs are returned.</summary>
            [QueryParameter("since")]
            public long? Since { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class UpdatedRequestBuilderGetRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public UpdatedRequestBuilderGetQueryParameters QueryParameters { get; set; } = new UpdatedRequestBuilderGetQueryParameters();
            /// <summary>
            /// Instantiates a new updatedRequestBuilderGetRequestConfiguration and sets the default values.
            /// </summary>
            public UpdatedRequestBuilderGetRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}