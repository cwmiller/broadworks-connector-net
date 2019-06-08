using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum NetworkServerType{
    [XmlEnum(Name = "Lookup")]
    Lookup,
    [XmlEnum(Name = "Update")]
    Update,
    [XmlEnum(Name = "Both")]
    Both,
 }
}
