using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNumberPortabilityQueryDigitPatternGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "searchCriteriaNumberPortabilityQueryDigitPattern", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaNumberPortabilityQueryDigitPattern> SearchCriteriaNumberPortabilityQueryDigitPattern { get; set; }
    [XmlElement(ElementName = "searchCriteriaNumberPortabilityStatus", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaNumberPortabilityStatus> SearchCriteriaNumberPortabilityStatus { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
 }
}
