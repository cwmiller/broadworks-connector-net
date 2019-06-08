using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SMPPVersion{
    [XmlEnum(Name = "3.3")]
    _33,
    [XmlEnum(Name = "3.4")]
    _34,
    [XmlEnum(Name = "5.0")]
    _50,
 }
}
