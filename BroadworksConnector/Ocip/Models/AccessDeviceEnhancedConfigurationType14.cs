using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AccessDeviceEnhancedConfigurationType14{
    [XmlEnum(Name = "2 File Configuration")]
    _2FileConfiguration,
    [XmlEnum(Name = "3 File Configuration")]
    _3FileConfiguration,
    [XmlEnum(Name = "SNAP")]
    SNAP,
 }
}
