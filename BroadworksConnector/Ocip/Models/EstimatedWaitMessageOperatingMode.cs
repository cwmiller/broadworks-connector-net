using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The type of estimated wait message that is played.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EstimatedWaitMessageOperatingMode
    {
        [XmlEnum(Name = "Position")]
        Position,
        [XmlEnum(Name = "Time")]
        Time,
    }
}
