// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Metadata for an item in an attachment archive.
    /// </summary>
    public class AttachmentArchiveItemReadable : IParsable {
        /// <summary>The position of the item within the archive.</summary>
        public long? Index { get; private set; }
        /// <summary>The label for the archive item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; private set; }
#nullable restore
#else
        public string Label { get; private set; }
#endif
        /// <summary>The MIME type of the archive item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? MediaType { get; private set; }
#nullable restore
#else
        public string MediaType { get; private set; }
#endif
        /// <summary>The path of the archive item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Path { get; private set; }
#nullable restore
#else
        public string Path { get; private set; }
#endif
        /// <summary>The size of the archive item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Size { get; private set; }
#nullable restore
#else
        public string Size { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttachmentArchiveItemReadable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttachmentArchiveItemReadable();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"index", n => { Index = n.GetLongValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"path", n => { Path = n.GetStringValue(); } },
                {"size", n => { Size = n.GetStringValue(); } },
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
