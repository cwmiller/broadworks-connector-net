using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EnterpriseTrunkOrderingAlgorithm{
    [XmlEnum(Name = "Ordered Load Balancing")]
    OrderedLoadBalancing,
    [XmlEnum(Name = "Overflow")]
    Overflow,
    [XmlEnum(Name = "Most Idle")]
    MostIdle,
    [XmlEnum(Name = "Least Idle")]
    LeastIdle,
 }
}
