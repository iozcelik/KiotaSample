// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Composed type wrapper for classes IssueContextVariable, JsonContextVariable, UserContextVariable
    /// </summary>
    public class CustomContextVariable : IComposedTypeWrapper, IParsable {
        /// <summary>Composed type representation for type IssueContextVariable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.IssueContextVariable? IssueContextVariable { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.IssueContextVariable IssueContextVariable { get; set; }
#endif
        /// <summary>Composed type representation for type JsonContextVariable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.JsonContextVariable? JsonContextVariable { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.JsonContextVariable JsonContextVariable { get; set; }
#endif
        /// <summary>Composed type representation for type UserContextVariable</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.UserContextVariable? UserContextVariable { get; set; }
#nullable restore
#else
        public AtlassianClient.Models.UserContextVariable UserContextVariable { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CustomContextVariable CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("type")?.GetStringValue();
            var result = new CustomContextVariable();
            if("issue".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.IssueContextVariable = new AtlassianClient.Models.IssueContextVariable();
            }
            else if("json".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.JsonContextVariable = new AtlassianClient.Models.JsonContextVariable();
            }
            else if("user".Equals(mappingValue, StringComparison.OrdinalIgnoreCase)) {
                result.UserContextVariable = new AtlassianClient.Models.UserContextVariable();
            }
            return result;
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            if(IssueContextVariable != null) {
                return IssueContextVariable.GetFieldDeserializers();
            }
            else if(JsonContextVariable != null) {
                return JsonContextVariable.GetFieldDeserializers();
            }
            else if(UserContextVariable != null) {
                return UserContextVariable.GetFieldDeserializers();
            }
            return new Dictionary<string, Action<IParseNode>>();
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            if(IssueContextVariable != null) {
                writer.WriteObjectValue<AtlassianClient.Models.IssueContextVariable>(null, IssueContextVariable);
            }
            else if(JsonContextVariable != null) {
                writer.WriteObjectValue<AtlassianClient.Models.JsonContextVariable>(null, JsonContextVariable);
            }
            else if(UserContextVariable != null) {
                writer.WriteObjectValue<AtlassianClient.Models.UserContextVariable>(null, UserContextVariable);
            }
        }
    }
}