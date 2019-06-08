using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GETSCallIdentifierMode{
    [XmlEnum(Name = "Request-URI")]
    RequestURI,
    [XmlEnum(Name = "RPH")]
    RPH,
    [XmlEnum(Name = "RPH-Request-URI")]
    RPHRequestURI,
 }
}
