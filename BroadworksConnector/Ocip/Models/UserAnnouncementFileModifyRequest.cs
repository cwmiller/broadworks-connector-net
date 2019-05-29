using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "announcementFileKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey { get; set; }
    [XmlElement(ElementName = "newAnnouncementFileName", IsNullable = false)]
    public string NewAnnouncementFileName { get; set; }
    [XmlElement(ElementName = "announcementFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile { get; set; }
 }
}
