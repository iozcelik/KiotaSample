// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// An icon. If no icon is defined: *  for a status icon, no status icon displays in Jira. *  for the remote object icon, the default link icon displays in Jira.
    /// </summary>
    public class Icon : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The URL of the tooltip, used only for a status icon. If not set, the status icon in Jira is not clickable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Link { get; set; }
#nullable restore
#else
        public string Link { get; set; }
#endif
        /// <summary>The title of the icon. This is used as follows: *  For a status icon it is used as a tooltip on the icon. If not set, the status icon doesn&apos;t display a tooltip in Jira. *  For the remote object icon it is used in conjunction with the application name to display a tooltip for the link&apos;s icon. The tooltip takes the format &quot;\[application name\] icon title&quot;. Blank itemsare excluded from the tooltip title. If both items are blank, the icon tooltop displays as &quot;Web Link&quot;.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; set; }
#nullable restore
#else
        public string Title { get; set; }
#endif
        /// <summary>The URL of an icon that displays at 16x16 pixel in Jira.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url16x16 { get; set; }
#nullable restore
#else
        public string Url16x16 { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Icon and sets the default values.
        /// </summary>
        public Icon() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Icon CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Icon();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"link", n => { Link = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"url16x16", n => { Url16x16 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("link", Link);
            writer.WriteStringValue("title", Title);
            writer.WriteStringValue("url16x16", Url16x16);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
