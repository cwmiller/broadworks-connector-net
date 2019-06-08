using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCenterMediaOnHoldMessageSelection{
    [XmlEnum(Name = "Default")]
    Default,
    [XmlEnum(Name = "URL")]
    URL,
    [XmlEnum(Name = "Custom")]
    Custom,
    [XmlEnum(Name = "External")]
    External,
 }
}
