// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of any errors encountered while updating workflow transition rules for a workflow.
    /// </summary>
    public class WorkflowTransitionRulesUpdateErrorDetails : IParsable {
        /// <summary>A list of transition rule update errors, indexed by the transition rule ID. Any transition rule that appears here wasn&apos;t updated.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowTransitionRulesUpdateErrorDetails_ruleUpdateErrors? RuleUpdateErrors { get; set; }
#nullable restore
#else
        public WorkflowTransitionRulesUpdateErrorDetails_ruleUpdateErrors RuleUpdateErrors { get; set; }
#endif
        /// <summary>The list of errors that specify why the workflow update failed. The workflow was not updated if the list contains any entries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? UpdateErrors { get; set; }
#nullable restore
#else
        public List<string> UpdateErrors { get; set; }
#endif
        /// <summary>Properties that identify a workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.WorkflowId? WorkflowId { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.WorkflowId WorkflowId { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowTransitionRulesUpdateErrorDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowTransitionRulesUpdateErrorDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"ruleUpdateErrors", n => { RuleUpdateErrors = n.GetObjectValue<WorkflowTransitionRulesUpdateErrorDetails_ruleUpdateErrors>(WorkflowTransitionRulesUpdateErrorDetails_ruleUpdateErrors.CreateFromDiscriminatorValue); } },
                {"updateErrors", n => { UpdateErrors = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"workflowId", n => { WorkflowId = n.GetObjectValue<AtlassianClient.Models.WorkflowId>(AtlassianClient.Models.WorkflowId.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WorkflowTransitionRulesUpdateErrorDetails_ruleUpdateErrors>("ruleUpdateErrors", RuleUpdateErrors);
            writer.WriteCollectionOfPrimitiveValues<string>("updateErrors", UpdateErrors);
            writer.WriteObjectValue<AtlassianClient.Models.WorkflowId>("workflowId", WorkflowId);
        }
    }
}
