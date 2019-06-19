using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to departments.
    /// "Full" indicates full access to departments.
    /// "Read-Only" indicates read-only access to the department list
    /// "None" indicates no access to the department list
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminDepartmentAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only")]
        ReadOnly,
        [XmlEnum(Name = "None")]
        None,
    }
}
