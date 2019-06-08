using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
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
