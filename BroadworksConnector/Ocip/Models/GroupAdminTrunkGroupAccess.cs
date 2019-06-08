using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupAdminTrunkGroupAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Full Resources")]
    FullResources,
    [XmlEnum(Name = "Read-Only Resources")]
    ReadOnlyResources,
    [XmlEnum(Name = "None")]
    None,
 }
}
