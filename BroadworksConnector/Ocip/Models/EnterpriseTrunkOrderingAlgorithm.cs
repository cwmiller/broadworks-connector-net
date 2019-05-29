using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EnterpriseTrunkOrderingAlgorithm{
    OrderedLoadBalancing,
    Overflow,
    MostIdle,
    LeastIdle,
 }
}
