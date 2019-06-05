using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminServicePackAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "None")]
    None,
 }
}
