// <auto-generated/>
using AtlassianClient.Rest.Api.Three.App.Field.Item.Context.Configuration;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.App.Field.Item.Context {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\app\field\{fieldIdOrKey}\context
    /// </summary>
    public class ContextRequestBuilder : BaseRequestBuilder {
        /// <summary>The configuration property</summary>
        public ConfigurationRequestBuilder Configuration { get =>
            new ConfigurationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ContextRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContextRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/app/field/{fieldIdOrKey}/context", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ContextRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ContextRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/app/field/{fieldIdOrKey}/context", rawUrl) {
        }
    }
}
