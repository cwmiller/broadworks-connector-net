using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServicePackMigrationTaskUserSelectionType{
    [XmlEnum(Name = "All")]
    All,
    [XmlEnum(Name = "Any")]
    Any,
    [XmlEnum(Name = "None")]
    None,
 }
}
