// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of the projects the option is available in.
    /// </summary>
    public class IssueFieldOptionConfiguration : IParsable {
        /// <summary>DEPRECATED</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IssueFieldOptionConfiguration_attributes?>? Attributes { get; set; }
#nullable restore
#else
        public List<IssueFieldOptionConfiguration_attributes?> Attributes { get; set; }
#endif
        /// <summary>Defines the projects that the option is available in. If the scope is not defined, then the option is available in all projects.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueFieldOptionScopeBean? Scope { get; set; }
#nullable restore
#else
        public IssueFieldOptionScopeBean Scope { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueFieldOptionConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueFieldOptionConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attributes", n => { Attributes = n.GetCollectionOfEnumValues<IssueFieldOptionConfiguration_attributes>()?.ToList(); } },
                {"scope", n => { Scope = n.GetObjectValue<IssueFieldOptionScopeBean>(IssueFieldOptionScopeBean.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfEnumValues<IssueFieldOptionConfiguration_attributes>("attributes", Attributes);
            writer.WriteObjectValue<IssueFieldOptionScopeBean>("scope", Scope);
        }
    }
}
