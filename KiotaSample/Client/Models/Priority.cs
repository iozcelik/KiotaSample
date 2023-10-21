// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// An issue priority.
    /// </summary>
    public class Priority : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The description of the issue priority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The URL of the icon for the issue priority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IconUrl { get; set; }
#nullable restore
#else
        public string IconUrl { get; set; }
#endif
        /// <summary>The ID of the issue priority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>Whether this priority is the default.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The name of the issue priority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The URL of the issue priority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; set; }
#nullable restore
#else
        public string Self { get; set; }
#endif
        /// <summary>The color used to indicate the issue priority.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StatusColor { get; set; }
#nullable restore
#else
        public string StatusColor { get; set; }
#endif
        /// <summary>
        /// Instantiates a new Priority and sets the default values.
        /// </summary>
        public Priority() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Priority CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Priority();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"iconUrl", n => { IconUrl = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"statusColor", n => { StatusColor = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("iconUrl", IconUrl);
            writer.WriteStringValue("id", Id);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("self", Self);
            writer.WriteStringValue("statusColor", StatusColor);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}