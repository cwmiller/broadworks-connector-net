using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User types for which the System Password Rules apply.
    /// The rules could apply to the
    /// (1) System, Provisioning Administrator
    /// (2) System, Provisioning Administrator. All other administrators and users use external authentication
    /// (3) System, Provisioning Administrator. All other administrators and users use their organization's password rules
    /// (4) System, Provisioning, Service Provider Administrator
    /// (5) Administrator (System, Provisioning, Service Provider, Group and Department) and Users.
    /// 
    /// The following value can only be returned in XS data mode :
    /// System, Provisioning Administrator
    /// 
    /// The following values can only be returned in AS data mode :
    /// System, Provisioning Administrator. All other administrators and users use external authentication
    /// System, Provisioning Administrator. All other administrators and users use their organization's password rules
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemPasswordRulesApplyToRI
    {
        [XmlEnum(Name = "System, Provisioning Administrator")]
        SystemProvisioningAdministrator,
        [XmlEnum(Name = "System, Provisioning Administrator. All other administrators and users use external authentication")]
        SystemProvisioningAdministratorAllotheradministratorsandusersuseexternalauthentication,
        [XmlEnum(Name = "System, Provisioning Administrator. All other administrators and users use their organization's password rules")]
        SystemProvisioningAdministratorAllotheradministratorsandusersusetheirorganizationspasswordrules,
        [XmlEnum(Name = "System, Provisioning, Service Provider Administrator")]
        SystemProvisioningServiceProviderAdministrator,
        [XmlEnum(Name = "Administrator and User")]
        AdministratorandUser,
    }
}
