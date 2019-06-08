using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupTimeZoneOffsetMinutes{
    [XmlEnum(Name = "0")]
    _0,
    [XmlEnum(Name = "30")]
    _30,
    [XmlEnum(Name = "45")]
    _45,
 }
}
