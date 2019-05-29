using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "announcementFileName", IsNullable = false)]
    public string AnnouncementFileName { get; set; }
    [XmlElement(ElementName = "announcementFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile { get; set; }
 }
}
