using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ExecutiveAlertingCallingLineIdNameMode{
    [XmlEnum(Name = "Executive")]
    Executive,
    [XmlEnum(Name = "Executive-Originator")]
    ExecutiveOriginator,
    [XmlEnum(Name = "Originator-Executive")]
    OriginatorExecutive,
    [XmlEnum(Name = "Originator")]
    Originator,
    [XmlEnum(Name = "Custom")]
    Custom,
 }
}
