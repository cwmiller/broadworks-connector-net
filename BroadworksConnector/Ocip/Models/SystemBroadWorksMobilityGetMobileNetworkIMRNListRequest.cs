using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetMobileNetworkIMRNListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "mobileNetworkName", IsNullable = false)]
    public string MobileNetworkName { get; set; }
    [XmlElement(ElementName = "searchCriteriaIMRN", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaIMRN> SearchCriteriaIMRN { get; set; }
 }
}
