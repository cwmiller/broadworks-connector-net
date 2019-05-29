using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "responsePagingControl", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl { get; set; }
    [XmlElement(ElementName = "sortByAnnouncementFileName", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByAnnouncementFileName SortByAnnouncementFileName { get; set; }
    [XmlElement(ElementName = "sortByAnnouncementFileSize", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SortByAnnouncementFileSize SortByAnnouncementFileSize { get; set; }
    [XmlElement(ElementName = "searchCriteriaAnnouncementFileName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> SearchCriteriaAnnouncementFileName { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactAnnouncementFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType SearchCriteriaExactAnnouncementFileType { get; set; }
    [XmlElement(ElementName = "searchCriteriaExactMediaFileType", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactMediaFileType> SearchCriteriaExactMediaFileType { get; set; }
    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false)]
    public bool SearchCriteriaModeOr { get; set; }
 }
}
