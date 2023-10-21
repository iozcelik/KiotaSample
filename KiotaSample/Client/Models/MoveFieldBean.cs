// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class MoveFieldBean : IParsable {
        /// <summary>The ID of the screen tab field after which to place the moved screen tab field. Required if `position` isn&apos;t provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? After { get; set; }
#nullable restore
#else
        public string After { get; set; }
#endif
        /// <summary>The named position to which the screen tab field should be moved. Required if `after` isn&apos;t provided.</summary>
        public MoveFieldBean_position? Position { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MoveFieldBean CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MoveFieldBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"after", n => { After = n.GetStringValue(); } },
                {"position", n => { Position = n.GetEnumValue<MoveFieldBean_position>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("after", After);
            writer.WriteEnumValue<MoveFieldBean_position>("position", Position);
        }
    }
}
