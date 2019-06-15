using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Group's policy for user access to his voice messaging configuration.
    /// "Full" indicates full control over the voice messaging configuration.
    /// "Restricted" indicates that the choice to either use unified messaging option (whereby the user can configure a mail server on which messages are stored)
    /// or to forward the voice message to a designated email address is not available.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum GroupVoiceMessagingAccess    {
            [XmlEnum(Name = "Full")]
        Full,
            [XmlEnum(Name = "Restricted")]
        Restricted,
     }
}
