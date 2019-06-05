using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum CLIDDeliveryPrefix
    {
        [XmlEnum(Name = "00X")]
        _00X,
        [XmlEnum(Name = "001")]
        _001,
        [XmlEnum(Name = "002")]
        _002,
        [XmlEnum(Name = "003")]
        _003,
        [XmlEnum(Name = "004")]
        _004,
        [XmlEnum(Name = "005")]
        _005,
        [XmlEnum(Name = "006")]
        _006,
        [XmlEnum(Name = "007")]
        _007,
        [XmlEnum(Name = "008")]
        _008,
        [XmlEnum(Name = "009")]
        _009,
    }
}
