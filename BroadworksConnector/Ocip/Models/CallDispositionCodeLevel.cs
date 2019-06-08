using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum CallDispositionCodeLevel{
    [XmlEnum(Name = "Enterprise")]
    Enterprise,
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "Queue")]
    Queue,
 }
}
