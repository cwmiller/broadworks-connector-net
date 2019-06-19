using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Identifies at which level in the system an identity/device profile type is created.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceTypeLevel
    {
        [XmlEnum(Name = "System")]
        System,
        [XmlEnum(Name = "Reseller")]
        Reseller,
    }
}
