using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobilityMobileSubscriberDirectoryNumberGetAvailablePagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByMobileDirectoryNumber", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByMobileDirectoryNumber SortByMobileDirectoryNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaMobileSubscriberDirectoryNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> SearchCriteriaMobileSubscriberDirectoryNumber { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
 }
}
