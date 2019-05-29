using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "userId", IsNullable = false)]
    public string UserId { get; set; }
    [XmlElement(ElementName = "announcementFileName", IsNullable = false)]
    public string AnnouncementFileName { get; set; }
    [XmlElement(ElementName = "announcementFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile { get; set; }
 }
}
