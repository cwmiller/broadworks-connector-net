using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RedirectingPresentationIndicator{
    [XmlEnum(Name = "Anonymous")]
    Anonymous,
    [XmlEnum(Name = "Anonymous Name")]
    AnonymousName,
    [XmlEnum(Name = "Anonymous URI")]
    AnonymousURI,
    [XmlEnum(Name = "Public")]
    Public,
 }
}
