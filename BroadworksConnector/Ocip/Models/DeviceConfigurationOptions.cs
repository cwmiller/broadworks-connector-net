using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Device Configuration Options for a device Type.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum DeviceConfigurationOptions
    {
        [XmlEnum(Name = "Not Supported")]
        NotSupported,
        [XmlEnum(Name = "Device Management")]
        DeviceManagement,
        [XmlEnum(Name = "Legacy")]
        Legacy,
    }
}
