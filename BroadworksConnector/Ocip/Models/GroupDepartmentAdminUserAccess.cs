using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupDepartmentAdminUserAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Read-Only Profile")]
    ReadOnlyProfile,
    [XmlEnum(Name = "No Profile")]
    NoProfile,
    [XmlEnum(Name = "None")]
    None,
 }
}
