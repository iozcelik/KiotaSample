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
namespace AtlassianClient.Rest.Api.Three.Expression.Analyse {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\expression\analyse
    /// </summary>
    public class AnalyseRequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new AnalyseRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AnalyseRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/expression/analyse{?check*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new AnalyseRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public AnalyseRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/expression/analyse{?check*}", rawUrl) {
        }
        /// <summary>
        /// Analyses and validates Jira expressions.As an experimental feature, this operation can also attempt to type-check the expressions.Learn more about Jira expressions in the [documentation](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/).**[Permissions](#permissions) required**: None.
        /// </summary>
        /// <param name="body">Details of Jira expressions for analysis.</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<JiraExpressionsAnalysis?> PostAsync(JiraExpressionForAnalysis body, Action<AnalyseRequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<JiraExpressionsAnalysis> PostAsync(JiraExpressionForAnalysis body, Action<AnalyseRequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            var errorMapping = new Dictionary<string, ParsableFactory<IParsable>> {
                {"400", ErrorCollection.CreateFromDiscriminatorValue},
                {"404", ErrorCollection.CreateFromDiscriminatorValue},
            };
            return await RequestAdapter.SendAsync<JiraExpressionsAnalysis>(requestInfo, JiraExpressionsAnalysis.CreateFromDiscriminatorValue, errorMapping, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Analyses and validates Jira expressions.As an experimental feature, this operation can also attempt to type-check the expressions.Learn more about Jira expressions in the [documentation](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/).**[Permissions](#permissions) required**: None.
        /// </summary>
        /// <param name="body">Details of Jira expressions for analysis.</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(JiraExpressionForAnalysis body, Action<AnalyseRequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(JiraExpressionForAnalysis body, Action<AnalyseRequestBuilderPostRequestConfiguration> requestConfiguration = default) {
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
                var requestConfig = new AnalyseRequestBuilderPostRequestConfiguration();
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
        public AnalyseRequestBuilder WithUrl(string rawUrl) {
            return new AnalyseRequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Analyses and validates Jira expressions.As an experimental feature, this operation can also attempt to type-check the expressions.Learn more about Jira expressions in the [documentation](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/).**[Permissions](#permissions) required**: None.
        /// </summary>
        public class AnalyseRequestBuilderPostQueryParameters {
            /// <summary>The check to perform: *  `syntax` Each expression&apos;s syntax is checked to ensure the expression can be parsed. Also, syntactic limits are validated. For example, the expression&apos;s length. *  `type` EXPERIMENTAL. Each expression is type checked and the final type of the expression inferred. Any type errors that would result in the expression failure at runtime are reported. For example, accessing properties that don&apos;t exist or passing the wrong number of arguments to functions. Also performs the syntax check. *  `complexity` EXPERIMENTAL. Determines the formulae for how many [expensive operations](https://developer.atlassian.com/cloud/jira/platform/jira-expressions/#expensive-operations) each expression may execute.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
            [QueryParameter("check")]
            public string? Check { get; set; }
#nullable restore
#else
            [QueryParameter("check")]
            public string Check { get; set; }
#endif
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class AnalyseRequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public AnalyseRequestBuilderPostQueryParameters QueryParameters { get; set; } = new AnalyseRequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new analyseRequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public AnalyseRequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
