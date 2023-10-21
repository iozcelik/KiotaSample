// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about a workflow.
    /// </summary>
    public class DeprecatedWorkflow : IParsable {
        /// <summary>The default property</summary>
        public bool? Default { get; set; }
        /// <summary>The description of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; private set; }
#nullable restore
#else
        public string Description { get; private set; }
#endif
        /// <summary>The datetime the workflow was last modified.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedDate { get; private set; }
#nullable restore
#else
        public string LastModifiedDate { get; private set; }
#endif
        /// <summary>This property is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedUser { get; private set; }
#nullable restore
#else
        public string LastModifiedUser { get; private set; }
#endif
        /// <summary>The account ID of the user that last modified the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? LastModifiedUserAccountId { get; private set; }
#nullable restore
#else
        public string LastModifiedUserAccountId { get; private set; }
#endif
        /// <summary>The name of the workflow.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>The scope where this workflow applies</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.Scope? Scope { get; private set; }
#nullable restore
#else
        public AtlassianClient.Models.Scope Scope { get; private set; }
#endif
        /// <summary>The number of steps included in the workflow.</summary>
        public int? Steps { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeprecatedWorkflow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeprecatedWorkflow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"default", n => { Default = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"lastModifiedDate", n => { LastModifiedDate = n.GetStringValue(); } },
                {"lastModifiedUser", n => { LastModifiedUser = n.GetStringValue(); } },
                {"lastModifiedUserAccountId", n => { LastModifiedUserAccountId = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<AtlassianClient.Models.Scope>(AtlassianClient.Models.Scope.CreateFromDiscriminatorValue); } },
                {"steps", n => { Steps = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("default", Default);
        }
    }
}
