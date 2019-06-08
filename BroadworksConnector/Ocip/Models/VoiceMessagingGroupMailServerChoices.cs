using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingGroupMailServerChoices{
    [XmlEnum(Name = "System Mail Server")]
    SystemMailServer,
    [XmlEnum(Name = "Group Mail Server")]
    GroupMailServer,
 }
}
