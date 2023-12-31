// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Dashboard.Bulk.Edit;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Dashboard.Bulk {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\dashboard\bulk
    /// </summary>
    public class BulkRequestBuilder : BaseRequestBuilder {
        /// <summary>The edit property</summary>
        public EditRequestBuilder Edit { get =>
            new EditRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new BulkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/bulk", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new BulkRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public BulkRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/dashboard/bulk", rawUrl) {
        }
    }
}
