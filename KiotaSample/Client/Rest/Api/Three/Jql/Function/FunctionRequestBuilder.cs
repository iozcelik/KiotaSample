// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Jql.Function.Computation;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Jql.Function {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\jql\function
    /// </summary>
    public class FunctionRequestBuilder : BaseRequestBuilder {
        /// <summary>The computation property</summary>
        public ComputationRequestBuilder Computation { get =>
            new ComputationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new FunctionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FunctionRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql/function", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new FunctionRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public FunctionRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql/function", rawUrl) {
        }
    }
}