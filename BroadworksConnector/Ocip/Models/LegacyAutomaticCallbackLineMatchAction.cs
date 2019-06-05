using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum LegacyAutomaticCallbackLineMatchAction{
    [XmlEnum(Name = "Accept")]
    Accept,
    [XmlEnum(Name = "Deny")]
    Deny,
 }
}
