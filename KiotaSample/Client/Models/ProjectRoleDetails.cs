// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about a project role.
    /// </summary>
    public class ProjectRoleDetails : IParsable {
        /// <summary>Whether this role is the admin role for the project.</summary>
        public bool? Admin { get; private set; }
        /// <summary>Whether this role is the default role for the project.</summary>
        public bool? Default { get; private set; }
        /// <summary>The description of the project role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Description { get; private set; }
#nullable restore
#else
        public string Description { get; private set; }
#endif
        /// <summary>The ID of the project role.</summary>
        public long? Id { get; private set; }
        /// <summary>The name of the project role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; set; }
#nullable restore
#else
        public string Name { get; set; }
#endif
        /// <summary>Whether the roles are configurable for this project.</summary>
        public bool? RoleConfigurable { get; private set; }
        /// <summary>The scope of the role. Indicated for roles associated with [next-gen projects](https://confluence.atlassian.com/x/loMyO).</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public AtlassianClient.Models.Scope? Scope { get; private set; }
#nullable restore
#else
        public AtlassianClient.Models.Scope Scope { get; private set; }
#endif
        /// <summary>The URL the project role details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Self { get; private set; }
#nullable restore
#else
        public string Self { get; private set; }
#endif
        /// <summary>The translated name of the project role.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TranslatedName { get; set; }
#nullable restore
#else
        public string TranslatedName { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ProjectRoleDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ProjectRoleDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"admin", n => { Admin = n.GetBoolValue(); } },
                {"default", n => { Default = n.GetBoolValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"roleConfigurable", n => { RoleConfigurable = n.GetBoolValue(); } },
                {"scope", n => { Scope = n.GetObjectValue<AtlassianClient.Models.Scope>(AtlassianClient.Models.Scope.CreateFromDiscriminatorValue); } },
                {"self", n => { Self = n.GetStringValue(); } },
                {"translatedName", n => { TranslatedName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteStringValue("translatedName", TranslatedName);
        }
    }
}
