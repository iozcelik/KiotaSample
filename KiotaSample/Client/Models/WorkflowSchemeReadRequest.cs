// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The workflow scheme read request body.
    /// </summary>
    public class WorkflowSchemeReadRequest : IParsable {
        /// <summary>The list of project IDs to query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProjectIds { get; set; }
#nullable restore
#else
        public List<string> ProjectIds { get; set; }
#endif
        /// <summary>The list of workflow scheme IDs to query.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? WorkflowSchemeIds { get; set; }
#nullable restore
#else
        public List<string> WorkflowSchemeIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowSchemeReadRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowSchemeReadRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"projectIds", n => { ProjectIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"workflowSchemeIds", n => { WorkflowSchemeIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("projectIds", ProjectIds);
            writer.WriteCollectionOfPrimitiveValues<string>("workflowSchemeIds", WorkflowSchemeIds);
        }
    }
}
