// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The details of votes on an issue.
    /// </summary>
    public class Votes : IParsable {
        /// <summary>Whether the user making this request has voted on the issue.</summary>
        public bool? HasVoted { get; private set; }
        /// <summary>The URL of these issue vote details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>List of the users who have voted on this issue. An empty list is returned when the calling user doesn&apos;t have the *View voters and watchers* project permission.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<User>? Voters { get; private set; }
#nullable restore
#else
        public List<User> Voters { get; private set; }
#endif
        /// <summary>The number of votes on the issue.</summary>
        public long? VotesProp { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static Votes CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Votes();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"hasVoted", n => { HasVoted = n.GetBoolValue(); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"voters", n => { Voters = n.GetCollectionOfObjectValues<User>(User.CreateFromDiscriminatorValue)?.ToList(); } },
                {"votes", n => { VotesProp = n.GetLongValue(); } },
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