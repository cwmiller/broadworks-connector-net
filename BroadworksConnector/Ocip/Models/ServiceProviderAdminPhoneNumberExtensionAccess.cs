using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminPhoneNumberExtensionAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Assign To Services and Users")]
    AssignToServicesandUsers,
    [XmlEnum(Name = "Read-Only")]
    ReadOnly,
 }
}
