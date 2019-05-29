using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum SIPACLTransportProtocol{
    UDP,
    TCP,
    All,
 }
}
