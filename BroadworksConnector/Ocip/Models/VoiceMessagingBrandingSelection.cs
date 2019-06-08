using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingBrandingSelection{
    [XmlEnum(Name = "Default")]
    Default,
    [XmlEnum(Name = "Branded")]
    Branded,
 }
}
