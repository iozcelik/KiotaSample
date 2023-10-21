// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Dashboard.Item.Items.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Dashboard.Item.Items {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\dashboard\{dashboardId}\items
    /// </summary>
    public class ItemsRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.dashboard.item.items.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithItemIdItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("itemId", position);
            return new WithItemIdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/{dashboardId}/items", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ItemsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ItemsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/{dashboardId}/items", rawUrl) {
        }
    }
}
