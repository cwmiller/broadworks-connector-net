using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the device type configuration mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceTypeFileEnhancedConfigurationMode    {
            [XmlEnum(Name = "Manual")]
        Manual,
            [XmlEnum(Name = "Custom")]
        Custom,
     }
}
