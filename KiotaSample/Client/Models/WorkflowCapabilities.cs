// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class WorkflowCapabilities : IParsable {
        /// <summary>The Connect provided ecosystem rules available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AvailableWorkflowConnectRule>? ConnectRules { get; set; }
#nullable restore
#else
        public List<AvailableWorkflowConnectRule> ConnectRules { get; set; }
#endif
        /// <summary>The scope of the workflow capabilities. `GLOBAL` for company-managed projects and `PROJECT` for team-managed projects.</summary>
        public WorkflowCapabilities_editorScope? EditorScope { get; set; }
        /// <summary>The Forge provided ecosystem rules available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AvailableWorkflowForgeRule>? ForgeRules { get; set; }
#nullable restore
#else
        public List<AvailableWorkflowForgeRule> ForgeRules { get; set; }
#endif
        /// <summary>The types of projects that this capability set is available for.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowCapabilities_projectTypes?>? ProjectTypes { get; set; }
#nullable restore
#else
        public List<WorkflowCapabilities_projectTypes?> ProjectTypes { get; set; }
#endif
        /// <summary>The Atlassian provided system rules available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AvailableWorkflowSystemRule>? SystemRules { get; set; }
#nullable restore
#else
        public List<AvailableWorkflowSystemRule> SystemRules { get; set; }
#endif
        /// <summary>The trigger rules available.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AvailableWorkflowTriggers>? TriggerRules { get; set; }
#nullable restore
#else
        public List<AvailableWorkflowTriggers> TriggerRules { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowCapabilities CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowCapabilities();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connectRules", n => { ConnectRules = n.GetCollectionOfObjectValues<AvailableWorkflowConnectRule>(AvailableWorkflowConnectRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"editorScope", n => { EditorScope = n.GetEnumValue<WorkflowCapabilities_editorScope>(); } },
                {"forgeRules", n => { ForgeRules = n.GetCollectionOfObjectValues<AvailableWorkflowForgeRule>(AvailableWorkflowForgeRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"projectTypes", n => { ProjectTypes = n.GetCollectionOfEnumValues<WorkflowCapabilities_projectTypes>()?.ToList(); } },
                {"systemRules", n => { SystemRules = n.GetCollectionOfObjectValues<AvailableWorkflowSystemRule>(AvailableWorkflowSystemRule.CreateFromDiscriminatorValue)?.ToList(); } },
                {"triggerRules", n => { TriggerRules = n.GetCollectionOfObjectValues<AvailableWorkflowTriggers>(AvailableWorkflowTriggers.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AvailableWorkflowConnectRule>("connectRules", ConnectRules);
            writer.WriteEnumValue<WorkflowCapabilities_editorScope>("editorScope", EditorScope);
            writer.WriteCollectionOfObjectValues<AvailableWorkflowForgeRule>("forgeRules", ForgeRules);
            writer.WriteCollectionOfEnumValues<WorkflowCapabilities_projectTypes>("projectTypes", ProjectTypes);
            writer.WriteCollectionOfObjectValues<AvailableWorkflowSystemRule>("systemRules", SystemRules);
            writer.WriteCollectionOfObjectValues<AvailableWorkflowTriggers>("triggerRules", TriggerRules);
        }
    }
}
