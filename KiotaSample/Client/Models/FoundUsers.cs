// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The list of users found in a search, including header text (Showing X of Y matching users) and total of matched users.
    /// </summary>
    public class FoundUsers : IParsable {
        /// <summary>Header text indicating the number of users in the response and the total number of users found in the search.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Header { get; set; }
#nullable restore
#else
        public string Header { get; set; }
#endif
        /// <summary>The total number of users found in the search.</summary>
        public int? Total { get; set; }
        /// <summary>The users property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<UserPickerUser>? Users { get; set; }
#nullable restore
#else
        public List<UserPickerUser> Users { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FoundUsers CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FoundUsers();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"header", n => { Header = n.GetStringValue(); } },
                {"total", n => { Total = n.GetIntValue(); } },
                {"users", n => { Users = n.GetCollectionOfObjectValues<UserPickerUser>(UserPickerUser.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("header", Header);
            writer.WriteIntValue("total", Total);
            writer.WriteCollectionOfObjectValues<UserPickerUser>("users", Users);
        }
    }
}