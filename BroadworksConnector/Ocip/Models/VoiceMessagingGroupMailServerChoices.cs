using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Voice Messaging group-level mail server choices.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingGroupMailServerChoices
    {
        [XmlEnum(Name = "System Mail Server")]
        SystemMailServer,
        [XmlEnum(Name = "Group Mail Server")]
        GroupMailServer,
    }
}
