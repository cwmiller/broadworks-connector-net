using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum PolicyAccess{
    [XmlEnum(Name = "Full")]
    Full,
    [XmlEnum(Name = "Restricted-FullProfile")]
    RestrictedFullProfile,
    [XmlEnum(Name = "Restricted")]
    Restricted,
    [XmlEnum(Name = "Restricted-NoAuthorize")]
    RestrictedNoAuthorize,
    [XmlEnum(Name = "Restricted-NoUserAssociation")]
    RestrictedNoUserAssociation,
    [XmlEnum(Name = "Restricted-ReadProfile")]
    RestrictedReadProfile,
    [XmlEnum(Name = "Restricted-NoProfile")]
    RestrictedNoProfile,
    [XmlEnum(Name = "Restricted-NoGroup")]
    RestrictedNoGroup,
    [XmlEnum(Name = "Restricted-FullResource")]
    RestrictedFullResource,
    [XmlEnum(Name = "Restricted-ReadResource")]
    RestrictedReadResource,
    [XmlEnum(Name = "None")]
    None,
 }
}
