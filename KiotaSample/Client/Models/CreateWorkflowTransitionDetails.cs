// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The details of a workflow transition.
    /// </summary>
    public class CreateWorkflowTransitionDetails : IParsable {
        /// <summary>The description of the transition. The maximum length is 1000 characters.</summary>
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
        public List<string>? From { get; set; }
#nullable restore
#else
        public List<string> From { get; set; }
#endif
        /// <summary>The name of the transition. The maximum length is 60 characters.</summary>
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
        public CreateWorkflowTransitionDetails_properties? Properties { get; set; }
#nullable restore
#else
        public CreateWorkflowTransitionDetails_properties Properties { get; set; }
#endif
        /// <summary>The rules of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateWorkflowTransitionRulesDetails? Rules { get; set; }
#nullable restore
#else
        public CreateWorkflowTransitionRulesDetails Rules { get; set; }
#endif
        /// <summary>The screen of the transition.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public CreateWorkflowTransitionScreenDetails? Screen { get; set; }
#nullable restore
#else
        public CreateWorkflowTransitionScreenDetails Screen { get; set; }
#endif
        /// <summary>The status the transition goes to.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? To { get; set; }
#nullable restore
#else
        public string To { get; set; }
#endif
        /// <summary>The type of the transition.</summary>
        public CreateWorkflowTransitionDetails_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static CreateWorkflowTransitionDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CreateWorkflowTransitionDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"from", n => { From = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"properties", n => { Properties = n.GetObjectValue<CreateWorkflowTransitionDetails_properties>(CreateWorkflowTransitionDetails_properties.CreateFromDiscriminatorValue); } },
                {"rules", n => { Rules = n.GetObjectValue<CreateWorkflowTransitionRulesDetails>(CreateWorkflowTransitionRulesDetails.CreateFromDiscriminatorValue); } },
                {"screen", n => { Screen = n.GetObjectValue<CreateWorkflowTransitionScreenDetails>(CreateWorkflowTransitionScreenDetails.CreateFromDiscriminatorValue); } },
                {"to", n => { To = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<CreateWorkflowTransitionDetails_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteCollectionOfPrimitiveValues<string>("from", From);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<CreateWorkflowTransitionDetails_properties>("properties", Properties);
            writer.WriteObjectValue<CreateWorkflowTransitionRulesDetails>("rules", Rules);
            writer.WriteObjectValue<CreateWorkflowTransitionScreenDetails>("screen", Screen);
            writer.WriteStringValue("to", To);
            writer.WriteEnumValue<CreateWorkflowTransitionDetails_type>("type", Type);
        }
    }
}
