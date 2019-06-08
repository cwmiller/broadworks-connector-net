using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CommPilotExpressVoiceMailGreeting{
    [XmlEnum(Name = "No Answer")]
    NoAnswer,
    [XmlEnum(Name = "Unavailable")]
    Unavailable,
 }
}
