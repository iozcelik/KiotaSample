// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Groups.Picker;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Groups {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\groups
    /// </summary>
    public class GroupsRequestBuilder : BaseRequestBuilder {
        /// <summary>The picker property</summary>
        public PickerRequestBuilder Picker { get =>
            new PickerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new GroupsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/groups", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new GroupsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public GroupsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/groups", rawUrl) {
        }
    }
}
