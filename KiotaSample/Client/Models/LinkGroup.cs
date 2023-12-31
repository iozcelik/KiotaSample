// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details a link group, which defines issue operations.
    /// </summary>
    public class LinkGroup : IParsable {
        /// <summary>The groups property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<LinkGroup>? Groups { get; set; }
#nullable restore
#else
        public List<LinkGroup> Groups { get; set; }
#endif
        /// <summary>Details about the operations available in this version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public SimpleLink? Header { get; set; }
#nullable restore
#else
        public SimpleLink Header { get; set; }
#endif
        /// <summary>The id property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The links property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SimpleLink>? Links { get; set; }
#nullable restore
#else
        public List<SimpleLink> Links { get; set; }
#endif
        /// <summary>The styleClass property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? StyleClass { get; set; }
#nullable restore
#else
        public string StyleClass { get; set; }
#endif
        /// <summary>The weight property</summary>
        public int? Weight { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static LinkGroup CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LinkGroup();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"groups", n => { Groups = n.GetCollectionOfObjectValues<LinkGroup>(LinkGroup.CreateFromDiscriminatorValue)?.ToList(); } },
                {"header", n => { Header = n.GetObjectValue<SimpleLink>(SimpleLink.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"links", n => { Links = n.GetCollectionOfObjectValues<SimpleLink>(SimpleLink.CreateFromDiscriminatorValue)?.ToList(); } },
                {"styleClass", n => { StyleClass = n.GetStringValue(); } },
                {"weight", n => { Weight = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<LinkGroup>("groups", Groups);
            writer.WriteObjectValue<SimpleLink>("header", Header);
            writer.WriteStringValue("id", Id);
            writer.WriteCollectionOfObjectValues<SimpleLink>("links", Links);
            writer.WriteStringValue("styleClass", StyleClass);
            writer.WriteIntValue("weight", Weight);
        }
    }
}
