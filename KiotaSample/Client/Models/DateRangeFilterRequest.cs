// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// List issues archived within a specified date range.
    /// </summary>
    public class DateRangeFilterRequest : IParsable {
        /// <summary>List issues archived after a specified date, passed in the YYYY-MM-DD format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateAfter { get; set; }
#nullable restore
#else
        public string DateAfter { get; set; }
#endif
        /// <summary>List issues archived before a specified date provided in the YYYY-MM-DD format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DateBefore { get; set; }
#nullable restore
#else
        public string DateBefore { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DateRangeFilterRequest CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DateRangeFilterRequest();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"dateAfter", n => { DateAfter = n.GetStringValue(); } },
                {"dateBefore", n => { DateBefore = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("dateAfter", DateAfter);
            writer.WriteStringValue("dateBefore", DateBefore);
        }
    }
}
