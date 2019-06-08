using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ScheduleCombinationType{
    [XmlEnum(Name = "UNION")]
    UNION,
    [XmlEnum(Name = "INTERSECTION")]
    INTERSECTION,
 }
}
