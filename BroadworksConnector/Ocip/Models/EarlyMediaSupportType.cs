using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Early Media Support types. This is typically used to configure the ringback tone delivery mode.
    /// When there is no early media, the call originator typically supplies ringback tone locally.
    /// RTP - Early Session refers to RFC 3959.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum EarlyMediaSupportType    {
            [XmlEnum(Name = "No Early Media")]
        NoEarlyMedia,
            [XmlEnum(Name = "RTP - Session")]
        RTPSession,
            [XmlEnum(Name = "RTP - Early Session")]
        RTPEarlySession,
     }
}
