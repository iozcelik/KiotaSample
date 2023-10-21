// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A screen with tab details.
    /// </summary>
    public class ScreenWithTab : IParsable {
        /// <summary>The description of the screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; private set; }
#nullable restore
#else
        public string Description { get; private set; }
#endif
        /// <summary>The ID of the screen.</summary>
        public long? Id { get; private set; }
        /// <summary>The name of the screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>The scope of the screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.Scope? Scope { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.Scope Scope { get; set; }
#endif
        /// <summary>The tab for the screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ScreenableTab? Tab { get; set; }
#nullable restore
#else
        public ScreenableTab Tab { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ScreenWithTab CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ScreenWithTab();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<AtlassianClient.Models.Scope>(AtlassianClient.Models.Scope.CreateFromDiscriminatorValue); } },
                {"tab", n => { Tab = n.GetObjectValue<ScreenableTab>(ScreenableTab.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<AtlassianClient.Models.Scope>("scope", Scope);
            writer.WriteObjectValue<ScreenableTab>("tab", Tab);
        }
    }
}