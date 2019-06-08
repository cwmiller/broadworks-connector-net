using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AgentACDAutomaticState{
    [XmlEnum(Name = "Available")]
    Available,
    [XmlEnum(Name = "Unavailable")]
    Unavailable,
    [XmlEnum(Name = "Wrap-Up")]
    WrapUp,
 }
}
