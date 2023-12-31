// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class IncludedFields : IParsable {
        /// <summary>The actuallyIncluded property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ActuallyIncluded { get; set; }
#nullable restore
#else
        public List<string> ActuallyIncluded { get; set; }
#endif
        /// <summary>The excluded property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Excluded { get; set; }
#nullable restore
#else
        public List<string> Excluded { get; set; }
#endif
        /// <summary>The included property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Included { get; set; }
#nullable restore
#else
        public List<string> Included { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IncludedFields CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IncludedFields();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actuallyIncluded", n => { ActuallyIncluded = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"excluded", n => { Excluded = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"included", n => { Included = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("actuallyIncluded", ActuallyIncluded);
            writer.WriteCollectionOfPrimitiveValues<string>("excluded", Excluded);
            writer.WriteCollectionOfPrimitiveValues<string>("included", Included);
        }
    }
}
