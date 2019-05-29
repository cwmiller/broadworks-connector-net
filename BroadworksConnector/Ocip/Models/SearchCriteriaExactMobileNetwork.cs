using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SearchCriteriaExactMobileNetwork : BroadworksConnector.Ocip.Models.SearchCriteria
{
    [XmlElement(ElementName = "mobileNetworkName", IsNullable = false)]
    public string MobileNetworkName { get; set; }
 }
}
