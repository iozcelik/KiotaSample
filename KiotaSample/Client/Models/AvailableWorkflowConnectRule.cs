// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The Connect provided ecosystem rules available.
    /// </summary>
    public class AvailableWorkflowConnectRule : IParsable {
        /// <summary>The add-on providing the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AddonKey { get; set; }
#nullable restore
#else
        public string AddonKey { get; set; }
#endif
        /// <summary>The URL creation path segment defined in the Connect module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CreateUrl { get; set; }
#nullable restore
#else
        public string CreateUrl { get; set; }
#endif
        /// <summary>The rule description.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The URL edit path segment defined in the Connect module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? EditUrl { get; set; }
#nullable restore
#else
        public string EditUrl { get; set; }
#endif
        /// <summary>The module providing the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ModuleKey { get; set; }
#nullable restore
#else
        public string ModuleKey { get; set; }
#endif
        /// <summary>The rule name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The rule key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleKey { get; set; }
#nullable restore
#else
        public string RuleKey { get; set; }
#endif
        /// <summary>The rule type.</summary>
        public AvailableWorkflowConnectRule_ruleType? RuleType { get; set; }
        /// <summary>The URL view path segment defined in the Connect module.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ViewUrl { get; set; }
#nullable restore
#else
        public string ViewUrl { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AvailableWorkflowConnectRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AvailableWorkflowConnectRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"addonKey", n => { AddonKey = n.GetStringValue(); } },
                {"createUrl", n => { CreateUrl = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"editUrl", n => { EditUrl = n.GetStringValue(); } },
                {"moduleKey", n => { ModuleKey = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"ruleKey", n => { RuleKey = n.GetStringValue(); } },
                {"ruleType", n => { RuleType = n.GetEnumValue<AvailableWorkflowConnectRule_ruleType>(); } },
                {"viewUrl", n => { ViewUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("addonKey", AddonKey);
            writer.WriteStringValue("createUrl", CreateUrl);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("editUrl", EditUrl);
            writer.WriteStringValue("moduleKey", ModuleKey);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("ruleKey", RuleKey);
            writer.WriteEnumValue<AvailableWorkflowConnectRule_ruleType>("ruleType", RuleType);
            writer.WriteStringValue("viewUrl", ViewUrl);
        }
    }
}
