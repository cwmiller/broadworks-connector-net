using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CallCenterType
    {
        [XmlEnum(Name = "Basic")]
        Basic,
        [XmlEnum(Name = "Standard")]
        Standard,
        [XmlEnum(Name = "Premium")]
        Premium,
    }
}
