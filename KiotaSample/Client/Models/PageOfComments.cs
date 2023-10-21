// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A page of comments.
    /// </summary>
    public class PageOfComments : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The list of comments.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Comment>? Comments { get; private set; }
#nullable restore
#else
        public List<Comment> Comments { get; private set; }
#endif
        /// <summary>The maximum number of items that could be returned.</summary>
        public int? MaxResults { get; private set; }
        /// <summary>The index of the first item returned.</summary>
        public long? StartAt { get; private set; }
        /// <summary>The number of items returned.</summary>
        public long? Total { get; private set; }
        /// <summary>
        /// Instantiates a new PageOfComments and sets the default values.
        /// </summary>
        public PageOfComments() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static PageOfComments CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PageOfComments();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"comments", n => { Comments = n.GetCollectionOfObjectValues<Comment>(Comment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"maxResults", n => { MaxResults = n.GetIntValue(); } },
                {"startAt", n => { StartAt = n.GetLongValue(); } },
                {"total", n => { Total = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
