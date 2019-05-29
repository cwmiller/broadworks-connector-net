using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantReadMenu19 
{
    [XmlElement(ElementName = "announcementSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection { get; set; }
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "audioMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
    [XmlElement(ElementName = "videoMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType { get; set; }
    [XmlElement(ElementName = "enableFirstMenuLevelExtensionDialing", IsNullable = false)]
    public bool EnableFirstMenuLevelExtensionDialing { get; set; }
    [XmlElement(ElementName = "keyConfiguration", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.AutoAttendantKeyReadConfiguration19> KeyConfiguration { get; set; }
 }
}
