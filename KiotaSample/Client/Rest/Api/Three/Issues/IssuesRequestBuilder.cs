// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Issues.Archive;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Issues {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issues
    /// </summary>
    public class IssuesRequestBuilder : BaseRequestBuilder {
        /// <summary>The archive property</summary>
        public ArchiveRequestBuilder Archive { get =>
            new ArchiveRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new IssuesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issues", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new IssuesRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public IssuesRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issues", rawUrl) {
        }
    }
}