using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantSubmenuModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "submenuId", IsNullable = false)]
    public string SubmenuId { get; set; }
    [XmlElement(ElementName = "newSubmenuId", IsNullable = false)]
    public string NewSubmenuId { get; set; }
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VideoFile { get; set; }
    [XmlElement(ElementName = "enableLevelExtensionDialing", IsNullable = false)]
    public bool EnableLevelExtensionDialing { get; set; }
    [XmlElement(ElementName = "keyConfiguration", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration> KeyConfiguration { get; set; }
 }
}
