using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminServiceAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "No Authorization")]
    NoAuthorization,
    [XmlEnum(Name = "Read-Only")]
    ReadOnly,
 }
}
