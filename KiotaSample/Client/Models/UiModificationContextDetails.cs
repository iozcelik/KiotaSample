// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// The details of a UI modification&apos;s context, which define where to activate the UI modification.
    /// </summary>
    public class UiModificationContextDetails : IParsable {
        /// <summary>The ID of the UI modification context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>Whether a context is available. For example, when a project is deleted the context becomes unavailable.</summary>
        public bool? IsAvailable { get; private set; }
        /// <summary>The issue type ID of the context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueTypeId { get; set; }
#nullable restore
#else
        public string IssueTypeId { get; set; }
#endif
        /// <summary>The project ID of the context.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ProjectId { get; set; }
#nullable restore
#else
        public string ProjectId { get; set; }
#endif
        /// <summary>The view type of the context. Only `GIC`(Global Issue Create) and `IssueView` are supported.</summary>
        public UiModificationContextDetails_viewType? ViewType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static UiModificationContextDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UiModificationContextDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"id", n => { Id = n.GetStringValue(); } },
                {"isAvailable", n => { IsAvailable = n.GetBoolValue(); } },
                {"issueTypeId", n => { IssueTypeId = n.GetStringValue(); } },
                {"projectId", n => { ProjectId = n.GetStringValue(); } },
                {"viewType", n => { ViewType = n.GetEnumValue<UiModificationContextDetails_viewType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("issueTypeId", IssueTypeId);
            writer.WriteStringValue("projectId", ProjectId);
            writer.WriteEnumValue<UiModificationContextDetails_viewType>("viewType", ViewType);
        }
    }
}