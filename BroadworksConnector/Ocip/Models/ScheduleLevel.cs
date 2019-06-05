using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ScheduleLevel{
    [XmlEnum(Name = "Service Provider")]
    ServiceProvider,
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "User")]
    User,
 }
}
