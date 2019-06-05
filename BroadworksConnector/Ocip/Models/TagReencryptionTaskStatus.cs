using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TagReencryptionTaskStatus{
    [XmlEnum(Name = "Not Started")]
    NotStarted,
    [XmlEnum(Name = "Processing")]
    Processing,
 }
}
