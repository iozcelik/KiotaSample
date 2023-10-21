// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class UserBeanAvatarUrls : IParsable {
        /// <summary>The URL of the user&apos;s 48x48 pixel avatar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FourEightx48 { get; set; }
#nullable restore
#else
        public string FourEightx48 { get; set; }
#endif
        /// <summary>The URL of the user&apos;s 16x16 pixel avatar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OneSixx16 { get; set; }
#nullable restore
#else
        public string OneSixx16 { get; set; }
#endif
        /// <summary>The URL of the user&apos;s 32x32 pixel avatar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ThreeTwox32 { get; set; }
#nullable restore
#else
        public string ThreeTwox32 { get; set; }
#endif
        /// <summary>The URL of the user&apos;s 24x24 pixel avatar.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TwoFourx24 { get; set; }
#nullable restore
#else
        public string TwoFourx24 { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UserBeanAvatarUrls CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserBeanAvatarUrls();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"48x48", n => { FourEightx48 = n.GetStringValue(); } },
                {"16x16", n => { OneSixx16 = n.GetStringValue(); } },
                {"32x32", n => { ThreeTwox32 = n.GetStringValue(); } },
                {"24x24", n => { TwoFourx24 = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("48x48", FourEightx48);
            writer.WriteStringValue("16x16", OneSixx16);
            writer.WriteStringValue("32x32", ThreeTwox32);
            writer.WriteStringValue("24x24", TwoFourx24);
        }
    }
}
