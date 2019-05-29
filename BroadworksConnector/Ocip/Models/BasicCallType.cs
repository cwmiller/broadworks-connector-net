using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum BasicCallType{
    Group,
    Enterprise,
    Network,
    NetworkURL,
    Repair,
    Emergency,
 }
}
