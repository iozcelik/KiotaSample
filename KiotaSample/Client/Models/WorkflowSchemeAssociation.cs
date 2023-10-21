// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The explicit association between issue types and a workflow in a workflow scheme.
    /// </summary>
    public class WorkflowSchemeAssociation : IParsable {
        /// <summary>The issue types assigned to the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? IssueTypeIds { get; set; }
#nullable restore
#else
        public List<string> IssueTypeIds { get; set; }
#endif
        /// <summary>The ID of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? WorkflowId { get; set; }
#nullable restore
#else
        public string WorkflowId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowSchemeAssociation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowSchemeAssociation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"issueTypeIds", n => { IssueTypeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"workflowId", n => { WorkflowId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("issueTypeIds", IssueTypeIds);
            writer.WriteStringValue("workflowId", WorkflowId);
        }
    }
}
