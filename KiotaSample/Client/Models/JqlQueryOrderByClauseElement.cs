// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// An element of the order-by JQL clause.
    /// </summary>
    public class JqlQueryOrderByClauseElement : IParsable {
        /// <summary>The direction in which to order the results.</summary>
        public JqlQueryOrderByClauseElement_direction? Direction { get; set; }
        /// <summary>A field used in a JQL query. See [Advanced searching - fields reference](https://confluence.atlassian.com/x/dAiiLQ) for more information about fields in JQL queries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JqlQueryField? Field { get; set; }
#nullable restore
#else
        public JqlQueryField Field { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JqlQueryOrderByClauseElement CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JqlQueryOrderByClauseElement();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"direction", n => { Direction = n.GetEnumValue<JqlQueryOrderByClauseElement_direction>(); } },
                {"field", n => { Field = n.GetObjectValue<JqlQueryField>(JqlQueryField.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<JqlQueryOrderByClauseElement_direction>("direction", Direction);
            writer.WriteObjectValue<JqlQueryField>("field", Field);
        }
    }
}
