// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace AtlassianClient.Models {
    /// <summary>The type of the assignee that is assigned to issues created with this component, when an assignee cannot be set from the `assigneeType`. For example, `assigneeType` is set to `COMPONENT_LEAD` but no component lead is set. This property is set to one of the following values: *  `PROJECT_LEAD` when `assigneeType` is `PROJECT_LEAD` and the project lead has permission to be assigned issues in the project that the component is in. *  `COMPONENT_LEAD` when `assignee`Type is `COMPONENT_LEAD` and the component lead has permission to be assigned issues in the project that the component is in. *  `UNASSIGNED` when `assigneeType` is `UNASSIGNED` and Jira is configured to allow unassigned issues. *  `PROJECT_DEFAULT` when none of the preceding cases are true.</summary>
    public enum ComponentWithIssueCount_realAssigneeType {
        [EnumMember(Value = "PROJECT_DEFAULT")]
        PROJECT_DEFAULT,
        [EnumMember(Value = "COMPONENT_LEAD")]
        COMPONENT_LEAD,
        [EnumMember(Value = "PROJECT_LEAD")]
        PROJECT_LEAD,
        [EnumMember(Value = "UNASSIGNED")]
        UNASSIGNED,
    }
}
