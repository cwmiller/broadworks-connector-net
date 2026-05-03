using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Stir Shaken Identity Headers Handling.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum StirShakenIdentityHeadersHandling
    {
        [XmlEnum(Name = "Proxy Only")]
        ProxyOnly,
        [XmlEnum(Name = "Proxy and Sign")]
        ProxyandSign,
        [XmlEnum(Name = "Off")]
        Off,
    }
}
