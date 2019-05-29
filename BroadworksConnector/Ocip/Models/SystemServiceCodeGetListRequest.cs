using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServiceCodeGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceCode", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceCode> SearchCriteriaServiceCode { get; set; }
    [XmlElement(ElementName = "searchCriteriaServiceCodeDescription", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceCodeDescription> SearchCriteriaServiceCodeDescription { get; set; }
 }
}
