// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace AtlassianClient.Models {
    /// <summary>The nominal user type used to determine the assignee for issues created with this component. See `realAssigneeType` for details on how the type of the user, and hence the user, assigned to issues is determined. Takes the following values: *  `PROJECT_LEAD` the assignee to any issues created with this component is nominally the lead for the project the component is in. *  `COMPONENT_LEAD` the assignee to any issues created with this component is nominally the lead for the component. *  `UNASSIGNED` an assignee is not set for issues created with this component. *  `PROJECT_DEFAULT` the assignee to any issues created with this component is nominally the default assignee for the project that the component is in.</summary>
    public enum ComponentWithIssueCount_assigneeType {
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
