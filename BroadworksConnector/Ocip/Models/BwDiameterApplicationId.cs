using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum BwDiameterApplicationId
    {
        [XmlEnum(Name = "Rf")]
        Rf,
        [XmlEnum(Name = "Ro")]
        Ro,
        [XmlEnum(Name = "Sh")]
        Sh,
        [XmlEnum(Name = "All")]
        All,
    }
}
