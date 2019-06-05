using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupUserCreationTaskStatus{
    [XmlEnum(Name = "Pending")]
    Pending,
    [XmlEnum(Name = "Processing")]
    Processing,
    [XmlEnum(Name = "Completed")]
    Completed,
    [XmlEnum(Name = "Failed")]
    Failed,
 }
}
