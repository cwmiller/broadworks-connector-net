using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "announcementFileType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileType AnnouncementFileType { get; set; }
    [XmlElement(ElementName = "includeAnnouncementTable", IsNullable = false)]
    public bool IncludeAnnouncementTable { get; set; }
    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false)]
    public int ResponseSizeLimit { get; set; }
    [XmlElement(ElementName = "searchCriteriaAnnouncementFileName", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> SearchCriteriaAnnouncementFileName { get; set; }
 }
}
