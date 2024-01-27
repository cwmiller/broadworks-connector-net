using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User types for which the System Password Rules apply.
    /// The rules could apply to the
    /// (1) System, Provisioning Administrator. All other administrators and users use external authentication
    /// (2) System, Provisioning Administrator. All other administrators and users use their organization's password rules
    /// (3) System, Provisioning, Service Provider Administrator
    /// (4) Administrator (System, Provisioning, Service Provider, Group and Department) and Users.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemPasswordRulesApplyTo24
    {
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
