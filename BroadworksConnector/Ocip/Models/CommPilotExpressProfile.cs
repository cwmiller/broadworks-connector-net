using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum CommPilotExpressProfile{
    AvailableInOffice,
    AvailableOutOfOffice,
    Busy,
    Unavailable,
 }
}
