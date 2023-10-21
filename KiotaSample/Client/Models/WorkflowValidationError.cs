// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The details about a workflow validation error.
    /// </summary>
    public class WorkflowValidationError : IParsable {
        /// <summary>An error code.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code { get; set; }
#nullable restore
#else
        public string Code { get; set; }
#endif
        /// <summary>A reference to the location of the error. This will be null if the error does not refer to a specific element.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public WorkflowElementReference? ElementReference { get; set; }
#nullable restore
#else
        public WorkflowElementReference ElementReference { get; set; }
#endif
        /// <summary>The validation error level.</summary>
        public WorkflowValidationError_level? Level { get; set; }
        /// <summary>An error message.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Message { get; set; }
#nullable restore
#else
        public string Message { get; set; }
#endif
        /// <summary>The type of element the error or warning references.</summary>
        public WorkflowValidationError_type? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static WorkflowValidationError CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowValidationError();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"code", n => { Code = n.GetStringValue(); } },
                {"elementReference", n => { ElementReference = n.GetObjectValue<WorkflowElementReference>(WorkflowElementReference.CreateFromDiscriminatorValue); } },
                {"level", n => { Level = n.GetEnumValue<WorkflowValidationError_level>(); } },
                {"message", n => { Message = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<WorkflowValidationError_type>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("code", Code);
            writer.WriteObjectValue<WorkflowElementReference>("elementReference", ElementReference);
            writer.WriteEnumValue<WorkflowValidationError_level>("level", Level);
            writer.WriteStringValue("message", Message);
            writer.WriteEnumValue<WorkflowValidationError_type>("type", Type);
        }
    }
}
