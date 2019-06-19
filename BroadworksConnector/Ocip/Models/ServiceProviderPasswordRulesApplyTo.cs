using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// User types for which the Service Provider Password Rules apply.
    /// The rules could apply to the Administrators (Group and Department) or
    /// Administrators (Group and Department) and Users.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum ServiceProviderPasswordRulesApplyTo
    {
        [XmlEnum(Name = "Administrator")]
        Administrator,
        [XmlEnum(Name = "Administrator and User")]
        AdministratorandUser,
        [XmlEnum(Name = "Group Administrator and User External Authentication")]
        GroupAdministratorandUserExternalAuthentication,
    }
}
