using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccessDeviceEnhancedConfigurationMode
    {
        [XmlEnum(Name = "Default")]
        Default,
        [XmlEnum(Name = "Manual")]
        Manual,
        [XmlEnum(Name = "Custom")]
        Custom,
    }
}
