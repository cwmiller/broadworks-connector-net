using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
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
