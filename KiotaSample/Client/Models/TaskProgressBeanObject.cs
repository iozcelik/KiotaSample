// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about a task.
    /// </summary>
    public class TaskProgressBeanObject : IParsable {
        /// <summary>The description of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The execution time of the task, in milliseconds.</summary>
        public long? ElapsedRuntime { get; set; }
        /// <summary>A timestamp recording when the task was finished.</summary>
        public long? Finished { get; set; }
        /// <summary>The ID of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>A timestamp recording when the task progress was last updated.</summary>
        public long? LastUpdate { get; set; }
        /// <summary>Information about the progress of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The progress of the task, as a percentage complete.</summary>
        public long? Progress { get; set; }
        /// <summary>The URL of the task.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; set; }
#nullable restore
#else
        public string Self { get; set; }
#endif
        /// <summary>A timestamp recording when the task was started.</summary>
        public long? Started { get; set; }
        /// <summary>The status of the task.</summary>
        public TaskProgressBeanObject_status? Status { get; set; }
        /// <summary>A timestamp recording when the task was submitted.</summary>
        public long? Submitted { get; set; }
        /// <summary>The ID of the user who submitted the task.</summary>
        public long? SubmittedBy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TaskProgressBeanObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaskProgressBeanObject();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"elapsedRuntime", n => { ElapsedRuntime = n.GetLongValue(); } },
                {"finished", n => { Finished = n.GetLongValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"lastUpdate", n => { LastUpdate = n.GetLongValue(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"progress", n => { Progress = n.GetLongValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"started", n => { Started = n.GetLongValue(); } },
                {"status", n => { Status = n.GetEnumValue<TaskProgressBeanObject_status>(); } },
                {"submitted", n => { Submitted = n.GetLongValue(); } },
                {"submittedBy", n => { SubmittedBy = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteLongValue("elapsedRuntime", ElapsedRuntime);
            writer.WriteLongValue("finished", Finished);
            writer.WriteStringValue("id", Id);
            writer.WriteLongValue("lastUpdate", LastUpdate);
            writer.WriteStringValue("message", Message);
            writer.WriteLongValue("progress", Progress);
            writer.WriteStringValue("self", Self);
            writer.WriteLongValue("started", Started);
            writer.WriteEnumValue<TaskProgressBeanObject_status>("status", Status);
            writer.WriteLongValue("submitted", Submitted);
            writer.WriteLongValue("submittedBy", SubmittedBy);
        }
    }
}