// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A collection of transition rules.
    /// </summary>
    public class WorkflowRules : IParsable {
        /// <summary>The workflow transition rule conditions tree.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowCondition? ConditionsTree { get; set; }
#nullable restore
#else
        public WorkflowCondition ConditionsTree { get; set; }
#endif
        /// <summary>The workflow post functions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowTransitionRule>? PostFunctions { get; set; }
#nullable restore
#else
        public List<WorkflowTransitionRule> PostFunctions { get; set; }
#endif
        /// <summary>The workflow validators.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowTransitionRule>? Validators { get; set; }
#nullable restore
#else
        public List<WorkflowTransitionRule> Validators { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowRules CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowRules();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"conditionsTree", n => { ConditionsTree = n.GetObjectValue<WorkflowCondition>(WorkflowCondition.CreateFromDiscriminatorValue); } },
                {"postFunctions", n => { PostFunctions = n.GetCollectionOfObjectValues<WorkflowTransitionRule>(WorkflowTransitionRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"validators", n => { Validators = n.GetCollectionOfObjectValues<WorkflowTransitionRule>(WorkflowTransitionRule.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<WorkflowCondition>("conditionsTree", ConditionsTree);
            writer.WriteCollectionOfObjectValues<WorkflowTransitionRule>("postFunctions", PostFunctions);
            writer.WriteCollectionOfObjectValues<WorkflowTransitionRule>("validators", Validators);
        }
    }
}