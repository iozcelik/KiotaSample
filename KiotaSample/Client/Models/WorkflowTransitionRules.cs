// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A workflow with transition rules.
    /// </summary>
    public class WorkflowTransitionRules : IParsable {
        /// <summary>The list of conditions within the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppWorkflowTransitionRule>? Conditions { get; set; }
#nullable restore
#else
        public List<AppWorkflowTransitionRule> Conditions { get; set; }
#endif
        /// <summary>The list of post functions within the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppWorkflowTransitionRule>? PostFunctions { get; set; }
#nullable restore
#else
        public List<AppWorkflowTransitionRule> PostFunctions { get; set; }
#endif
        /// <summary>The list of validators within the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AppWorkflowTransitionRule>? Validators { get; set; }
#nullable restore
#else
        public List<AppWorkflowTransitionRule> Validators { get; set; }
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
        public static WorkflowTransitionRules CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowTransitionRules();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conditions", n => { Conditions = n.GetCollectionOfObjectValues<AppWorkflowTransitionRule>(AppWorkflowTransitionRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"postFunctions", n => { PostFunctions = n.GetCollectionOfObjectValues<AppWorkflowTransitionRule>(AppWorkflowTransitionRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"validators", n => { Validators = n.GetCollectionOfObjectValues<AppWorkflowTransitionRule>(AppWorkflowTransitionRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workflowId", n => { WorkflowId = n.GetObjectValue<AtlassianClient.Models.WorkflowId>(AtlassianClient.Models.WorkflowId.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AppWorkflowTransitionRule>("conditions", Conditions);
            writer.WriteCollectionOfObjectValues<AppWorkflowTransitionRule>("postFunctions", PostFunctions);
            writer.WriteCollectionOfObjectValues<AppWorkflowTransitionRule>("validators", Validators);
            writer.WriteObjectValue<AtlassianClient.Models.WorkflowId>("workflowId", WorkflowId);
        }
    }
}