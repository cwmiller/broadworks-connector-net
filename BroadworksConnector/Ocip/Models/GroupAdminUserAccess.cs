using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to user configuration.
    /// "Full" indicates full access to users in the group.
    /// "Full Profile" indicates
    /// 1) the group administrator is restricted from adding or removing users, but
    /// 2) has full access to the user's profile
    /// "Read-Only Profile" indicates
    /// 1) the group administrator is restricted from adding or removing users, and
    /// 2) read-only access is granted to the user's profile.
    /// "No Profile" indicates
    /// 1) the group administrator is restricted from adding or removing users, and
    /// 2) no access is granted to the user's profile.
    /// "None" indicates no access to users in the group.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminUserAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Full Profile")]
        FullProfile,
        [XmlEnum(Name = "Read-Only Profile")]
        ReadOnlyProfile,
        [XmlEnum(Name = "No Profile")]
        NoProfile,
        [XmlEnum(Name = "None")]
        None,
    }
}
