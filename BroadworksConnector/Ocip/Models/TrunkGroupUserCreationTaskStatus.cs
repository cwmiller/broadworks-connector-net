using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum TrunkGroupUserCreationTaskStatus{
    Pending,
    Processing,
    Completed,
    Failed,
 }
}
