using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemAdminType{
    [XmlEnum(Name = "System")]
    System,
    [XmlEnum(Name = "Provisioning")]
    Provisioning,
 }
}
