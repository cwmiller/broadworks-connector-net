using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum ServiceProviderAdminVerifyTranslationAndRoutingAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "None")]
    None,
 }
}
