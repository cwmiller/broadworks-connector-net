using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ReplacementCombinedGroupServiceAuthorizationList 
{
    [XmlElement(ElementName = "groupServiceAuthorization", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CombinedGroupServiceAuthorization> GroupServiceAuthorization { get; set; }
 }
}
