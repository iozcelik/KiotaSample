// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Defaults for a Forge user custom field.
    /// </summary>
    public class CustomFieldContextDefaultValueForgeUserField : IAdditionalDataHolder, IParsable {
        /// <summary>The ID of the default user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AccountId { get; set; }
#nullable restore
#else
        public string AccountId { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The ID of the context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ContextId { get; set; }
#nullable restore
#else
        public string ContextId { get; set; }
#endif
        /// <summary>The type property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>Filter for a User Picker (single) custom field.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.UserFilter? UserFilter { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.UserFilter UserFilter { get; set; }
#endif
        /// <summary>
        /// Instantiates a new CustomFieldContextDefaultValueForgeUserField and sets the default values.
        /// </summary>
        public CustomFieldContextDefaultValueForgeUserField() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomFieldContextDefaultValueForgeUserField CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CustomFieldContextDefaultValueForgeUserField();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accountId", n => { AccountId = n.GetStringValue(); } },
                {"contextId", n => { ContextId = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"userFilter", n => { UserFilter = n.GetObjectValue<AtlassianClient.Models.UserFilter>(AtlassianClient.Models.UserFilter.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("accountId", AccountId);
            writer.WriteStringValue("contextId", ContextId);
            writer.WriteStringValue("type", Type);
            writer.WriteObjectValue<AtlassianClient.Models.UserFilter>("userFilter", UserFilter);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
