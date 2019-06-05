using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminWebBrandingAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "None")]
    None,
 }
}
