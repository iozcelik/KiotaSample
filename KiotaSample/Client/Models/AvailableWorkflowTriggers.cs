// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The trigger rules available.
    /// </summary>
    public class AvailableWorkflowTriggers : IParsable {
        /// <summary>The list of available trigger types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<AvailableWorkflowTriggerTypes>? AvailableTypes { get; set; }
#nullable restore
#else
        public List<AvailableWorkflowTriggerTypes> AvailableTypes { get; set; }
#endif
        /// <summary>The rule key of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RuleKey { get; set; }
#nullable restore
#else
        public string RuleKey { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AvailableWorkflowTriggers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AvailableWorkflowTriggers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"availableTypes", n => { AvailableTypes = n.GetCollectionOfObjectValues<AvailableWorkflowTriggerTypes>(AvailableWorkflowTriggerTypes.CreateFromDiscriminatorValue)?.ToList(); } },
                {"ruleKey", n => { RuleKey = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AvailableWorkflowTriggerTypes>("availableTypes", AvailableTypes);
            writer.WriteStringValue("ruleKey", RuleKey);
        }
    }
}
