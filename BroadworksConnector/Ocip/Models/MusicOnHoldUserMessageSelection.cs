using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum MusicOnHoldUserMessageSelection{
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "Custom")]
    Custom,
 }
}
