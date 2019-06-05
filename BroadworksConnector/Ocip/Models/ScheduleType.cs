using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ScheduleType{
    [XmlEnum(Name = "Holiday")]
    Holiday,
    [XmlEnum(Name = "Time")]
    Time,
 }
}
