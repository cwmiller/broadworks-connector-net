using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderInternalCallsCLIDPolicy{
    [XmlEnum(Name = "Use Extension")]
    UseExtension,
    [XmlEnum(Name = "Use External Calls Policy")]
    UseExternalCallsPolicy,
 }
}
