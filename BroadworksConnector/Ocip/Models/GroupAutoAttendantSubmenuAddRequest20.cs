using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantSubmenuAddRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "submenuId", IsNullable = false)]
    public string SubmenuId { get; set; }
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile { get; set; }
    [XmlElement(ElementName = "enableLevelExtensionDialing", IsNullable = false)]
    public bool EnableLevelExtensionDialing { get; set; }
    [XmlElement(ElementName = "keyConfiguration", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutoAttendantKeyConfiguration20> KeyConfiguration { get; set; }
 }
}
