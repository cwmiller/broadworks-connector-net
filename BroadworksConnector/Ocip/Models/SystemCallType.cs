using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemCallType{
    [XmlEnum(Name = "Emergency")]
    Emergency,
    [XmlEnum(Name = "Repair")]
    Repair,
 }
}
