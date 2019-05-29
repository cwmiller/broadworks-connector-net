using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactOrganizationType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "organizationType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.OrganizationType OrganizationType { get; set; }
 }
}
