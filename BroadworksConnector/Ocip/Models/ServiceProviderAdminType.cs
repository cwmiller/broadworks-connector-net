using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminType{
    [XmlEnum(Name = "Normal")]
    Normal,
    [XmlEnum(Name = "Customer")]
    Customer,
    [XmlEnum(Name = "Password Reset Only")]
    PasswordResetOnly,
 }
}
