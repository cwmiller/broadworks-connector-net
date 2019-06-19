using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Type of enhanced configuration supported by an access device.
    /// "2 File Configuration" was formerly called "CPE Type 1"
    /// "3 File Configuration" was formerly called "CPE Type 2"
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AccessDeviceEnhancedConfigurationType14
    {
        [XmlEnum(Name = "2 File Configuration")]
        _2FileConfiguration,
        [XmlEnum(Name = "3 File Configuration")]
        _3FileConfiguration,
        [XmlEnum(Name = "SNAP")]
        SNAP,
    }
}
