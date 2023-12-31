// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Auditing.Record;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Auditing {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\auditing
    /// </summary>
    public class AuditingRequestBuilder : BaseRequestBuilder {
        /// <summary>The record property</summary>
        public RecordRequestBuilder Record { get =>
            new RecordRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new AuditingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditingRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/auditing", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AuditingRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AuditingRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/auditing", rawUrl) {
        }
    }
}
