using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactUserRouteListAssigned : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "routeListAssigned", IsNullable = false)]
    public bool RouteListAssigned { get; set; }
 }
}
