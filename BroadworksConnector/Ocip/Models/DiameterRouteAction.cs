using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DiameterRouteAction{
    [XmlEnum(Name = "Local")]
    Local,
    [XmlEnum(Name = "Relay")]
    Relay,
 }
}
