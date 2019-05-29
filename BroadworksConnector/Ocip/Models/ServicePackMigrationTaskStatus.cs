using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServicePackMigrationTaskStatus{
    AwaitingEdits,
    Pending,
    Processing,
    Terminating,
    Terminated,
    StoppedBySystem,
    Completed,
 }
}
