using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum TrunkGroupUserCreationMode{
    [XmlEnum(Name = "Extension")]
    Extension,
    [XmlEnum(Name = "Phone Number")]
    PhoneNumber,
 }
}
