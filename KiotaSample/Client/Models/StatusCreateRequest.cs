// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of the statuses being created and their scope.
    /// </summary>
    public class StatusCreateRequest : IParsable {
        /// <summary>The scope of the status.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public StatusScope? Scope { get; set; }
#nullable restore
#else
        public StatusScope Scope { get; set; }
#endif
        /// <summary>Details of the statuses being created.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StatusCreate>? Statuses { get; set; }
#nullable restore
#else
        public List<StatusCreate> Statuses { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static StatusCreateRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StatusCreateRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"scope", n => { Scope = n.GetObjectValue<StatusScope>(StatusScope.CreateFromDiscriminatorValue); } },
                {"statuses", n => { Statuses = n.GetCollectionOfObjectValues<StatusCreate>(StatusCreate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<StatusScope>("scope", Scope);
            writer.WriteCollectionOfObjectValues<StatusCreate>("statuses", Statuses);
        }
    }
}