// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The details of watchers on an issue.
    /// </summary>
    public class Watchers : IParsable {
        /// <summary>Whether the calling user is watching this issue.</summary>
        public bool? IsWatching { get; private set; }
        /// <summary>The URL of these issue watcher details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>The number of users watching this issue.</summary>
        public int? WatchCount { get; private set; }
        /// <summary>Details of the users watching this issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserDetails>? WatchersProp { get; private set; }
#nullable restore
#else
        public List<UserDetails> WatchersProp { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Watchers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Watchers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isWatching", n => { IsWatching = n.GetBoolValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"watchCount", n => { WatchCount = n.GetIntValue(); } },
                {"watchers", n => { WatchersProp = n.GetCollectionOfObjectValues<UserDetails>(UserDetails.CreateFromDiscriminatorValue)?.ToList(); } },
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
