// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Issues.Archive.Export;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Issues.Archive {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issues\archive
    /// </summary>
    public class ArchiveRequestBuilder : BaseRequestBuilder {
        /// <summary>The export property</summary>
        public ExportRequestBuilder Export { get =>
            new ExportRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ArchiveRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArchiveRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issues/archive", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ArchiveRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ArchiveRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issues/archive", rawUrl) {
        }
    }
}
