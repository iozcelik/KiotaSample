// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The update workflows payload.
    /// </summary>
    public class WorkflowUpdateRequest : IParsable {
        /// <summary>The statuses to associate with the workflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowStatusUpdate>? Statuses { get; set; }
#nullable restore
#else
        public List<WorkflowStatusUpdate> Statuses { get; set; }
#endif
        /// <summary>The details of the workflows to update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowUpdate>? Workflows { get; set; }
#nullable restore
#else
        public List<WorkflowUpdate> Workflows { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowUpdateRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowUpdateRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"statuses", n => { Statuses = n.GetCollectionOfObjectValues<WorkflowStatusUpdate>(WorkflowStatusUpdate.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workflows", n => { Workflows = n.GetCollectionOfObjectValues<WorkflowUpdate>(WorkflowUpdate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WorkflowStatusUpdate>("statuses", Statuses);
            writer.WriteCollectionOfObjectValues<WorkflowUpdate>("workflows", Workflows);
        }
    }
}
