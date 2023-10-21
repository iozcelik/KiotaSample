// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The converted JQL queries.
    /// </summary>
    public class ConvertedJQLQueries : IParsable {
        /// <summary>List of queries containing user information that could not be mapped to an existing user</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JQLQueryWithUnknownUsers>? QueriesWithUnknownUsers { get; set; }
#nullable restore
#else
        public List<JQLQueryWithUnknownUsers> QueriesWithUnknownUsers { get; set; }
#endif
        /// <summary>The list of converted query strings with account IDs in place of user identifiers.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? QueryStrings { get; set; }
#nullable restore
#else
        public List<string> QueryStrings { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ConvertedJQLQueries CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ConvertedJQLQueries();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"queriesWithUnknownUsers", n => { QueriesWithUnknownUsers = n.GetCollectionOfObjectValues<JQLQueryWithUnknownUsers>(JQLQueryWithUnknownUsers.CreateFromDiscriminatorValue)?.ToList(); } },
                {"queryStrings", n => { QueryStrings = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<JQLQueryWithUnknownUsers>("queriesWithUnknownUsers", QueriesWithUnknownUsers);
            writer.WriteCollectionOfPrimitiveValues<string>("queryStrings", QueryStrings);
        }
    }
}
