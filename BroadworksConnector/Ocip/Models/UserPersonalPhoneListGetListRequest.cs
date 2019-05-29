using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> SearchCriteriaUserPersonalPhoneListName { get; set; }
    [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> SearchCriteriaUserPersonalPhoneListNumber { get; set; }
 }
}
