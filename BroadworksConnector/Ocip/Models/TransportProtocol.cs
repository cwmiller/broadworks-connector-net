using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TransportProtocol{
    UDP,
    TCP,
    Unspecified,
 }
}
