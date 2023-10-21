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
namespace AtlassianClient.Rest.Api.Three.Dashboard.Bulk.Edit {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\dashboard\bulk\edit
    /// </summary>
    public class EditRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new EditRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EditRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/bulk/edit", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new EditRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public EditRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/bulk/edit", rawUrl) {
        }
        /// <summary>
        /// Bulk edit dashboards. Maximum number of dashboards to be edited at the same time is 100.**[Permissions](#permissions) required:** NoneThe dashboards to be updated must be owned by the user, or the user must be an administrator.
        /// </summary>
        /// <param name="body">Details of a request to bulk edit shareable entity.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<BulkEditShareableEntityResponse?> PutAsync(BulkEditShareableEntityRequest body, Action<EditRequestBuilderPutRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<BulkEditShareableEntityResponse> PutAsync(BulkEditShareableEntityRequest body, Action<EditRequestBuilderPutRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPutRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"401", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<BulkEditShareableEntityResponse>(requestInfo, BulkEditShareableEntityResponse.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Bulk edit dashboards. Maximum number of dashboards to be edited at the same time is 100.**[Permissions](#permissions) required:** NoneThe dashboards to be updated must be owned by the user, or the user must be an administrator.
        /// </summary>
        /// <param name="body">Details of a request to bulk edit shareable entity.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPutRequestInformation(BulkEditShareableEntityRequest body, Action<EditRequestBuilderPutRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPutRequestInformation(BulkEditShareableEntityRequest body, Action<EditRequestBuilderPutRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new EditRequestBuilderPutRequestConfiguration();
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
        public EditRequestBuilder WithUrl(string rawUrl) {
            return new EditRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class EditRequestBuilderPutRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>
            /// Instantiates a new editRequestBuilderPutRequestConfiguration and sets the default values.
            /// </summary>
            public EditRequestBuilderPutRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
