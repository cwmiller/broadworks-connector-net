using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PresentationIndicator{
    [XmlEnum(Name = "Anonymous")]
    Anonymous,
    [XmlEnum(Name = "Anonymous Name")]
    AnonymousName,
    [XmlEnum(Name = "Anonymous URI")]
    AnonymousURI,
    [XmlEnum(Name = "Anonymous Unavailable")]
    AnonymousUnavailable,
    [XmlEnum(Name = "Public")]
    Public,
    [XmlEnum(Name = "Unavailable")]
    Unavailable,
 }
}
