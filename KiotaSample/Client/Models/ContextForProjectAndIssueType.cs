// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The project and issue type mapping with a matching custom field context.
    /// </summary>
    public class ContextForProjectAndIssueType : IParsable {
        /// <summary>The ID of the custom field context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextId { get; set; }
#nullable restore
#else
        public string ContextId { get; set; }
#endif
        /// <summary>The ID of the issue type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueTypeId { get; set; }
#nullable restore
#else
        public string IssueTypeId { get; set; }
#endif
        /// <summary>The ID of the project.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ContextForProjectAndIssueType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContextForProjectAndIssueType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contextId", n => { ContextId = n.GetStringValue(); } },
                {"issueTypeId", n => { IssueTypeId = n.GetStringValue(); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contextId", ContextId);
            writer.WriteStringValue("issueTypeId", IssueTypeId);
            writer.WriteStringValue("projectId", ProjectId);
        }
    }
}
