// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// An ordered list of custom field option IDs and information on where to move them.
    /// </summary>
    public class OrderOfCustomFieldOptions : IParsable {
        /// <summary>The ID of the custom field option or cascading option to place the moved options after. Required if `position` isn&apos;t provided.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? After { get; set; }
#nullable restore
#else
        public string After { get; set; }
#endif
        /// <summary>A list of IDs of custom field options to move. The order of the custom field option IDs in the list is the order they are given after the move. The list must contain custom field options or cascading options, but not both.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? CustomFieldOptionIds { get; set; }
#nullable restore
#else
        public List<string> CustomFieldOptionIds { get; set; }
#endif
        /// <summary>The position the custom field options should be moved to. Required if `after` isn&apos;t provided.</summary>
        public OrderOfCustomFieldOptions_position? Position { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static OrderOfCustomFieldOptions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OrderOfCustomFieldOptions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"after", n => { After = n.GetStringValue(); } },
                {"customFieldOptionIds", n => { CustomFieldOptionIds = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"position", n => { Position = n.GetEnumValue<OrderOfCustomFieldOptions_position>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("after", After);
            writer.WriteCollectionOfPrimitiveValues<string>("customFieldOptionIds", CustomFieldOptionIds);
            writer.WriteEnumValue<OrderOfCustomFieldOptions_position>("position", Position);
        }
    }
}