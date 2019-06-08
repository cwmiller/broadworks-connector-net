using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
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
