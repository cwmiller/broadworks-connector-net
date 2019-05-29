using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum ServicePackMigrationTaskStatus21{
    AwaitingEdits,
    Pending,
    Processing,
    Terminating,
    Terminated,
    StoppedBySystem,
    Completed,
    Expired,
 }
}
