using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DeviceManagementEventStatusInProgressOrPending{
    [XmlEnum(Name = "Pending")]
    Pending,
    [XmlEnum(Name = "Queued")]
    Queued,
    [XmlEnum(Name = "In Progress")]
    InProgress,
    [XmlEnum(Name = "Process On Other Host")]
    ProcessOnOtherHost,
    [XmlEnum(Name = "Stale")]
    Stale,
 }
}
