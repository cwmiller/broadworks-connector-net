using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DeviceTypeConfigurationOptionType{
    [XmlEnum(Name = "Not Supported")]
    NotSupported,
    [XmlEnum(Name = "Device Management")]
    DeviceManagement,
    [XmlEnum(Name = "Legacy")]
    Legacy,
 }
}
