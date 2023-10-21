// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of an issue type scheme and its associated issue types.
    /// </summary>
    public class IssueTypeSchemeDetails : IParsable {
        /// <summary>The ID of the default issue type of the issue type scheme. This ID must be included in `issueTypeIds`.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultIssueTypeId { get; set; }
#nullable restore
#else
        public string DefaultIssueTypeId { get; set; }
#endif
        /// <summary>The description of the issue type scheme. The maximum length is 4000 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The list of issue types IDs of the issue type scheme. At least one standard issue type ID is required.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IssueTypeIds { get; set; }
#nullable restore
#else
        public List<string> IssueTypeIds { get; set; }
#endif
        /// <summary>The name of the issue type scheme. The name must be unique. The maximum length is 255 characters.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueTypeSchemeDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueTypeSchemeDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"defaultIssueTypeId", n => { DefaultIssueTypeId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"issueTypeIds", n => { IssueTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("defaultIssueTypeId", DefaultIssueTypeId);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("issueTypeIds", IssueTypeIds);
            writer.WriteStringValue("name", Name);
        }
    }
}
