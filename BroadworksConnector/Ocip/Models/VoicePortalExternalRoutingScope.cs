using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoicePortalExternalRoutingScope{
    [XmlEnum(Name = "System")]
    System,
    [XmlEnum(Name = "Group")]
    Group,
 }
}
