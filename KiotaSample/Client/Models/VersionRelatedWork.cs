// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Associated related work to a version
    /// </summary>
    public class VersionRelatedWork : IParsable {
        /// <summary>The category of the related work</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Category { get; private set; }
#nullable restore
#else
        public string Category { get; private set; }
#endif
        /// <summary>The title of the related work</summary>
        public long? IssueId { get; private set; }
        /// <summary>The id of the related work. For the native release note related work item, this will be null, and Rest API does not support updating it.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RelatedWorkId { get; private set; }
#nullable restore
#else
        public string RelatedWorkId { get; private set; }
#endif
        /// <summary>The title of the related work</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Title { get; private set; }
#nullable restore
#else
        public string Title { get; private set; }
#endif
        /// <summary>The URL of the related work</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Url { get; private set; }
#nullable restore
#else
        public string Url { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static VersionRelatedWork CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VersionRelatedWork();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"category", n => { Category = n.GetStringValue(); } },
                {"issueId", n => { IssueId = n.GetLongValue(); } },
                {"relatedWorkId", n => { RelatedWorkId = n.GetStringValue(); } },
                {"title", n => { Title = n.GetStringValue(); } },
                {"url", n => { Url = n.GetStringValue(); } },
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
