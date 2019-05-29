using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum AgentACDState{
    SignIn,
    SignOut,
    Available,
    Unavailable,
    WrapUp,
 }
}
