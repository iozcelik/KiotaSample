// <auto-generated/>
using AtlassianClient.Rest.Api.Three.Jql.Autocompletedata;
using AtlassianClient.Rest.Api.Three.Jql.Function;
using AtlassianClient.Rest.Api.Three.Jql.Match;
using AtlassianClient.Rest.Api.Three.Jql.Parse;
using AtlassianClient.Rest.Api.Three.Jql.Pdcleaner;
using AtlassianClient.Rest.Api.Three.Jql.Sanitize;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace AtlassianClient.Rest.Api.Three.Jql {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\jql
    /// </summary>
    public class JqlRequestBuilder : BaseRequestBuilder {
        /// <summary>The autocompletedata property</summary>
        public AutocompletedataRequestBuilder Autocompletedata { get =>
            new AutocompletedataRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The function property</summary>
        public FunctionRequestBuilder Function { get =>
            new FunctionRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The match property</summary>
        public MatchRequestBuilder Match { get =>
            new MatchRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The parse property</summary>
        public ParseRequestBuilder Parse { get =>
            new ParseRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The pdcleaner property</summary>
        public PdcleanerRequestBuilder Pdcleaner { get =>
            new PdcleanerRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The sanitize property</summary>
        public SanitizeRequestBuilder Sanitize { get =>
            new SanitizeRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new JqlRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JqlRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new JqlRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public JqlRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql", rawUrl) {
        }
    }
}
