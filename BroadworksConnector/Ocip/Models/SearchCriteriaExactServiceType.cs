using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactServiceType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "serviceType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceType ServiceType { get; set; }
 }
}
