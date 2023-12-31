// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Comment.Item;
using AtlassianClient.Rest.Api.Three.Comment.List;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Comment {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\comment
    /// </summary>
    public class CommentRequestBuilder : BaseRequestBuilder {
        /// <summary>The list property</summary>
        public ListRequestBuilder List { get =>
            new ListRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>Gets an item from the AtlassianClient.rest.api.Three.comment.item collection</summary>
        /// <param name="position">Unique identifier of the item</param>
        public WithCommentIdItemRequestBuilder this[string position] { get {
            var urlTplParams = new Dictionary<string, object>(PathParameters);
            urlTplParams.Add("commentId", position);
            return new WithCommentIdItemRequestBuilder(urlTplParams, RequestAdapter);
        } }
        /// <summary>
        /// Instantiates a new CommentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommentRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/comment", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new CommentRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public CommentRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/comment", rawUrl) {
        }
    }
}
