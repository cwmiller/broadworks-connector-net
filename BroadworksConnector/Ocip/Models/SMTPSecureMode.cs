using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for SMTP secure mode.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SMTPSecureMode    {
            [XmlEnum(Name = "Disabled")]
        Disabled,
            [XmlEnum(Name = "SMTPS")]
        SMTPS,
            [XmlEnum(Name = "STARTTLS")]
        STARTTLS,
     }
}
