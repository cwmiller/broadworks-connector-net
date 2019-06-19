using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The action to take for SIP messages that are not processed during Emergency DDos.
    /// Decline      = Respond to the message with 603 + Retry-After
    /// Drop         = Do not respond
    /// Error        = Respond to the message with 503
    /// Redirect     = Respond to the message with 302
    /// Unavailable  = Respond to the message with 480 + Retry-After
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ProtectionAction
    {
        [XmlEnum(Name = "Decline")]
        Decline,
        [XmlEnum(Name = "Drop")]
        Drop,
        [XmlEnum(Name = "Error")]
        Error,
        [XmlEnum(Name = "Redirect")]
        Redirect,
        [XmlEnum(Name = "Unavailable")]
        Unavailable,
    }
}
