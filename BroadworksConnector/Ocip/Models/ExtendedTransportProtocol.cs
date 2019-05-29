using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ExtendedTransportProtocol{
    UDP,
    TCP,
    TLS,
    Unspecified,
 }
}
