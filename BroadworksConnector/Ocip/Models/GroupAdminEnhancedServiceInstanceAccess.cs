using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Policy for a group administrator's access to enhanced service instances (e.g. - instances of Auto Attendants, Call Capacity Groups,
    /// Conference Bridges, Hunt Groups, Call Centers, Series Completion Groups, etc.).
    /// "Full" indicates full access to enhanced service instances.
    /// "Modify-Only" indicates
    /// 1) the group administrator is restricted from adding or removing enhanced service instances, but
    /// 2) may modify existing instances.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupAdminEnhancedServiceInstanceAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Modify-Only")]
        ModifyOnly,
     }
}
