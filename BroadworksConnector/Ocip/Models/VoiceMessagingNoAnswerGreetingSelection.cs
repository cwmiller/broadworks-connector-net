using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingNoAnswerGreetingSelection{
    [XmlEnum(Name = "Default")]
    Default,
    [XmlEnum(Name = "Personal")]
    Personal,
    [XmlEnum(Name = "Alternate01")]
    Alternate01,
    [XmlEnum(Name = "Alternate02")]
    Alternate02,
    [XmlEnum(Name = "Alternate03")]
    Alternate03,
 }
}
