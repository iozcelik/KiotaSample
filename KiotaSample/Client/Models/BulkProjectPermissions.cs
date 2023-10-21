// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of project permissions and associated issues and projects to look up.
    /// </summary>
    public class BulkProjectPermissions : IParsable {
        /// <summary>List of issue IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<long?>? Issues { get; set; }
#nullable restore
#else
        public List<long?> Issues { get; set; }
#endif
        /// <summary>List of project permissions.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Permissions { get; set; }
#nullable restore
#else
        public List<string> Permissions { get; set; }
#endif
        /// <summary>List of project IDs.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<long?>? Projects { get; set; }
#nullable restore
#else
        public List<long?> Projects { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static BulkProjectPermissions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BulkProjectPermissions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"issues", n => { Issues = n.GetCollectionOfPrimitiveValues<long?>()?.ToList(); } },
                {"permissions", n => { Permissions = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"projects", n => { Projects = n.GetCollectionOfPrimitiveValues<long?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<long?>("issues", Issues);
            writer.WriteCollectionOfPrimitiveValues<string>("permissions", Permissions);
            writer.WriteCollectionOfPrimitiveValues<long?>("projects", Projects);
        }
    }
}