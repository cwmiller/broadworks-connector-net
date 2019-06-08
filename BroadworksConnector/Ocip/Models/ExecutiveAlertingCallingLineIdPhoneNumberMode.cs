using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ExecutiveAlertingCallingLineIdPhoneNumberMode{
    [XmlEnum(Name = "Executive")]
    Executive,
    [XmlEnum(Name = "Originator")]
    Originator,
    [XmlEnum(Name = "Custom")]
    Custom,
 }
}
