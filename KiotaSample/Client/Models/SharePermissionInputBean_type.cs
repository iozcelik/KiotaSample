// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace AtlassianClient.Models {
    /// <summary>The type of the share permission.Specify the type as follows: *  `user` Share with a user. *  `group` Share with a group. Specify `groupname` as well. *  `project` Share with a project. Specify `projectId` as well. *  `projectRole` Share with a project role in a project. Specify `projectId` and `projectRoleId` as well. *  `global` Share globally, including anonymous users. If set, this type overrides all existing share permissions and must be deleted before any non-global share permissions is set. *  `authenticated` Share with all logged-in users. This shows as `loggedin` in the response. If set, this type overrides all existing share permissions and must be deleted before any non-global share permissions is set.</summary>
    public enum SharePermissionInputBean_type {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "project")]
        Project,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "projectRole")]
        ProjectRole,
        [EnumMember(Value = "global")]
        Global,
        [EnumMember(Value = "authenticated")]
        Authenticated,
    }
}
