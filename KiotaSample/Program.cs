using AtlassianClient;
using AtlassianClient.Models;
using AtlassianClient.Rest.Api.Three;
using AtlassianClient.Rest.Api.Three.Search;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

var apiKey = "Basic eW91cmVtYWlsYWRkcmVzc0Bkb21haW4uY29tOllvdXJBdGxhc3NpYW5BcGlLZXk=";

var authProvider = new ApiKeyAuthenticationProvider(apiKey, "Authorization", ApiKeyAuthenticationProvider.KeyLocation.Header);
// Create request adapter using the HttpClient-based implementation
var adapter = new HttpClientRequestAdapter(authProvider) {
    BaseUrl = "https://yourdomain.atlassian.net"
};
// Create the API client
var client = new ApiClient(adapter);

var v3Client = client.Rest.Api.Three;

try {
    await SearhJqlExample(v3Client);

    await CreateIssueLinkExample(v3Client);

}
catch (Exception ex) {
    Console.WriteLine($"ERROR: {ex.Message}");
    Console.WriteLine(ex.StackTrace);
}

async Task SearhJqlExample(ThreeRequestBuilder v3Client) {
    var request = new SearchRequestBuilder.SearchRequestBuilderGetQueryParameters() {
        Jql = "project=TEST",
        Fields = new[] { "key", "issuelinks" },
        Expand = "changelog",
        MaxResults = 200,
        StartAt = 0,
    };

    var issues = await v3Client.Search.GetAsync(g => g.QueryParameters = request);
}

async Task CreateIssueLinkExample(ThreeRequestBuilder v3Client) {
    var newLink = new LinkIssueRequestJsonBean() {
        InwardIssue = new LinkedIssue() {
            Key = "KEY-1"
        },
        OutwardIssue = new LinkedIssue() {
            Key = "HELP-1"
        },
        Type = new IssueLinkType() {
            Id = "10206"
        }
    };

    await client.Rest.Api.Three.IssueLink.PostAsync(newLink);
}

