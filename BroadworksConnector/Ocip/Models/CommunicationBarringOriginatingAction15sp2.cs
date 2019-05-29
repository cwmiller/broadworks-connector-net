using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CommunicationBarringOriginatingAction15sp2{
    Allow,
    Block,
    AuthorizationCode,
    Treatment,
    Transfer,
 }
}
