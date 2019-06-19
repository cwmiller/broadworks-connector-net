using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group Administrator type
    /// "Group" indicates the group admin is a group admin.
    /// "Department" indicates the group admin is a department admin.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminType
    {
        [XmlEnum(Name = "Group")]
        Group,
        [XmlEnum(Name = "Department")]
        Department,
    }
}
