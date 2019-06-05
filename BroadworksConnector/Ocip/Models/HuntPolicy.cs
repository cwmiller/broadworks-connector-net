using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum HuntPolicy{
    [XmlEnum(Name = "Circular")]
    Circular,
    [XmlEnum(Name = "Regular")]
    Regular,
    [XmlEnum(Name = "Simultaneous")]
    Simultaneous,
    [XmlEnum(Name = "Uniform")]
    Uniform,
    [XmlEnum(Name = "Weighted")]
    Weighted,
 }
}
