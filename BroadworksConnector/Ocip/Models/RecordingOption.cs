using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RecordingOption{
    [XmlEnum(Name = "Always")]
    Always,
    [XmlEnum(Name = "Never")]
    Never,
    [XmlEnum(Name = "On Demand")]
    OnDemand,
 }
}
