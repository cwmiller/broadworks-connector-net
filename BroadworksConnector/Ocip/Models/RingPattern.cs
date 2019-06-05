using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum RingPattern{
    [XmlEnum(Name = "Normal")]
    Normal,
    [XmlEnum(Name = "Long-Long")]
    LongLong,
    [XmlEnum(Name = "Short-Short-Long")]
    ShortShortLong,
    [XmlEnum(Name = "Short-Long-Short")]
    ShortLongShort,
 }
}
