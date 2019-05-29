using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EnterpriseVoiceVPNPolicySelection{
    Private,
    Public,
    Route,
    Treatment,
 }
}
