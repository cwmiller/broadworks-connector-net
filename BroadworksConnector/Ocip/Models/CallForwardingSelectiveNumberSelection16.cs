using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CallForwardingSelectiveNumberSelection16{
    ForwardToDefaultNumber,
    ForwardToSpecifiedNumber,
    Donotforward,
 }
}
