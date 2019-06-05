using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemVoicePortalScope{
    [XmlEnum(Name = "Service Provider")]
    ServiceProvider,
    [XmlEnum(Name = "System")]
    System,
 }
}
