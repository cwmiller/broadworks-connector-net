using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactEndpointType21sp1 : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "endpointType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EndpointType21sp1 EndpointType { get; set; }
 }
}
