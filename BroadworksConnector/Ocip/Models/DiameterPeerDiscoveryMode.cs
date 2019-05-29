using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DiameterPeerDiscoveryMode{
    Legacy,
    Rfc6733Any,
    Rfc6733TLSOnly,
    Rfc6733TCPOnly,
 }
}
