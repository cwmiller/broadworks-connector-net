using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AccessDeviceStatus{
    [XmlEnum(Name = "Online")]
    Online,
    [XmlEnum(Name = "Offline")]
    Offline,
    [XmlEnum(Name = "Unavailable")]
    Unavailable,
    [XmlEnum(Name = "Unknown")]
    Unknown,
 }
}
