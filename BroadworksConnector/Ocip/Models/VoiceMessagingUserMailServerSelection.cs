using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingUserMailServerSelection{
    [XmlEnum(Name = "Group Mail Server")]
    GroupMailServer,
    [XmlEnum(Name = "Personal Mail Server")]
    PersonalMailServer,
 }
}
