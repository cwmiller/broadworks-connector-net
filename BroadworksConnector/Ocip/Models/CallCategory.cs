using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallCategory{
    [XmlEnum(Name = "Local")]
    Local,
    [XmlEnum(Name = "National")]
    National,
    [XmlEnum(Name = "Interlata")]
    Interlata,
    [XmlEnum(Name = "Intralata")]
    Intralata,
    [XmlEnum(Name = "International")]
    International,
    [XmlEnum(Name = "Private")]
    Private,
    [XmlEnum(Name = "Emergency")]
    Emergency,
    [XmlEnum(Name = "Other")]
    Other,
 }
}
