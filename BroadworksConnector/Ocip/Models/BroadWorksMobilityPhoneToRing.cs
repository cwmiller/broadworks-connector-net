using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum BroadWorksMobilityPhoneToRing{
    [XmlEnum(Name = "Fixed")]
    Fixed,
    [XmlEnum(Name = "Mobile")]
    Mobile,
    [XmlEnum(Name = "Both")]
    Both,
 }
}
