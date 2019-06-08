using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum DeviceManagementEventStatusForCancel{
    [XmlEnum(Name = "Pending")]
    Pending,
    [XmlEnum(Name = "Queued")]
    Queued,
    [XmlEnum(Name = "In Progress")]
    InProgress,
    [XmlEnum(Name = "Stale")]
    Stale,
 }
}
