using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum IMSUserState{
    NotRegistered,
    Registered,
    RegisteredUnRegServices,
    AuthenticationPending,
 }
}
