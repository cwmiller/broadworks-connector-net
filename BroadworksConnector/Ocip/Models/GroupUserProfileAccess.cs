using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum GroupUserProfileAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Read-Only")]
    ReadOnly,
    [XmlEnum(Name = "None")]
    None,
 }
}