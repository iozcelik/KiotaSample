// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about an issue.
    /// </summary>
    public class IssueBean : IParsable {
        /// <summary>Details of changelogs associated with the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PageOfChangelogs? Changelog { get; private set; }
#nullable restore
#else
        public PageOfChangelogs Changelog { get; private set; }
#endif
        /// <summary>The metadata for the fields on the issue that can be amended.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueUpdateMetadata? Editmeta { get; private set; }
#nullable restore
#else
        public IssueUpdateMetadata Editmeta { get; private set; }
#endif
        /// <summary>Expand options that include additional issue details in the response.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Expand { get; private set; }
#nullable restore
#else
        public string Expand { get; private set; }
#endif
        /// <summary>The fields property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueBean_fields? Fields { get; set; }
#nullable restore
#else
        public IssueBean_fields Fields { get; set; }
#endif
        /// <summary>The fieldsToInclude property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IncludedFields? FieldsToInclude { get; set; }
#nullable restore
#else
        public IncludedFields FieldsToInclude { get; set; }
#endif
        /// <summary>The ID of the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The key of the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Key { get; private set; }
#nullable restore
#else
        public string Key { get; private set; }
#endif
        /// <summary>The ID and name of each field present on the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueBean_names? Names { get; private set; }
#nullable restore
#else
        public IssueBean_names Names { get; private set; }
#endif
        /// <summary>The operations that can be performed on the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.Operations? Operations { get; private set; }
#nullable restore
#else
        public AtlassianClient.Models.Operations Operations { get; private set; }
#endif
        /// <summary>Details of the issue properties identified in the request.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueBean_properties? Properties { get; private set; }
#nullable restore
#else
        public IssueBean_properties Properties { get; private set; }
#endif
        /// <summary>The rendered value of each field present on the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueBean_renderedFields? RenderedFields { get; private set; }
#nullable restore
#else
        public IssueBean_renderedFields RenderedFields { get; private set; }
#endif
        /// <summary>The schema describing each field present on the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueBean_schema? Schema { get; private set; }
#nullable restore
#else
        public IssueBean_schema Schema { get; private set; }
#endif
        /// <summary>The URL of the issue details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>The transitions that can be performed on the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<IssueTransition>? Transitions { get; private set; }
#nullable restore
#else
        public List<IssueTransition> Transitions { get; private set; }
#endif
        /// <summary>The versions of each field on the issue.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IssueBean_versionedRepresentations? VersionedRepresentations { get; private set; }
#nullable restore
#else
        public IssueBean_versionedRepresentations VersionedRepresentations { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static IssueBean CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IssueBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"changelog", n => { Changelog = n.GetObjectValue<PageOfChangelogs>(PageOfChangelogs.CreateFromDiscriminatorValue); } },
                {"editmeta", n => { Editmeta = n.GetObjectValue<IssueUpdateMetadata>(IssueUpdateMetadata.CreateFromDiscriminatorValue); } },
                {"expand", n => { Expand = n.GetStringValue(); } },
                {"fields", n => { Fields = n.GetObjectValue<IssueBean_fields>(IssueBean_fields.CreateFromDiscriminatorValue); } },
                {"fieldsToInclude", n => { FieldsToInclude = n.GetObjectValue<IncludedFields>(IncludedFields.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"key", n => { Key = n.GetStringValue(); } },
                {"names", n => { Names = n.GetObjectValue<IssueBean_names>(IssueBean_names.CreateFromDiscriminatorValue); } },
                {"operations", n => { Operations = n.GetObjectValue<AtlassianClient.Models.Operations>(AtlassianClient.Models.Operations.CreateFromDiscriminatorValue); } },
                {"properties", n => { Properties = n.GetObjectValue<IssueBean_properties>(IssueBean_properties.CreateFromDiscriminatorValue); } },
                {"renderedFields", n => { RenderedFields = n.GetObjectValue<IssueBean_renderedFields>(IssueBean_renderedFields.CreateFromDiscriminatorValue); } },
                {"schema", n => { Schema = n.GetObjectValue<IssueBean_schema>(IssueBean_schema.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"transitions", n => { Transitions = n.GetCollectionOfObjectValues<IssueTransition>(IssueTransition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"versionedRepresentations", n => { VersionedRepresentations = n.GetObjectValue<IssueBean_versionedRepresentations>(IssueBean_versionedRepresentations.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IssueBean_fields>("fields", Fields);
            writer.WriteObjectValue<IncludedFields>("fieldsToInclude", FieldsToInclude);
        }
    }
}