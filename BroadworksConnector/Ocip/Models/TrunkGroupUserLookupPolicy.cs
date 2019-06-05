using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupUserLookupPolicy{
    [XmlEnum(Name = "Basic")]
    Basic,
    [XmlEnum(Name = "Extended")]
    Extended,
    [XmlEnum(Name = "Basic Lookup Prefer From")]
    BasicLookupPreferFrom,
 }
}
