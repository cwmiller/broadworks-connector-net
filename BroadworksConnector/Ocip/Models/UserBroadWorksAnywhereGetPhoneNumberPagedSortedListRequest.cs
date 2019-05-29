using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserBroadWorksAnywhereGetPhoneNumberPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByLocation", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByLocation SortByLocation { get; set; }
    [XmlElement(ElementName = "sortByEnabled", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByEnabled SortByEnabled { get; set; }
    [XmlElement(ElementName = "searchCriteriaLocation", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaLocation> SearchCriteriaLocation { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactLocationEnabled", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactLocationEnabled SearchCriteriaExactLocationEnabled { get; set; }
 }
}
