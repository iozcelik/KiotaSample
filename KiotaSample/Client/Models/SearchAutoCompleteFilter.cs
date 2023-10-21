// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of how to filter and list search auto complete information.
    /// </summary>
    public class SearchAutoCompleteFilter : IParsable {
        /// <summary>Include collapsed fields for fields that have non-unique names.</summary>
        public bool? IncludeCollapsedFields { get; set; }
        /// <summary>List of project IDs used to filter the visible field details returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<long?>? ProjectIds { get; set; }
#nullable restore
#else
        public List<long?> ProjectIds { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SearchAutoCompleteFilter CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SearchAutoCompleteFilter();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"includeCollapsedFields", n => { IncludeCollapsedFields = n.GetBoolValue(); } },
                {"projectIds", n => { ProjectIds = n.GetCollectionOfPrimitiveValues<long?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("includeCollapsedFields", IncludeCollapsedFields);
            writer.WriteCollectionOfPrimitiveValues<long?>("projectIds", ProjectIds);
        }
    }
}