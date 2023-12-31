// <auto-generated/>
using AtlassianClient.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System;
namespace AtlassianClient.Rest.Api.Three.Jql.Parse {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\jql\parse
    /// </summary>
    public class ParseRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new ParseRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParseRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql/parse{?validation*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ParseRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ParseRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/jql/parse{?validation*}", rawUrl) {
        }
        /// <summary>
        /// Parses and validates JQL queries.Validation is performed in context of the current user.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <param name="body">A list of JQL queries to parse.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<ParsedJqlQueries?> PostAsync(JqlQueriesToParse body, Action<ParseRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<ParsedJqlQueries> PostAsync(JqlQueriesToParse body, Action<ParseRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<ParsedJqlQueries>(requestInfo, ParsedJqlQueries.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Parses and validates JQL queries.Validation is performed in context of the current user.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        /// <param name="body">A list of JQL queries to parse.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(JqlQueriesToParse body, Action<ParseRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(JqlQueriesToParse body, Action<ParseRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetContentFromParsable(RequestAdapter, "application/json", body);
            if (requestConfiguration != null) {
                var requestConfig = new ParseRequestBuilderPostRequestConfiguration();
                requestConfiguration.Invoke(requestConfig);
                requestInfo.AddQueryParameters(requestConfig.QueryParameters);
                requestInfo.AddRequestOptions(requestConfig.Options);
                requestInfo.AddHeaders(requestConfig.Headers);
            }
            return requestInfo;
        }
        /// <summary>
        /// Returns a request builder with the provided arbitrary URL. Using this method means any other path or query parameters are ignored.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        public ParseRequestBuilder WithUrl(string rawUrl) {
            return new ParseRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Parses and validates JQL queries.Validation is performed in context of the current user.This operation can be accessed anonymously.**[Permissions](#permissions) required:** None.
        /// </summary>
        public class ParseRequestBuilderPostQueryParameters {
            /// <summary>How to validate the JQL query and treat the validation results. Validation options include: *  `strict` Returns all errors. If validation fails, the query structure is not returned. *  `warn` Returns all errors. If validation fails but the JQL query is correctly formed, the query structure is returned. *  `none` No validation is performed. If JQL query is correctly formed, the query structure is returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("validation")]
            public string? Validation { get; set; }
#nullable restore
#else
            [QueryParameter("validation")]
            public string Validation { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class ParseRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public ParseRequestBuilderPostQueryParameters QueryParameters { get; set; } = new ParseRequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new parseRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public ParseRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
