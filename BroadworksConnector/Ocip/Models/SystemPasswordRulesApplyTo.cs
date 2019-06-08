using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum SystemPasswordRulesApplyTo{
    [XmlEnum(Name = "System, Provisioning Administrator")]
    SystemProvisioningAdministrator,
    [XmlEnum(Name = "System, Provisioning, Service Provider Administrator")]
    SystemProvisioningServiceProviderAdministrator,
    [XmlEnum(Name = "Administrator and User")]
    AdministratorandUser,
 }
}
