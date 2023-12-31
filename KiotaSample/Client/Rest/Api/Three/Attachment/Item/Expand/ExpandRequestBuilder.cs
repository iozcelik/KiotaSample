// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Attachment.Item.Expand.Human;
using AtlassianClient.Rest.Api.Three.Attachment.Item.Expand.Raw;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Attachment.Item.Expand {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\attachment\{id}\expand
    /// </summary>
    public class ExpandRequestBuilder : BaseRequestBuilder {
        /// <summary>The human property</summary>
        public HumanRequestBuilder Human { get =>
            new HumanRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The raw property</summary>
        public RawRequestBuilder Raw { get =>
            new RawRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ExpandRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExpandRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment/{id}/expand", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ExpandRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ExpandRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/attachment/{id}/expand", rawUrl) {
        }
    }
}
