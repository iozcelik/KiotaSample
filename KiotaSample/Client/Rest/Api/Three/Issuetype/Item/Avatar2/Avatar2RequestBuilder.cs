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
namespace AtlassianClient.Rest.Api.Three.Issuetype.Item.Avatar2 {
    /// <summary>
    /// Builds and executes requests for operations under \rest\api\3\issuetype\{id}\avatar2
    /// </summary>
    public class Avatar2RequestBuilder : BaseRequestBuilder {
        /// <summary>
        /// Instantiates a new Avatar2RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Avatar2RequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issuetype/{id}/avatar2{?x*,y*,size*}", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new Avatar2RequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public Avatar2RequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/rest/api/3/issuetype/{id}/avatar2{?x*,y*,size*}", rawUrl) {
        }
        /// <summary>
        /// Loads an avatar for the issue type.Specify the avatar&apos;s local file location in the body of the request. Also, include the following headers: *  `X-Atlassian-Token: no-check` To prevent XSRF protection blocking the request, for more information see [Special Headers](#special-request-headers). *  `Content-Type: image/image type` Valid image types are JPEG, GIF, or PNG.For example:  `curl --request POST \ --user email@example.com:&lt;api_token&gt; \ --header &apos;X-Atlassian-Token: no-check&apos; \ --header &apos;Content-Type: image/&lt; image_type&gt;&apos; \ --data-binary &quot;&lt;@/path/to/file/with/your/avatar&gt;&quot; \ --url &apos;https://your-domain.atlassian.net/rest/api/3/issuetype/{issueTypeId}&apos;This`The avatar is cropped to a square. If no crop parameters are specified, the square originates at the top left of the image. The length of the square&apos;s sides is set to the smaller of the height or width of the image.The cropped image is then used to create avatars of 16x16, 24x24, 32x32, and 48x48 in size.After creating the avatar, use [ Update issue type](#api-rest-api-3-issuetype-id-put) to set it as the issue type&apos;s displayed avatar.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="body">Binary request body</param>
        /// <param name="cancellationToken">Cancellation token to use when cancelling requests</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public async Task<AtlassianClient.Models.Avatar?> PostAsync(Stream body, Action<Avatar2RequestBuilderPostRequestConfiguration>? requestConfiguration = default, CancellationToken cancellationToken = default) {
#nullable restore
#else
        public async Task<AtlassianClient.Models.Avatar> PostAsync(Stream body, Action<Avatar2RequestBuilderPostRequestConfiguration> requestConfiguration = default, CancellationToken cancellationToken = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = ToPostRequestInformation(body, requestConfiguration);
            return await RequestAdapter.SendAsync<AtlassianClient.Models.Avatar>(requestInfo, AtlassianClient.Models.Avatar.CreateFromDiscriminatorValue, default, cancellationToken).ConfigureAwait(false);
        }
        /// <summary>
        /// Loads an avatar for the issue type.Specify the avatar&apos;s local file location in the body of the request. Also, include the following headers: *  `X-Atlassian-Token: no-check` To prevent XSRF protection blocking the request, for more information see [Special Headers](#special-request-headers). *  `Content-Type: image/image type` Valid image types are JPEG, GIF, or PNG.For example:  `curl --request POST \ --user email@example.com:&lt;api_token&gt; \ --header &apos;X-Atlassian-Token: no-check&apos; \ --header &apos;Content-Type: image/&lt; image_type&gt;&apos; \ --data-binary &quot;&lt;@/path/to/file/with/your/avatar&gt;&quot; \ --url &apos;https://your-domain.atlassian.net/rest/api/3/issuetype/{issueTypeId}&apos;This`The avatar is cropped to a square. If no crop parameters are specified, the square originates at the top left of the image. The length of the square&apos;s sides is set to the smaller of the height or width of the image.The cropped image is then used to create avatars of 16x16, 24x24, 32x32, and 48x48 in size.After creating the avatar, use [ Update issue type](#api-rest-api-3-issuetype-id-put) to set it as the issue type&apos;s displayed avatar.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        /// <param name="body">Binary request body</param>
        /// <param name="requestConfiguration">Configuration for the request such as headers, query parameters, and middleware options.</param>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public RequestInformation ToPostRequestInformation(Stream body, Action<Avatar2RequestBuilderPostRequestConfiguration>? requestConfiguration = default) {
#nullable restore
#else
        public RequestInformation ToPostRequestInformation(Stream body, Action<Avatar2RequestBuilderPostRequestConfiguration> requestConfiguration = default) {
#endif
            _ = body ?? throw new ArgumentNullException(nameof(body));
            var requestInfo = new RequestInformation {
                HttpMethod = Method.POST,
                UrlTemplate = UrlTemplate,
                PathParameters = PathParameters,
            };
            requestInfo.Headers.Add("Accept", "application/json");
            requestInfo.SetStreamContent(body);
            if (requestConfiguration != null) {
                var requestConfig = new Avatar2RequestBuilderPostRequestConfiguration();
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
        public Avatar2RequestBuilder WithUrl(string rawUrl) {
            return new Avatar2RequestBuilder(rawUrl, RequestAdapter);
        }
        /// <summary>
        /// Loads an avatar for the issue type.Specify the avatar&apos;s local file location in the body of the request. Also, include the following headers: *  `X-Atlassian-Token: no-check` To prevent XSRF protection blocking the request, for more information see [Special Headers](#special-request-headers). *  `Content-Type: image/image type` Valid image types are JPEG, GIF, or PNG.For example:  `curl --request POST \ --user email@example.com:&lt;api_token&gt; \ --header &apos;X-Atlassian-Token: no-check&apos; \ --header &apos;Content-Type: image/&lt; image_type&gt;&apos; \ --data-binary &quot;&lt;@/path/to/file/with/your/avatar&gt;&quot; \ --url &apos;https://your-domain.atlassian.net/rest/api/3/issuetype/{issueTypeId}&apos;This`The avatar is cropped to a square. If no crop parameters are specified, the square originates at the top left of the image. The length of the square&apos;s sides is set to the smaller of the height or width of the image.The cropped image is then used to create avatars of 16x16, 24x24, 32x32, and 48x48 in size.After creating the avatar, use [ Update issue type](#api-rest-api-3-issuetype-id-put) to set it as the issue type&apos;s displayed avatar.**[Permissions](#permissions) required:** *Administer Jira* [global permission](https://confluence.atlassian.com/x/x4dKLg).
        /// </summary>
        public class Avatar2RequestBuilderPostQueryParameters {
            /// <summary>The length of each side of the crop region.</summary>
            [QueryParameter("size")]
            public int? Size { get; set; }
            /// <summary>The X coordinate of the top-left corner of the crop region.</summary>
            [QueryParameter("x")]
            public int? X { get; set; }
            /// <summary>The Y coordinate of the top-left corner of the crop region.</summary>
            [QueryParameter("y")]
            public int? Y { get; set; }
        }
        /// <summary>
        /// Configuration for the request such as headers, query parameters, and middleware options.
        /// </summary>
        public class Avatar2RequestBuilderPostRequestConfiguration {
            /// <summary>Request headers</summary>
            public RequestHeaders Headers { get; set; }
            /// <summary>Request options</summary>
            public IList<IRequestOption> Options { get; set; }
            /// <summary>Request query parameters</summary>
            public Avatar2RequestBuilderPostQueryParameters QueryParameters { get; set; } = new Avatar2RequestBuilderPostQueryParameters();
            /// <summary>
            /// Instantiates a new avatar2RequestBuilderPostRequestConfiguration and sets the default values.
            /// </summary>
            public Avatar2RequestBuilderPostRequestConfiguration() {
                Options = new List<IRequestOption>();
                Headers = new RequestHeaders();
            }
        }
    }
}
