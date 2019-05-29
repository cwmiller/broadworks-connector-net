using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum EnhancedCallLogsCallLogsRequestType{
    Placed,
    Received,
    Missed,
    ReceivedOrMissed,
 }
}
