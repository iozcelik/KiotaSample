// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about a user assigned to a project role.
    /// </summary>
    public class RoleActor : IParsable {
        /// <summary>The actorGroup property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProjectRoleGroup? ActorGroup { get; private set; }
#nullable restore
#else
        public ProjectRoleGroup ActorGroup { get; private set; }
#endif
        /// <summary>The actorUser property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ProjectRoleUser? ActorUser { get; private set; }
#nullable restore
#else
        public ProjectRoleUser ActorUser { get; private set; }
#endif
        /// <summary>The avatar of the role actor.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AvatarUrl { get; private set; }
#nullable restore
#else
        public string AvatarUrl { get; private set; }
#endif
        /// <summary>The display name of the role actor. For users, depending on the user’s privacy setting, this may return an alternative value for the user&apos;s name.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName { get; private set; }
#nullable restore
#else
        public string DisplayName { get; private set; }
#endif
        /// <summary>The ID of the role actor.</summary>
        public long? Id { get; private set; }
        /// <summary>This property is no longer available and will be removed from the documentation soon. See the [deprecation notice](https://developer.atlassian.com/cloud/jira/platform/deprecation-notice-user-privacy-api-migration-guide/) for details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Name { get; private set; }
#nullable restore
#else
        public string Name { get; private set; }
#endif
        /// <summary>The type of role actor.</summary>
        public RoleActor_type? Type { get; private set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static RoleActor CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleActor();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"actorGroup", n => { ActorGroup = n.GetObjectValue<ProjectRoleGroup>(ProjectRoleGroup.CreateFromDiscriminatorValue); } },
                {"actorUser", n => { ActorUser = n.GetObjectValue<ProjectRoleUser>(ProjectRoleUser.CreateFromDiscriminatorValue); } },
                {"avatarUrl", n => { AvatarUrl = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetLongValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"type", n => { Type = n.GetEnumValue<RoleActor_type>(); } },
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
