// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of a gadget.
    /// </summary>
    public class DashboardGadget : IParsable {
        /// <summary>The color of the gadget. Should be one of `blue`, `red`, `yellow`, `green`, `cyan`, `purple`, `gray`, or `white`.</summary>
        public DashboardGadget_color? Color { get; private set; }
        /// <summary>The ID of the gadget instance.</summary>
        public long? Id { get; private set; }
        /// <summary>The module key of the gadget type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModuleKey { get; private set; }
#nullable restore
#else
        public string ModuleKey { get; private set; }
#endif
        /// <summary>The position of the gadget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DashboardGadgetPosition? Position { get; private set; }
#nullable restore
#else
        public DashboardGadgetPosition Position { get; private set; }
#endif
        /// <summary>The title of the gadget.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; private set; }
#nullable restore
#else
        public string Title { get; private set; }
#endif
        /// <summary>The URI of the gadget type.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Uri { get; private set; }
#nullable restore
#else
        public string Uri { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DashboardGadget CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DashboardGadget();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"color", n => { Color = n.GetEnumValue<DashboardGadget_color>(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"moduleKey", n => { ModuleKey = n.GetStringValue(); } },
                {"position", n => { Position = n.GetObjectValue<DashboardGadgetPosition>(DashboardGadgetPosition.CreateFromDiscriminatorValue); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"uri", n => { Uri = n.GetStringValue(); } },
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
