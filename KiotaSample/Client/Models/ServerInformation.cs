// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Details about the Jira instance.
    /// </summary>
    public class ServerInformation : IParsable {
        /// <summary>The base URL of the Jira instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? BaseUrl { get; set; }
#nullable restore
#else
        public string BaseUrl { get; set; }
#endif
        /// <summary>The timestamp when the Jira version was built.</summary>
        public DateTimeOffset? BuildDate { get; set; }
        /// <summary>The build number of the Jira version.</summary>
        public int? BuildNumber { get; set; }
        /// <summary>The type of server deployment. This is always returned as *Cloud*.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DeploymentType { get; set; }
#nullable restore
#else
        public string DeploymentType { get; set; }
#endif
        /// <summary>Jira instance health check results. Deprecated and no longer returned.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<HealthCheckResult>? HealthChecks { get; set; }
#nullable restore
#else
        public List<HealthCheckResult> HealthChecks { get; set; }
#endif
        /// <summary>The unique identifier of the Jira version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ScmInfo { get; set; }
#nullable restore
#else
        public string ScmInfo { get; set; }
#endif
        /// <summary>The time in Jira when this request was responded to.</summary>
        public DateTimeOffset? ServerTime { get; set; }
        /// <summary>The default timezone of the Jira server. In a format known as Olson Time Zones, IANA Time Zones or TZ Database Time Zones.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ServerInformation_serverTimeZone? ServerTimeZone { get; set; }
#nullable restore
#else
        public ServerInformation_serverTimeZone ServerTimeZone { get; set; }
#endif
        /// <summary>The name of the Jira instance.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? ServerTitle { get; set; }
#nullable restore
#else
        public string ServerTitle { get; set; }
#endif
        /// <summary>The version of Jira.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Version { get; set; }
#nullable restore
#else
        public string Version { get; set; }
#endif
        /// <summary>The major, minor, and revision version numbers of the Jira version.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<int?>? VersionNumbers { get; set; }
#nullable restore
#else
        public List<int?> VersionNumbers { get; set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ServerInformation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ServerInformation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"baseUrl", n => { BaseUrl = n.GetStringValue(); } },
                {"buildDate", n => { BuildDate = n.GetDateTimeOffsetValue(); } },
                {"buildNumber", n => { BuildNumber = n.GetIntValue(); } },
                {"deploymentType", n => { DeploymentType = n.GetStringValue(); } },
                {"healthChecks", n => { HealthChecks = n.GetCollectionOfObjectValues<HealthCheckResult>(HealthCheckResult.CreateFromDiscriminatorValue)?.ToList(); } },
                {"scmInfo", n => { ScmInfo = n.GetStringValue(); } },
                {"serverTime", n => { ServerTime = n.GetDateTimeOffsetValue(); } },
                {"serverTimeZone", n => { ServerTimeZone = n.GetObjectValue<ServerInformation_serverTimeZone>(ServerInformation_serverTimeZone.CreateFromDiscriminatorValue); } },
                {"serverTitle", n => { ServerTitle = n.GetStringValue(); } },
                {"version", n => { Version = n.GetStringValue(); } },
                {"versionNumbers", n => { VersionNumbers = n.GetCollectionOfPrimitiveValues<int?>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("baseUrl", BaseUrl);
            writer.WriteDateTimeOffsetValue("buildDate", BuildDate);
            writer.WriteIntValue("buildNumber", BuildNumber);
            writer.WriteStringValue("deploymentType", DeploymentType);
            writer.WriteCollectionOfObjectValues<HealthCheckResult>("healthChecks", HealthChecks);
            writer.WriteStringValue("scmInfo", ScmInfo);
            writer.WriteDateTimeOffsetValue("serverTime", ServerTime);
            writer.WriteObjectValue<ServerInformation_serverTimeZone>("serverTimeZone", ServerTimeZone);
            writer.WriteStringValue("serverTitle", ServerTitle);
            writer.WriteStringValue("version", Version);
            writer.WriteCollectionOfPrimitiveValues<int?>("versionNumbers", VersionNumbers);
        }
    }
}
