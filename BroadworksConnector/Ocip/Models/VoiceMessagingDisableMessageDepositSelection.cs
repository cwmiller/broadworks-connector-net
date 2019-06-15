using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Announcement Selection.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum VoiceMessagingDisableMessageDepositSelection    {
            [XmlEnum(Name = "Disconnect")]
        Disconnect,
            [XmlEnum(Name = "Forward")]
        Forward,
     }
}
