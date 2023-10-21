// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A type of issue suggested for use in auto-completion.
    /// </summary>
    public class IssuePickerSuggestionsIssueType : IParsable {
        /// <summary>The ID of the type of issues suggested for use in auto-completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>A list of issues suggested for use in auto-completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<SuggestedIssue>? Issues { get; private set; }
#nullable restore
#else
        public List<SuggestedIssue> Issues { get; private set; }
#endif
        /// <summary>The label of the type of issues suggested for use in auto-completion.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Label { get; private set; }
#nullable restore
#else
        public string Label { get; private set; }
#endif
        /// <summary>If no issue suggestions are found, returns a message indicating no suggestions were found,</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Msg { get; private set; }
#nullable restore
#else
        public string Msg { get; private set; }
#endif
        /// <summary>If issue suggestions are found, returns a message indicating the number of issues suggestions found and returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Sub { get; private set; }
#nullable restore
#else
        public string Sub { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssuePickerSuggestionsIssueType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssuePickerSuggestionsIssueType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"id", n => { Id = n.GetStringValue(); } },
                {"issues", n => { Issues = n.GetCollectionOfObjectValues<SuggestedIssue>(SuggestedIssue.CreateFromDiscriminatorValue)?.ToList(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"msg", n => { Msg = n.GetStringValue(); } },
                {"sub", n => { Sub = n.GetStringValue(); } },
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
