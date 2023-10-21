// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Project list with assigned field configuration schema.
    /// </summary>
    public class FieldConfigurationSchemeProjects : IParsable {
        /// <summary>Details of a field configuration scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.FieldConfigurationScheme? FieldConfigurationScheme { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.FieldConfigurationScheme FieldConfigurationScheme { get; set; }
#endif
        /// <summary>The IDs of projects using the field configuration scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ProjectIds { get; set; }
#nullable restore
#else
        public List<string> ProjectIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FieldConfigurationSchemeProjects CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FieldConfigurationSchemeProjects();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"fieldConfigurationScheme", n => { FieldConfigurationScheme = n.GetObjectValue<AtlassianClient.Models.FieldConfigurationScheme>(AtlassianClient.Models.FieldConfigurationScheme.CreateFromDiscriminatorValue); } },
                {"projectIds", n => { ProjectIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AtlassianClient.Models.FieldConfigurationScheme>("fieldConfigurationScheme", FieldConfigurationScheme);
            writer.WriteCollectionOfPrimitiveValues<string>("projectIds", ProjectIds);
        }
    }
}
