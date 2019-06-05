using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SessionTimerRefresher{
    [XmlEnum(Name = "Local")]
    Local,
    [XmlEnum(Name = "Remote")]
    Remote,
 }
}
