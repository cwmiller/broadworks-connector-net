using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantAddMenu20 
{
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile { get; set; }
    [XmlElement(ElementName = "enableFirstMenuLevelExtensionDialing", IsNullable = false)]
    public bool EnableFirstMenuLevelExtensionDialing { get; set; }
    [XmlElement(ElementName = "keyConfiguration", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutoAttendantKeyConfiguration20> KeyConfiguration { get; set; }
 }
}
