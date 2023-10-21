// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of a project feature.
    /// </summary>
    public class ProjectFeature : IParsable {
        /// <summary>The key of the feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Feature { get; set; }
#nullable restore
#else
        public string Feature { get; set; }
#endif
        /// <summary>URI for the image representing the feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ImageUri { get; set; }
#nullable restore
#else
        public string ImageUri { get; set; }
#endif
        /// <summary>Localized display description for the feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalisedDescription { get; set; }
#nullable restore
#else
        public string LocalisedDescription { get; set; }
#endif
        /// <summary>Localized display name for the feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LocalisedName { get; set; }
#nullable restore
#else
        public string LocalisedName { get; set; }
#endif
        /// <summary>List of keys of the features required to enable the feature.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Prerequisites { get; set; }
#nullable restore
#else
        public List<string> Prerequisites { get; set; }
#endif
        /// <summary>The ID of the project.</summary>
        public long? ProjectId { get; set; }
        /// <summary>The state of the feature. When updating the state of a feature, only ENABLED and DISABLED are supported. Responses can contain all values</summary>
        public ProjectFeature_state? State { get; set; }
        /// <summary>Whether the state of the feature can be updated.</summary>
        public bool? ToggleLocked { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProjectFeature CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectFeature();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"feature", n => { Feature = n.GetStringValue(); } },
                {"imageUri", n => { ImageUri = n.GetStringValue(); } },
                {"localisedDescription", n => { LocalisedDescription = n.GetStringValue(); } },
                {"localisedName", n => { LocalisedName = n.GetStringValue(); } },
                {"prerequisites", n => { Prerequisites = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"projectId", n => { ProjectId = n.GetLongValue(); } },
                {"state", n => { State = n.GetEnumValue<ProjectFeature_state>(); } },
                {"toggleLocked", n => { ToggleLocked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("feature", Feature);
            writer.WriteStringValue("imageUri", ImageUri);
            writer.WriteStringValue("localisedDescription", LocalisedDescription);
            writer.WriteStringValue("localisedName", LocalisedName);
            writer.WriteCollectionOfPrimitiveValues<string>("prerequisites", Prerequisites);
            writer.WriteLongValue("projectId", ProjectId);
            writer.WriteEnumValue<ProjectFeature_state>("state", State);
            writer.WriteBoolValue("toggleLocked", ToggleLocked);
        }
    }
}