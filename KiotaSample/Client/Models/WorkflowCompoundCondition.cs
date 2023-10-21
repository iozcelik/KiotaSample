// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A compound workflow transition rule condition. This object returns `nodeType` as `compound`.
    /// </summary>
    public class WorkflowCompoundCondition : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of workflow conditions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowCondition>? Conditions { get; set; }
#nullable restore
#else
        public List<WorkflowCondition> Conditions { get; set; }
#endif
        /// <summary>The nodeType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? NodeType { get; set; }
#nullable restore
#else
        public string NodeType { get; set; }
#endif
        /// <summary>The compound condition operator.</summary>
        public WorkflowCompoundCondition_operator? Operator { get; set; }
        /// <summary>
        /// Instantiates a new WorkflowCompoundCondition and sets the default values.
        /// </summary>
        public WorkflowCompoundCondition() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowCompoundCondition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowCompoundCondition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conditions", n => { Conditions = n.GetCollectionOfObjectValues<WorkflowCondition>(WorkflowCondition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"nodeType", n => { NodeType = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetEnumValue<WorkflowCompoundCondition_operator>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WorkflowCondition>("conditions", Conditions);
            writer.WriteStringValue("nodeType", NodeType);
            writer.WriteEnumValue<WorkflowCompoundCondition_operator>("operator", Operator);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
