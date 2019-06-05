using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderPasswordRulesApplyTo{
    [XmlEnum(Name = "Administrator")]
    Administrator,
    [XmlEnum(Name = "Administrator and User")]
    AdministratorandUser,
    [XmlEnum(Name = "Group Administrator and User External Authentication")]
    GroupAdministratorandUserExternalAuthentication,
 }
}
