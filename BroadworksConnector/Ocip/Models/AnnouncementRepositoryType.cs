using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AnnouncementRepositoryType{
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "User")]
    User,
 }
}
