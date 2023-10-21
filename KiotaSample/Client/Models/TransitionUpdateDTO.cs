// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The transitions of this workflow.
    /// </summary>
    public class TransitionUpdateDTO : IAdditionalDataHolder, IParsable {
        /// <summary>The post-functions of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowRuleConfiguration>? Actions { get; set; }
#nullable restore
#else
        public List<WorkflowRuleConfiguration> Actions { get; set; }
#endif
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The conditions group associated with the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ConditionGroupUpdate? Conditions { get; set; }
#nullable restore
#else
        public ConditionGroupUpdate Conditions { get; set; }
#endif
        /// <summary>The custom event ID of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? CustomIssueEventId { get; set; }
#nullable restore
#else
        public string CustomIssueEventId { get; set; }
#endif
        /// <summary>The description of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; set; }
#nullable restore
#else
        public string Description { get; set; }
#endif
        /// <summary>The statuses the transition can start from.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<StatusReferenceAndPort>? From { get; set; }
#nullable restore
#else
        public List<StatusReferenceAndPort> From { get; set; }
#endif
        /// <summary>The ID of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The name of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The properties of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TransitionUpdateDTO_properties? Properties { get; set; }
#nullable restore
#else
        public TransitionUpdateDTO_properties Properties { get; set; }
#endif
        /// <summary>The status reference and port that a transition is connected to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public StatusReferenceAndPort? To { get; set; }
#nullable restore
#else
        public StatusReferenceAndPort To { get; set; }
#endif
        /// <summary>The configuration of the rule.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowRuleConfiguration? TransitionScreen { get; set; }
#nullable restore
#else
        public WorkflowRuleConfiguration TransitionScreen { get; set; }
#endif
        /// <summary>The triggers of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowTrigger>? Triggers { get; set; }
#nullable restore
#else
        public List<WorkflowTrigger> Triggers { get; set; }
#endif
        /// <summary>The transition type.</summary>
        public TransitionUpdateDTO_type? Type { get; set; }
        /// <summary>The validators of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<WorkflowRuleConfiguration>? Validators { get; set; }
#nullable restore
#else
        public List<WorkflowRuleConfiguration> Validators { get; set; }
#endif
        /// <summary>
        /// Instantiates a new TransitionUpdateDTO and sets the default values.
        /// </summary>
        public TransitionUpdateDTO() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TransitionUpdateDTO CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TransitionUpdateDTO();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actions", n => { Actions = n.GetCollectionOfObjectValues<WorkflowRuleConfiguration>(WorkflowRuleConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
                {"conditions", n => { Conditions = n.GetObjectValue<ConditionGroupUpdate>(ConditionGroupUpdate.CreateFromDiscriminatorValue); } },
                {"customIssueEventId", n => { CustomIssueEventId = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"from", n => { From = n.GetCollectionOfObjectValues<StatusReferenceAndPort>(StatusReferenceAndPort.CreateFromDiscriminatorValue)?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"properties", n => { Properties = n.GetObjectValue<TransitionUpdateDTO_properties>(TransitionUpdateDTO_properties.CreateFromDiscriminatorValue); } },
                {"to", n => { To = n.GetObjectValue<StatusReferenceAndPort>(StatusReferenceAndPort.CreateFromDiscriminatorValue); } },
                {"transitionScreen", n => { TransitionScreen = n.GetObjectValue<WorkflowRuleConfiguration>(WorkflowRuleConfiguration.CreateFromDiscriminatorValue); } },
                {"triggers", n => { Triggers = n.GetCollectionOfObjectValues<WorkflowTrigger>(WorkflowTrigger.CreateFromDiscriminatorValue)?.ToList(); } },
                {"type", n => { Type = n.GetEnumValue<TransitionUpdateDTO_type>(); } },
                {"validators", n => { Validators = n.GetCollectionOfObjectValues<WorkflowRuleConfiguration>(WorkflowRuleConfiguration.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<WorkflowRuleConfiguration>("actions", Actions);
            writer.WriteObjectValue<ConditionGroupUpdate>("conditions", Conditions);
            writer.WriteStringValue("customIssueEventId", CustomIssueEventId);
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfObjectValues<StatusReferenceAndPort>("from", From);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<TransitionUpdateDTO_properties>("properties", Properties);
            writer.WriteObjectValue<StatusReferenceAndPort>("to", To);
            writer.WriteObjectValue<WorkflowRuleConfiguration>("transitionScreen", TransitionScreen);
            writer.WriteCollectionOfObjectValues<WorkflowTrigger>("triggers", Triggers);
            writer.WriteEnumValue<TransitionUpdateDTO_type>("type", Type);
            writer.WriteCollectionOfObjectValues<WorkflowRuleConfiguration>("validators", Validators);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}