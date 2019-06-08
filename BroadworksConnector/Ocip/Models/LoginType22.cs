using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum LoginType22{
    [XmlEnum(Name = "System")]
    System,
    [XmlEnum(Name = "Provisioning")]
    Provisioning,
    [XmlEnum(Name = "Reseller")]
    Reseller,
    [XmlEnum(Name = "Service Provider")]
    ServiceProvider,
    [XmlEnum(Name = "Group")]
    Group,
    [XmlEnum(Name = "Group Department")]
    GroupDepartment,
    [XmlEnum(Name = "User")]
    User,
    [XmlEnum(Name = "Lawful Intercept")]
    LawfulIntercept,
 }
}
