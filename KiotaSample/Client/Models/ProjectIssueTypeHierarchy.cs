// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The hierarchy of issue types within a project.
    /// </summary>
    public class ProjectIssueTypeHierarchy : IParsable {
        /// <summary>Details of an issue type hierarchy level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<ProjectIssueTypesHierarchyLevel>? Hierarchy { get; private set; }
#nullable restore
#else
        public List<ProjectIssueTypesHierarchyLevel> Hierarchy { get; private set; }
#endif
        /// <summary>The ID of the project.</summary>
        public long? ProjectId { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProjectIssueTypeHierarchy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectIssueTypeHierarchy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hierarchy", n => { Hierarchy = n.GetCollectionOfObjectValues<ProjectIssueTypesHierarchyLevel>(ProjectIssueTypesHierarchyLevel.CreateFromDiscriminatorValue)?.ToList(); } },
                {"projectId", n => { ProjectId = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}