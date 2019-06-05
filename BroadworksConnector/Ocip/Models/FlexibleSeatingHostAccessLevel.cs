using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum FlexibleSeatingHostAccessLevel
    {
        [XmlEnum(Name = "Enterprise")]
        Enterprise,
        [XmlEnum(Name = "Group")]
        Group,
    }
}
