// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Dashboard.Item.Items.Item.Properties;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Dashboard.Item.Items.Item {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\dashboard\{dashboardId}\items\{itemId}
    /// </summary>
    public class WithItemIdItemRequestBuilder : BaseRequestBuilder {
        /// <summary>The properties property</summary>
        public PropertiesRequestBuilder Properties { get =>
            new PropertiesRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new WithItemIdItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithItemIdItemRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/{dashboardId}/items/{itemId}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new WithItemIdItemRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public WithItemIdItemRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/{dashboardId}/items/{itemId}", rawUrl) {
        }
    }
}
