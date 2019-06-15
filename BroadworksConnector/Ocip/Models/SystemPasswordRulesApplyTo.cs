using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User types for which the System Password Rules apply.
    /// The rules could apply to the
    /// (1) System, Provisioning Administrator
    /// (2) System, Provisioning, Service Provider Administrator
    /// (3) Administrator (System, Provisioning, Service Provider, Group and Department) and Users.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum SystemPasswordRulesApplyTo    {
            [XmlEnum(Name = "System, Provisioning Administrator")]
        SystemProvisioningAdministrator,
            [XmlEnum(Name = "System, Provisioning, Service Provider Administrator")]
        SystemProvisioningServiceProviderAdministrator,
            [XmlEnum(Name = "Administrator and User")]
        AdministratorandUser,
     }
}
