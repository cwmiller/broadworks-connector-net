using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken API Compatibility.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenApiCompatibility
    {
        [XmlEnum(Name = "ATIS1000082")]
        ATIS1000082,
        [XmlEnum(Name = "3GPP")]
        _3GPP,
    }
}
