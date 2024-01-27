using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies at which level in the system the identity/device profiles are created.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoCreateDevicesLevel
    {
        [XmlEnum(Name = "Auto Creation Not Used")]
        AutoCreationNotUsed,
        [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
