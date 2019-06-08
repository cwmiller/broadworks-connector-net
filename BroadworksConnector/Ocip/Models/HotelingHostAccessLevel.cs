using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum HotelingHostAccessLevel{
    [XmlEnum(Name = "Enterprise")]
    Enterprise,
    [XmlEnum(Name = "Group")]
    Group,
 }
}
