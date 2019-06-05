using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum OrganizationType{
    [XmlEnum(Name = "Service Provider")]
    ServiceProvider,
    [XmlEnum(Name = "Enterprise")]
    Enterprise,
 }
}
