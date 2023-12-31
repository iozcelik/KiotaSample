// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class SecuritySchemeLevelBean : IParsable {
        /// <summary>The description of the issue security scheme level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>Specifies whether the level is the default level. False by default.</summary>
        public bool? IsDefault { get; set; }
        /// <summary>The list of level members which should be added to the issue security scheme level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SecuritySchemeLevelMemberBean>? Members { get; set; }
#nullable restore
#else
        public List<SecuritySchemeLevelMemberBean> Members { get; set; }
#endif
        /// <summary>The name of the issue security scheme level. Must be unique.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecuritySchemeLevelBean CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecuritySchemeLevelBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"members", n => { Members = n.GetCollectionOfObjectValues<SecuritySchemeLevelMemberBean>(SecuritySchemeLevelMemberBean.CreateFromDiscriminatorValue)?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteCollectionOfObjectValues<SecuritySchemeLevelMemberBean>("members", Members);
            writer.WriteStringValue("name", Name);
        }
    }
}
