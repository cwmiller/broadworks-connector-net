using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaResellerId", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerId> SearchCriteriaResellerId { get; set; }
    [XmlElement(ElementName = "searchCriteriaResellerName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaResellerName> SearchCriteriaResellerName { get; set; }
 }
}
