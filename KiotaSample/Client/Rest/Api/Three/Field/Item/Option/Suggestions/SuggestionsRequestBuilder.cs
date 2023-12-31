// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Field.Item.Option.Suggestions.Edit;
using AtlassianClient.Rest.Api.Three.Field.Item.Option.Suggestions.Search;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Field.Item.Option.Suggestions {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\field\{fieldKey}\option\suggestions
    /// </summary>
    public class SuggestionsRequestBuilder : BaseRequestBuilder {
        /// <summary>The edit property</summary>
        public EditRequestBuilder Edit { get =>
            new EditRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The search property</summary>
        public SearchRequestBuilder Search { get =>
            new SearchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new SuggestionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SuggestionsRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{fieldKey}/option/suggestions", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new SuggestionsRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public SuggestionsRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/field/{fieldKey}/option/suggestions", rawUrl) {
        }
    }
}
