// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Lists of JQL reference data.
    /// </summary>
    public class JQLReferenceData : IParsable {
        /// <summary>List of JQL query reserved words.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? JqlReservedWords { get; set; }
#nullable restore
#else
        public List<string> JqlReservedWords { get; set; }
#endif
        /// <summary>List of fields usable in JQL queries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FieldReferenceData>? VisibleFieldNames { get; set; }
#nullable restore
#else
        public List<FieldReferenceData> VisibleFieldNames { get; set; }
#endif
        /// <summary>List of functions usable in JQL queries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<FunctionReferenceData>? VisibleFunctionNames { get; set; }
#nullable restore
#else
        public List<FunctionReferenceData> VisibleFunctionNames { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JQLReferenceData CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JQLReferenceData();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"jqlReservedWords", n => { JqlReservedWords = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"visibleFieldNames", n => { VisibleFieldNames = n.GetCollectionOfObjectValues<FieldReferenceData>(FieldReferenceData.CreateFromDiscriminatorValue)?.ToList(); } },
                {"visibleFunctionNames", n => { VisibleFunctionNames = n.GetCollectionOfObjectValues<FunctionReferenceData>(FunctionReferenceData.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("jqlReservedWords", JqlReservedWords);
            writer.WriteCollectionOfObjectValues<FieldReferenceData>("visibleFieldNames", VisibleFieldNames);
            writer.WriteCollectionOfObjectValues<FunctionReferenceData>("visibleFunctionNames", VisibleFunctionNames);
        }
    }
}
