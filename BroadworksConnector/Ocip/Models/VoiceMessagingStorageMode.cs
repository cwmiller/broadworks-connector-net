using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingStorageMode{
    [XmlEnum(Name = "Cloud")]
    Cloud,
    [XmlEnum(Name = "Mail Server")]
    MailServer,
 }
}
