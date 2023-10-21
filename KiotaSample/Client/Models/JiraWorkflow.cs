// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of a workflow.
    /// </summary>
    public class JiraWorkflow : IParsable {
        /// <summary>The description of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The ID of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Indicates if the workflow can be edited.</summary>
        public bool? IsEditable { get; set; }
        /// <summary>The name of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The scope of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowScope? Scope { get; set; }
#nullable restore
#else
        public WorkflowScope Scope { get; set; }
#endif
        /// <summary>The starting point for the statuses in the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowLayout? StartPointLayout { get; set; }
#nullable restore
#else
        public WorkflowLayout StartPointLayout { get; set; }
#endif
        /// <summary>The statuses referenced in this workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowReferenceStatus>? Statuses { get; set; }
#nullable restore
#else
        public List<WorkflowReferenceStatus> Statuses { get; set; }
#endif
        /// <summary>If there is a current [asynchronous task](#async-operations) operation for this workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskId { get; set; }
#nullable restore
#else
        public string TaskId { get; set; }
#endif
        /// <summary>The transitions of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowTransitions>? Transitions { get; set; }
#nullable restore
#else
        public List<WorkflowTransitions> Transitions { get; set; }
#endif
        /// <summary>Use the optional `workflows.usages` expand to get additional information about the projects and issue types associated with the requested workflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProjectIssueTypes>? Usages { get; set; }
#nullable restore
#else
        public List<ProjectIssueTypes> Usages { get; set; }
#endif
        /// <summary>The version details of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DocumentVersion? Version { get; set; }
#nullable restore
#else
        public DocumentVersion Version { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JiraWorkflow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JiraWorkflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isEditable", n => { IsEditable = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<WorkflowScope>(WorkflowScope.CreateFromDiscriminatorValue); } },
                {"startPointLayout", n => { StartPointLayout = n.GetObjectValue<WorkflowLayout>(WorkflowLayout.CreateFromDiscriminatorValue); } },
                {"statuses", n => { Statuses = n.GetCollectionOfObjectValues<WorkflowReferenceStatus>(WorkflowReferenceStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskId", n => { TaskId = n.GetStringValue(); } },
                {"transitions", n => { Transitions = n.GetCollectionOfObjectValues<WorkflowTransitions>(WorkflowTransitions.CreateFromDiscriminatorValue)?.ToList(); } },
                {"usages", n => { Usages = n.GetCollectionOfObjectValues<ProjectIssueTypes>(ProjectIssueTypes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"version", n => { Version = n.GetObjectValue<DocumentVersion>(DocumentVersion.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isEditable", IsEditable);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<WorkflowScope>("scope", Scope);
            writer.WriteObjectValue<WorkflowLayout>("startPointLayout", StartPointLayout);
            writer.WriteCollectionOfObjectValues<WorkflowReferenceStatus>("statuses", Statuses);
            writer.WriteStringValue("taskId", TaskId);
            writer.WriteCollectionOfObjectValues<WorkflowTransitions>("transitions", Transitions);
            writer.WriteCollectionOfObjectValues<ProjectIssueTypes>("usages", Usages);
            writer.WriteObjectValue<DocumentVersion>("version", Version);
        }
    }
}
