using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactCallCenterType : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "callCenterType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterType CallCenterType { get; set; }
 }
}
