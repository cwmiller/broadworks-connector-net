using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for department administrator's access to user configuration.
    /// "Full" indicates full access to users in the department.
    /// "Read-Only Profile" indicates
    /// 1) the department administrator is restricted from adding or removing users, and
    /// 2) read-only access is granted to the user's profile.
    /// "No Profile" indicates
    /// 1) the department administrator is restricted from adding or removing users, and
    /// 2) no access is granted to the user's profile.
    /// "None" indicates no access to users in the department.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupDepartmentAdminUserAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Read-Only Profile")]
        ReadOnlyProfile,
        [XmlEnum(Name = "No Profile")]
        NoProfile,
        [XmlEnum(Name = "None")]
        None,
    }
}
