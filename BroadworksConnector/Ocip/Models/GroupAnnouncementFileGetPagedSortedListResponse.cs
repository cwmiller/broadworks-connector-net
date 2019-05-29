using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileGetPagedSortedListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "announcementTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AnnouncementTable { get; set; }
 }
}
