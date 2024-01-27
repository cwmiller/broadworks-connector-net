using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Recording Service Configuration option.  The Always with Pause/Resume,
    /// On Demand, On Demand with User Initiated Start, Always Start On Demand Keep
    /// and On Demand Keep Always Start options are not applicable for Service Users.
    /// 
    /// The following elements are only used in AS data mode and are ignored in XS data mode:
    /// Always
    /// On Demand
    /// Always with Pause/Resume
    /// On Demand with User Initiated Start
    /// 
    /// The following elements are only used in XS data mode and are ignored in AS data mode:
    /// Always Start Always Keep
    /// Always Start On Demand Keep
    /// On Demand Start Always Keep
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RecordingOption22
    {
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
        [XmlEnum(Name = "Always Start Always Keep")]
        AlwaysStartAlwaysKeep,
        [XmlEnum(Name = "Always Start On Demand Keep")]
        AlwaysStartOnDemandKeep,
        [XmlEnum(Name = "On Demand Start Always Keep")]
        OnDemandStartAlwaysKeep,
    }
}
