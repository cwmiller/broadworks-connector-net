using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
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
