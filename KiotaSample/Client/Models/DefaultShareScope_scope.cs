// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace AtlassianClient.Models {
    /// <summary>The scope of the default sharing for new filters and dashboards: *  `AUTHENTICATED` Shared with all logged-in users. *  `GLOBAL` Shared with all logged-in users. This shows as `AUTHENTICATED` in the response. *  `PRIVATE` Not shared with any users.</summary>
    public enum DefaultShareScope_scope {
        [EnumMember(Value = "GLOBAL")]
        GLOBAL,
        [EnumMember(Value = "AUTHENTICATED")]
        AUTHENTICATED,
        [EnumMember(Value = "PRIVATE")]
        PRIVATE,
    }
}
