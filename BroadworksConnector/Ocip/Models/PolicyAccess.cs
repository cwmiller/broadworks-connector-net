using System;
using System.Xml.Serialization;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
public enum PolicyAccess{
    Full,
    RestrictedFullProfile,
    Restricted,
    RestrictedNoAuthorize,
    RestrictedNoUserAssociation,
    RestrictedReadProfile,
    RestrictedNoProfile,
    RestrictedNoGroup,
    RestrictedFullResource,
    RestrictedReadResource,
    None,
 }
}
