using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum DeviceManagementEventStatusInProgressOrPending{
    Pending,
    Queued,
    InProgress,
    ProcessOnOtherHost,
    Stale,
 }
}
