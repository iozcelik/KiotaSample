// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Count of a version&apos;s unresolved issues.
    /// </summary>
    public class VersionUnresolvedIssuesCount : IParsable {
        /// <summary>Count of issues.</summary>
        public long? IssuesCount { get; private set; }
        /// <summary>Count of unresolved issues.</summary>
        public long? IssuesUnresolvedCount { get; private set; }
        /// <summary>The URL of these count details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VersionUnresolvedIssuesCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VersionUnresolvedIssuesCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"issuesCount", n => { IssuesCount = n.GetLongValue(); } },
                {"issuesUnresolvedCount", n => { IssuesUnresolvedCount = n.GetLongValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}
