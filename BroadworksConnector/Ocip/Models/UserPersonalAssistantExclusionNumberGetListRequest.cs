using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalAssistantExclusionNumberGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumber> SearchCriteriaPersonalAssistantExclusionNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaPersonalAssistantExclusionNumberDescription", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaPersonalAssistantExclusionNumberDescription> SearchCriteriaPersonalAssistantExclusionNumberDescription { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
 }
}
