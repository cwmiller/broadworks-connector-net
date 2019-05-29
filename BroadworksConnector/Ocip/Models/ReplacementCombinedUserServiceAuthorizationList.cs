using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedUserServiceAuthorizationList 
{
    [XmlElement(ElementName = "userServiceAuthorization", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CombinedUserServiceAuthorization> UserServiceAuthorization { get; set; }
 }
}
