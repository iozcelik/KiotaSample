// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of a workflow transition.
    /// </summary>
    public class Transition : IParsable {
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
        public List<string>? From { get; set; }
#nullable restore
#else
        public List<string> From { get; set; }
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
        public Transition_properties? Properties { get; set; }
#nullable restore
#else
        public Transition_properties Properties { get; set; }
#endif
        /// <summary>A collection of transition rules.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowRules? Rules { get; set; }
#nullable restore
#else
        public WorkflowRules Rules { get; set; }
#endif
        /// <summary>The details of a transition screen.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TransitionScreenDetails? Screen { get; set; }
#nullable restore
#else
        public TransitionScreenDetails Screen { get; set; }
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
        public Transition_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Transition CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Transition();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"description", n => { Description = n.GetStringValue(); } },
                {"from", n => { From = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"properties", n => { Properties = n.GetObjectValue<Transition_properties>(Transition_properties.CreateFromDiscriminatorValue); } },
                {"rules", n => { Rules = n.GetObjectValue<WorkflowRules>(WorkflowRules.CreateFromDiscriminatorValue); } },
                {"screen", n => { Screen = n.GetObjectValue<TransitionScreenDetails>(TransitionScreenDetails.CreateFromDiscriminatorValue); } },
                {"to", n => { To = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<Transition_type>(); } },
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
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Transition_properties>("properties", Properties);
            writer.WriteObjectValue<WorkflowRules>("rules", Rules);
            writer.WriteObjectValue<TransitionScreenDetails>("screen", Screen);
            writer.WriteStringValue("to", To);
            writer.WriteEnumValue<Transition_type>("type", Type);
        }
    }
}
