// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Attachment.Content;
using AtlassianClient.Rest.Api.Three.Attachment.Item;
using AtlassianClient.Rest.Api.Three.Attachment.Meta;
using AtlassianClient.Rest.Api.Three.Attachment.Thumbnail;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Attachment {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\attachment
    /// </summary>
    public class AttachmentRequestBuilder : BaseRequestBuilder {
        /// <summary>The content property</summary>
        public ContentRequestBuilder Content { get =>
            new ContentRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The meta property</summary>
        public MetaRequestBuilder Meta { get =>
            new MetaRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The thumbnail property</summary>
        public ThumbnailRequestBuilder Thumbnail { get =>
            new ThumbnailRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.attachment.item collection</summary>
        /// <param name="position">The ID of the attachment.</param>
        public WithIdItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("id", position);
            return new WithIdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new AttachmentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachmentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AttachmentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AttachmentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment", rawUrl) {
        }
    }
}
