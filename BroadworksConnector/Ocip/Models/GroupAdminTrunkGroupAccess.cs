using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to trunk groups.
    /// "Full" indicates full access to add/modify/delete trunk groups in the group.
    /// "Full Resources" indicates
    /// 1) Restricted from adding or removing trunk groups, and
    /// 2) Full access to trunk group resources
    /// "Read-Only Resources" indicates
    /// 1) Restricted from adding or removing trunk groups, and
    /// 2) Read-only access to trunk group resources
    /// "None" indicates no access to trunk groups in the group.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminTrunkGroupAccess
    {
        [XmlEnum(Name = "Full")]
        Full,
        [XmlEnum(Name = "Full Resources")]
        FullResources,
        [XmlEnum(Name = "Read-Only Resources")]
        ReadOnlyResources,
        [XmlEnum(Name = "None")]
        None,
    }
}
