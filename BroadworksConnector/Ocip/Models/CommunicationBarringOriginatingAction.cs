using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CommunicationBarringOriginatingAction{
    Allow,
    AllowTimed,
    Block,
    AuthorizationCode,
    AuthorizationCodeTimed,
    Treatment,
    Transfer,
 }
}
