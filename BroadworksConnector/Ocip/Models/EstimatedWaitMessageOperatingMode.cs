using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum EstimatedWaitMessageOperatingMode{
    [XmlEnum(Name = "Position")]
    Position,
    [XmlEnum(Name = "Time")]
    Time,
 }
}
