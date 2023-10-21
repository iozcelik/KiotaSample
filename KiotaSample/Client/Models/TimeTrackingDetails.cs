// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Time tracking details.
    /// </summary>
    public class TimeTrackingDetails : IParsable {
        /// <summary>The original estimate of time needed for this issue in readable format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OriginalEstimate { get; private set; }
#nullable restore
#else
        public string OriginalEstimate { get; private set; }
#endif
        /// <summary>The original estimate of time needed for this issue in seconds.</summary>
        public long? OriginalEstimateSeconds { get; private set; }
        /// <summary>The remaining estimate of time needed for this issue in readable format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? RemainingEstimate { get; private set; }
#nullable restore
#else
        public string RemainingEstimate { get; private set; }
#endif
        /// <summary>The remaining estimate of time needed for this issue in seconds.</summary>
        public long? RemainingEstimateSeconds { get; private set; }
        /// <summary>Time worked on this issue in readable format.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TimeSpent { get; private set; }
#nullable restore
#else
        public string TimeSpent { get; private set; }
#endif
        /// <summary>Time worked on this issue in seconds.</summary>
        public long? TimeSpentSeconds { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TimeTrackingDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeTrackingDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"originalEstimate", n => { OriginalEstimate = n.GetStringValue(); } },
                {"originalEstimateSeconds", n => { OriginalEstimateSeconds = n.GetLongValue(); } },
                {"remainingEstimate", n => { RemainingEstimate = n.GetStringValue(); } },
                {"remainingEstimateSeconds", n => { RemainingEstimateSeconds = n.GetLongValue(); } },
                {"timeSpent", n => { TimeSpent = n.GetStringValue(); } },
                {"timeSpentSeconds", n => { TimeSpentSeconds = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}