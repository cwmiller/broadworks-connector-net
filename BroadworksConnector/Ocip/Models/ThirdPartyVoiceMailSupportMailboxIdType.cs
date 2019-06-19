using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Mailbox Id type on Third Party Voice Mail platform.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ThirdPartyVoiceMailSupportMailboxIdType
    {
        [XmlEnum(Name = "User Or Group Phone Number")]
        UserOrGroupPhoneNumber,
        [XmlEnum(Name = "URL")]
        URL,
    }
}
