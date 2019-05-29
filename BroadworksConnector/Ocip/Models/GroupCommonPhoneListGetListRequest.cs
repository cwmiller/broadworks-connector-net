using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommonPhoneListGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> SearchCriteriaGroupCommonPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> SearchCriteriaGroupCommonPhoneListNumber { get; set; }
 }
}
