// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Attachment.Content.Item;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Attachment.Content {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\attachment\content
    /// </summary>
    public class ContentRequestBuilder : BaseRequestBuilder {
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.attachment.content.item collection</summary>
        /// <param name="position">The ID of the attachment.</param>
        public WithIdItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("id", position);
            return new WithIdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment/content", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ContentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment/content", rawUrl) {
        }
    }
}