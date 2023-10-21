// <auto-generated/>
using AtlassianClient.Rest.Api.Three.App.Field.Item;
using AtlassianClient.Rest.Api.Three.App.Field.Value;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.App.Field {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\app\field
    /// </summary>
    public class FieldRequestBuilder : BaseRequestBuilder {
        /// <summary>The value property</summary>
        public ValueRequestBuilder Value { get =>
            new ValueRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.app.field.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithFieldIdOrKeyItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("fieldIdOrKey", position);
            return new WithFieldIdOrKeyItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new FieldRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FieldRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/app/field", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new FieldRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FieldRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/app/field", rawUrl) {
        }
    }
}
