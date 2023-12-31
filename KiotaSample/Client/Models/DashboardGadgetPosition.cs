// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of a gadget position.
    /// </summary>
    public class DashboardGadgetPosition : IParsable {
        /// <summary>The TheColumnPositionOfTheGadget property</summary>
        public int? TheColumnPositionOfTheGadget { get; set; }
        /// <summary>The TheRowPositionOfTheGadget property</summary>
        public int? TheRowPositionOfTheGadget { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DashboardGadgetPosition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DashboardGadgetPosition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"The column position of the gadget.", n => { TheColumnPositionOfTheGadget = n.GetIntValue(); } },
                {"The row position of the gadget.", n => { TheRowPositionOfTheGadget = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("The column position of the gadget.", TheColumnPositionOfTheGadget);
            writer.WriteIntValue("The row position of the gadget.", TheRowPositionOfTheGadget);
        }
    }
}
