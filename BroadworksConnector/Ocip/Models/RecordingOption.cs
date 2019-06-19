using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Recording Service Configuration.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum RecordingOption
    {
        [XmlEnum(Name = "Always")]
        Always,
        [XmlEnum(Name = "Never")]
        Never,
        [XmlEnum(Name = "On Demand")]
        OnDemand,
    }
}
