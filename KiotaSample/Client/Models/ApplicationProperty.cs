// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details of an application property.
    /// </summary>
    public class ApplicationProperty : IParsable {
        /// <summary>The allowed values, if applicable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AllowedValues { get; set; }
#nullable restore
#else
        public List<string> AllowedValues { get; set; }
#endif
        /// <summary>The default value of the application property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DefaultValue { get; set; }
#nullable restore
#else
        public string DefaultValue { get; set; }
#endif
        /// <summary>The description of the application property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Desc { get; set; }
#nullable restore
#else
        public string Desc { get; set; }
#endif
        /// <summary>The example property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Example { get; set; }
#nullable restore
#else
        public string Example { get; set; }
#endif
        /// <summary>The ID of the application property. The ID and key are the same.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; set; }
#nullable restore
#else
        public string Id { get; set; }
#endif
        /// <summary>The key of the application property. The ID and key are the same.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; set; }
#nullable restore
#else
        public string Key { get; set; }
#endif
        /// <summary>The name of the application property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>The data type of the application property.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Type { get; set; }
#nullable restore
#else
        public string Type { get; set; }
#endif
        /// <summary>The new value.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; set; }
#nullable restore
#else
        public string Value { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ApplicationProperty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ApplicationProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowedValues", n => { AllowedValues = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"defaultValue", n => { DefaultValue = n.GetStringValue(); } },
                {"desc", n => { Desc = n.GetStringValue(); } },
                {"example", n => { Example = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"type", n => { Type = n.GetStringValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("allowedValues", AllowedValues);
            writer.WriteStringValue("defaultValue", DefaultValue);
            writer.WriteStringValue("desc", Desc);
            writer.WriteStringValue("example", Example);
            writer.WriteStringValue("id", Id);
            writer.WriteStringValue("key", Key);
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("type", Type);
            writer.WriteStringValue("value", Value);
        }
    }
}
