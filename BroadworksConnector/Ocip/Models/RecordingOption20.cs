using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Recording Service Configuration option.  The Always with Pause/Resume,
    /// On Demand, and On Demand with User Initiated Start option are not
    /// applicable for Service Users.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RecordingOption20    {
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
