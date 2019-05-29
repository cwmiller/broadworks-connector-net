using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "groupId", IsNullable = false)]
    public string GroupId { get; set; }
    [XmlElement(ElementName = "announcementFileKey", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey { get; set; }
    [XmlElement(ElementName = "newAnnouncementFileName", IsNullable = false)]
    public string NewAnnouncementFileName { get; set; }
    [XmlElement(ElementName = "announcementFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile { get; set; }
 }
}
