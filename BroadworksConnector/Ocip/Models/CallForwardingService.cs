using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallForwardingService{
    CallForwardingAlways,
    CallForwardingAlwaysSecondary,
    CallForwardingBusy,
    CallForwardingNoAnswer,
    CallForwardingNotReachable,
    CallForwardingSelective,
 }
}
