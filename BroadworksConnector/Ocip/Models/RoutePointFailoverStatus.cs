using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RoutePointFailoverStatus{
    [XmlEnum(Name = "Normal")]
    Normal,
    [XmlEnum(Name = "Failover")]
    Failover,
 }
}
