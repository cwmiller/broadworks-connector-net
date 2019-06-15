using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the group Dial Plan Policy to decide which type of settings shall be used.
    /// Notes: Choice cannot be 'sp' or 'group' if Service Provider or group does not have
    /// public digit map set.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupDialPlanPolicySettingLevel    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
