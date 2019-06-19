using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Trunk Mode Options
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum TrunkMode
    {
        [XmlEnum(Name = "Pilot")]
        Pilot,
        [XmlEnum(Name = "Proxy")]
        Proxy,
        [XmlEnum(Name = "User")]
        User,
    }
}
