// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about a workflow.
    /// </summary>
    public class Workflow : IParsable {
        /// <summary>The creation date of the workflow.</summary>
        public DateTimeOffset? Created { get; set; }
        /// <summary>The description of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Whether the workflow has a draft version.</summary>
        public bool? HasDraftWorkflow { get; set; }
        /// <summary>Properties that identify a published workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PublishedWorkflowId? Id { get; set; }
#nullable restore
#else
        public PublishedWorkflowId Id { get; set; }
#endif
        /// <summary>Whether this is the default workflow.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>Operations allowed on a workflow</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowOperations? Operations { get; set; }
#nullable restore
#else
        public WorkflowOperations Operations { get; set; }
#endif
        /// <summary>The projects the workflow is assigned to, through workflow schemes.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProjectDetails>? Projects { get; set; }
#nullable restore
#else
        public List<ProjectDetails> Projects { get; set; }
#endif
        /// <summary>The workflow schemes the workflow is assigned to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowSchemeIdName>? Schemes { get; set; }
#nullable restore
#else
        public List<WorkflowSchemeIdName> Schemes { get; set; }
#endif
        /// <summary>The statuses of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowStatus>? Statuses { get; set; }
#nullable restore
#else
        public List<WorkflowStatus> Statuses { get; set; }
#endif
        /// <summary>The transitions of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Transition>? Transitions { get; set; }
#nullable restore
#else
        public List<Transition> Transitions { get; set; }
#endif
        /// <summary>The last edited date of the workflow.</summary>
        public DateTimeOffset? Updated { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Workflow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Workflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"created", n => { Created = n.GetDateTimeOffsetValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"hasDraftWorkflow", n => { HasDraftWorkflow = n.GetBoolValue(); } },
                {"id", n => { Id = n.GetObjectValue<PublishedWorkflowId>(PublishedWorkflowId.CreateFromDiscriminatorValue); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"operations", n => { Operations = n.GetObjectValue<WorkflowOperations>(WorkflowOperations.CreateFromDiscriminatorValue); } },
                {"projects", n => { Projects = n.GetCollectionOfObjectValues<ProjectDetails>(ProjectDetails.CreateFromDiscriminatorValue)?.ToList(); } },
                {"schemes", n => { Schemes = n.GetCollectionOfObjectValues<WorkflowSchemeIdName>(WorkflowSchemeIdName.CreateFromDiscriminatorValue)?.ToList(); } },
                {"statuses", n => { Statuses = n.GetCollectionOfObjectValues<WorkflowStatus>(WorkflowStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"transitions", n => { Transitions = n.GetCollectionOfObjectValues<Transition>(Transition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("created", Created);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("hasDraftWorkflow", HasDraftWorkflow);
            writer.WriteObjectValue<PublishedWorkflowId>("id", Id);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteObjectValue<WorkflowOperations>("operations", Operations);
            writer.WriteCollectionOfObjectValues<ProjectDetails>("projects", Projects);
            writer.WriteCollectionOfObjectValues<WorkflowSchemeIdName>("schemes", Schemes);
            writer.WriteCollectionOfObjectValues<WorkflowStatus>("statuses", Statuses);
            writer.WriteCollectionOfObjectValues<Transition>("transitions", Transitions);
            writer.WriteDateTimeOffsetValue("updated", Updated);
        }
    }
}
