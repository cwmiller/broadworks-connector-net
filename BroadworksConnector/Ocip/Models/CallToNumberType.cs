using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallToNumberType{
    [XmlEnum(Name = "Primary")]
    Primary,
    [XmlEnum(Name = "Alternate1")]
    Alternate1,
    [XmlEnum(Name = "Alternate2")]
    Alternate2,
    [XmlEnum(Name = "Alternate3")]
    Alternate3,
    [XmlEnum(Name = "Alternate4")]
    Alternate4,
    [XmlEnum(Name = "Alternate5")]
    Alternate5,
    [XmlEnum(Name = "Alternate6")]
    Alternate6,
    [XmlEnum(Name = "Alternate7")]
    Alternate7,
    [XmlEnum(Name = "Alternate8")]
    Alternate8,
    [XmlEnum(Name = "Alternate9")]
    Alternate9,
    [XmlEnum(Name = "Alternate10")]
    Alternate10,
    [XmlEnum(Name = "BroadWorks Mobility")]
    BroadWorksMobility,
 }
}
