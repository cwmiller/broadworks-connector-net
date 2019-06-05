using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum VoiceMessagingMailServerProtocol{
    [XmlEnum(Name = "POP3")]
    POP3,
    [XmlEnum(Name = "IMAP")]
    IMAP,
 }
}
