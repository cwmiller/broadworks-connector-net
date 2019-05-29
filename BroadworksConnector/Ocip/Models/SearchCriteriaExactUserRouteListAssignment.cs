using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserRouteListAssignment : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "assigned", IsNullable = false)]
    public bool Assigned { get; set; }
 }
}
