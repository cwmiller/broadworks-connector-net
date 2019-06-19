using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Third Party Voice Mail user-level voice mail server choices.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ThirdPartyVoiceMailSupportServerSelection
    {
        [XmlEnum(Name = "Group Mail Server")]
        GroupMailServer,
        [XmlEnum(Name = "User Specific Mail Server")]
        UserSpecificMailServer,
    }
}
