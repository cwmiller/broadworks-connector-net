using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AutoAttendantMenuKey
    {
        [XmlEnum(Name = "0")]
        _0,
        [XmlEnum(Name = "1")]
        _1,
        [XmlEnum(Name = "2")]
        _2,
        [XmlEnum(Name = "3")]
        _3,
        [XmlEnum(Name = "4")]
        _4,
        [XmlEnum(Name = "5")]
        _5,
        [XmlEnum(Name = "6")]
        _6,
        [XmlEnum(Name = "7")]
        _7,
        [XmlEnum(Name = "8")]
        _8,
        [XmlEnum(Name = "9")]
        _9,
        [XmlEnum(Name = "*")]
        Star,
        [XmlEnum(Name = "#")]
        Pound,
    }
}
