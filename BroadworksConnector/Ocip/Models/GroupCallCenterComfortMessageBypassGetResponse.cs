using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterComfortMessageBypassGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "isActive", IsNullable = false)]
    public bool IsActive { get; set; }
    [XmlElement(ElementName = "callWaitingAgeThresholdSeconds", IsNullable = false)]
    public int CallWaitingAgeThresholdSeconds { get; set; }
    [XmlElement(ElementName = "playAnnouncementAfterRinging", IsNullable = false)]
    public bool PlayAnnouncementAfterRinging { get; set; }
    [XmlElement(ElementName = "ringTimeBeforePlayingAnnouncementSeconds", IsNullable = false)]
    public int RingTimeBeforePlayingAnnouncementSeconds { get; set; }
    [XmlElement(ElementName = "audioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection { get; set; }
    [XmlElement(ElementName = "audioFileUrl", IsNullable = false)]
    public string AudioFileUrl { get; set; }
    [XmlElement(ElementName = "audioFileDescription", IsNullable = false)]
    public string AudioFileDescription { get; set; }
    [XmlElement(ElementName = "audioMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType { get; set; }
    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection { get; set; }
    [XmlElement(ElementName = "videoFileUrl", IsNullable = false)]
    public string VideoFileUrl { get; set; }
    [XmlElement(ElementName = "videoFileDescription", IsNullable = false)]
    public string VideoFileDescription { get; set; }
    [XmlElement(ElementName = "videoMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType { get; set; }
 }
}
