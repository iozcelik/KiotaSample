// <auto-generated/>
using System.Runtime.Serialization;
using System;
namespace AtlassianClient.Models {
    /// <summary>An absolute position in which to place the moved version. Cannot be used with `after`.</summary>
    public enum VersionMoveBean_position {
        [EnumMember(Value = "Earlier")]
        Earlier,
        [EnumMember(Value = "Later")]
        Later,
        [EnumMember(Value = "First")]
        First,
        [EnumMember(Value = "Last")]
        Last,
    }
}