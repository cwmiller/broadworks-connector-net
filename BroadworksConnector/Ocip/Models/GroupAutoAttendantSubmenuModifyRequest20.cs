using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAutoAttendantSubmenuModifyRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "submenuId", IsNullable = false)]
    public string SubmenuId { get; set; }
    [XmlElement(ElementName = "newSubmenuId", IsNullable = false)]
    public string NewSubmenuId { get; set; }
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = true)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile { get; set; }
    [XmlElement(ElementName = "enableLevelExtensionDialing", IsNullable = false)]
    public bool EnableLevelExtensionDialing { get; set; }
    [XmlElement(ElementName = "keyConfiguration", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutoAttendantKeyModifyConfiguration20> KeyConfiguration { get; set; }
 }
}
