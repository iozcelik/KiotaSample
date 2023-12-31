// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The IDs of the screen schemes for the issue type IDs.
    /// </summary>
    public class IssueTypeScreenSchemeMapping : IParsable {
        /// <summary>The ID of the issue type or *default*. Only issue types used in classic projects are accepted. An entry for *default* must be provided and defines the mapping for all issue types without a screen scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueTypeId { get; set; }
#nullable restore
#else
        public string IssueTypeId { get; set; }
#endif
        /// <summary>The ID of the screen scheme. Only screen schemes used in classic projects are accepted.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScreenSchemeId { get; set; }
#nullable restore
#else
        public string ScreenSchemeId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueTypeScreenSchemeMapping CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueTypeScreenSchemeMapping();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"issueTypeId", n => { IssueTypeId = n.GetStringValue(); } },
                {"screenSchemeId", n => { ScreenSchemeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("issueTypeId", IssueTypeId);
            writer.WriteStringValue("screenSchemeId", ScreenSchemeId);
        }
    }
}
