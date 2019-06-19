using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the access device configuration mode.
    /// </summary>
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
