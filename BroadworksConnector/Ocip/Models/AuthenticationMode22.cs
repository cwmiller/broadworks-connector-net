using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for SIP Device Authentication
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AuthenticationMode22
    {
        [XmlEnum(Name = "Enabled")]
        Enabled,
        [XmlEnum(Name = "Disabled")]
        Disabled,
    }
}
