// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class WorkflowUpdateResponse : IParsable {
        /// <summary>List of updated statuses.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JiraWorkflowStatus>? Statuses { get; set; }
#nullable restore
#else
        public List<JiraWorkflowStatus> Statuses { get; set; }
#endif
        /// <summary>If there is a [asynchronous task](#async-operations) operation, as a result of this update.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TaskId { get; set; }
#nullable restore
#else
        public string TaskId { get; set; }
#endif
        /// <summary>List of updated workflows.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JiraWorkflow>? Workflows { get; set; }
#nullable restore
#else
        public List<JiraWorkflow> Workflows { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowUpdateResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowUpdateResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"statuses", n => { Statuses = n.GetCollectionOfObjectValues<JiraWorkflowStatus>(JiraWorkflowStatus.CreateFromDiscriminatorValue)?.ToList(); } },
                {"taskId", n => { TaskId = n.GetStringValue(); } },
                {"workflows", n => { Workflows = n.GetCollectionOfObjectValues<JiraWorkflow>(JiraWorkflow.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<JiraWorkflowStatus>("statuses", Statuses);
            writer.WriteStringValue("taskId", TaskId);
            writer.WriteCollectionOfObjectValues<JiraWorkflow>("workflows", Workflows);
        }
    }
}
