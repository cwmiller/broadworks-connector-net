using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderVoicePortalScope{
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "Service Provider")]
    ServiceProvider,
 }
}
