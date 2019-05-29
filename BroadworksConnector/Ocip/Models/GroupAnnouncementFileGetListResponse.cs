using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "announcementTable", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.C.OCITable AnnouncementTable { get; set; }
    [XmlElement(ElementName = "totalFileSize", IsNullable = false)]
    public int TotalFileSize { get; set; }
    [XmlElement(ElementName = "maxFileSize", IsNullable = false)]
    public int MaxFileSize { get; set; }
 }
}
