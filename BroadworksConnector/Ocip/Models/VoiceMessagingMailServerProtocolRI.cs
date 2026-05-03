using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Protocol used by mail server holding voice messages
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingMailServerProtocolRI
    {
        [XmlEnum(Name = "POP3")]
        POP3,
        [XmlEnum(Name = "IMAP")]
        IMAP,
        [XmlEnum(Name = "POP3S")]
        POP3S,
        [XmlEnum(Name = "IMAPS")]
        IMAPS,
        [XmlEnum(Name = "POP3_STLS")]
        POP3STLS,
        [XmlEnum(Name = "IMAP_STLS")]
        IMAPSTLS,
    }
}
