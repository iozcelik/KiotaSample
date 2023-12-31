// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Operations allowed on a workflow
    /// </summary>
    public class WorkflowOperations : IParsable {
        /// <summary>Whether the workflow can be deleted.</summary>
        public bool? CanDelete { get; set; }
        /// <summary>Whether the workflow can be updated.</summary>
        public bool? CanEdit { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowOperations CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowOperations();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"canDelete", n => { CanDelete = n.GetBoolValue(); } },
                {"canEdit", n => { CanEdit = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("canDelete", CanDelete);
            writer.WriteBoolValue("canEdit", CanEdit);
        }
    }
}
