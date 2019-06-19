using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for SIP Suppress RFC3312 Preconditions
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SIPSuppressRFC3312Preconditions
    {
        [XmlEnum(Name = "Always")]
        Always,
        [XmlEnum(Name = "Never")]
        Never,
        [XmlEnum(Name = "Suppress If Single Dialog")]
        SuppressIfSingleDialog,
    }
}
