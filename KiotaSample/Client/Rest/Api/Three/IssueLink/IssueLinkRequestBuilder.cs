// <auto-generated/>
using AtlassianClient.Rest.Api.Three.IssueLink.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
using static AtlassianClient.Rest.Api.Three.App.Field.Value.ValueRequestBuilder;
using AtlassianClient.Models;
using static AtlassianClient.Rest.Api.Three.Dashboard.Item.Gadget.GadgetRequestBuilder;
using Microsoft.Kiota.Abstractions.Serialization;

namespace AtlassianClient.Rest.Api.Three.IssueLink {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issueLink
    /// </summary>
    public class IssueLinkRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.issueLink.item collection</summary>
        /// <param name="position">The ID of the issue link.</param>
        public WithLinkIdItemRequestBuilder this[string position] {
            get {
                var urlTplParams = new Dictionary<string, object>(PathParameters);
                urlTplParams.Add("linkId", position);
                return new WithLinkIdItemRequestBuilder(urlTplParams, RequestAdapter);
            }
        }
        /// <summary>
        /// Instantiates a new IssueLinkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssueLinkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issueLink", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new IssueLinkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssueLinkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issueLink", rawUrl) {
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public IssueLinkRequestBuilder WithUrl(string rawUrl) {
            return new IssueLinkRequestBuilder(rawUrl, RequestAdapter);
        }

        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class IssueLinkRequestBuilderPostRequestConfiguration {
            public RequestHeaders Headers { get; set; }
            public IList<IRequestOption> Options { get; set; }
            public IssueLinkRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }

        public RequestInformation ToPostRequestInformation(LinkIssueRequestJsonBean body, Action<IssueLinkRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new IssueLinkRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }

        public async Task PostAsync(LinkIssueRequestJsonBean body, Action<IssueLinkRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"404", ErrorCollection.CreateFromDiscriminatorValue},
            };
            await RequestAdapter.SendAsync(requestInfo, LinkIssueRequestJsonBean.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
    }
}
