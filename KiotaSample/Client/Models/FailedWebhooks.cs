// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A page of failed webhooks.
    /// </summary>
    public class FailedWebhooks : IParsable {
        /// <summary>The maximum number of items on the page. If the list of values is shorter than this number, then there are no more pages.</summary>
        public int? MaxResults { get; set; }
        /// <summary>The URL to the next page of results. Present only if the request returned at least one result.The next page may be empty at the time of receiving the response, but new failed webhooks may appear in time. You can save the URL to the next page and query for new results periodically (for example, every hour).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Next { get; set; }
#nullable restore
#else
        public string Next { get; set; }
#endif
        /// <summary>The list of webhooks.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FailedWebhook>? Values { get; set; }
#nullable restore
#else
        public List<FailedWebhook> Values { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FailedWebhooks CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FailedWebhooks();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"maxResults", n => { MaxResults = n.GetIntValue(); } },
                {"next", n => { Next = n.GetStringValue(); } },
                {"values", n => { Values = n.GetCollectionOfObjectValues<FailedWebhook>(FailedWebhook.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("maxResults", MaxResults);
            writer.WriteStringValue("next", Next);
            writer.WriteCollectionOfObjectValues<FailedWebhook>("values", Values);
        }
    }
}
