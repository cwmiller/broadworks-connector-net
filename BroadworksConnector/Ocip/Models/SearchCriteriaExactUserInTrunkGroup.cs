using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserInTrunkGroup : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "userInTrunkGroup", IsNullable = false)]
    public bool UserInTrunkGroup { get; set; }
 }
}
