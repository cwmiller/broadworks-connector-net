using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum LineOrderingTaskStatus{
    [XmlEnum(Name = "NotStarted")]
    NotStarted,
    [XmlEnum(Name = "Pending")]
    Pending,
    [XmlEnum(Name = "Processing")]
    Processing,
 }
}
