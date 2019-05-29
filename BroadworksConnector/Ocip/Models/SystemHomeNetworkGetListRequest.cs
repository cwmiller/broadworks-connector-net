using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemHomeNetworkGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaHomeMscAddress", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaHomeMscAddress> SearchCriteriaHomeMscAddress { get; set; }
 }
}
