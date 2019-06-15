using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies at which level in the system an identity/device profile is created.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccessDeviceLevel    {
            [XmlEnum(Name = "System")]
        System,
            [XmlEnum(Name = "Service Provider")]
        ServiceProvider,
            [XmlEnum(Name = "Group")]
        Group,
     }
}
