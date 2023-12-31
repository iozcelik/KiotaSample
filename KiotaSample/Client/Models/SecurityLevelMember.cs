// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Issue security level member.
    /// </summary>
    public class SecurityLevelMember : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The user or group being granted the permission. It consists of a `type` and a type-dependent `parameter`. See [Holder object](../api-group-permission-schemes/#holder-object) in *Get all permission schemes* for more information.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public PermissionHolder? Holder { get; private set; }
#nullable restore
#else
        public PermissionHolder Holder { get; private set; }
#endif
        /// <summary>The ID of the issue security level member.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The ID of the issue security level.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueSecurityLevelId { get; private set; }
#nullable restore
#else
        public string IssueSecurityLevelId { get; private set; }
#endif
        /// <summary>The ID of the issue security scheme.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? IssueSecuritySchemeId { get; private set; }
#nullable restore
#else
        public string IssueSecuritySchemeId { get; private set; }
#endif
        /// <summary>The managed property</summary>
        public bool? Managed { get; set; }
        /// <summary>
        /// Instantiates a new SecurityLevelMember and sets the default values.
        /// </summary>
        public SecurityLevelMember() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SecurityLevelMember CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SecurityLevelMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"holder", n => { Holder = n.GetObjectValue<PermissionHolder>(PermissionHolder.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"issueSecurityLevelId", n => { IssueSecurityLevelId = n.GetStringValue(); } },
                {"issueSecuritySchemeId", n => { IssueSecuritySchemeId = n.GetStringValue(); } },
                {"managed", n => { Managed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("managed", Managed);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
