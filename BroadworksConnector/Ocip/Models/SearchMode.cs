using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SearchMode{
    [XmlEnum(Name = "Starts With")]
    StartsWith,
    [XmlEnum(Name = "Contains")]
    Contains,
    [XmlEnum(Name = "Equal To")]
    EqualTo,
 }
}
