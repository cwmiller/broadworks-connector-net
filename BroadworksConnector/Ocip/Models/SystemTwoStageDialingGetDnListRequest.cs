using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTwoStageDialingGetDnListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaSystemServiceDn", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaSystemServiceDn> SearchCriteriaSystemServiceDn { get; set; }
 }
}
