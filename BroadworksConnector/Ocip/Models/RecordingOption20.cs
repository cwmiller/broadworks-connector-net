using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RecordingOption20{
    [XmlEnum(Name = "Always")]
    Always,
    [XmlEnum(Name = "Never")]
    Never,
    [XmlEnum(Name = "On Demand")]
    OnDemand,
    [XmlEnum(Name = "Always with Pause/Resume")]
    AlwayswithPauseResume,
    [XmlEnum(Name = "On Demand with User Initiated Start")]
    OnDemandwithUserInitiatedStart,
 }
}
