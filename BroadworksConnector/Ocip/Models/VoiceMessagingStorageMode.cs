using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for the Voice Messaging Storage mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingStorageMode    {
            [XmlEnum(Name = "Cloud")]
        Cloud,
            [XmlEnum(Name = "Mail Server")]
        MailServer,
     }
}
