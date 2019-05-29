using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterComfortMessageBypassGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    [XmlElement(ElementName = "audioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList { get; set; }
    [XmlElement(ElementName = "audioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList { get; set; }
    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection { get; set; }
    [XmlElement(ElementName = "videoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList { get; set; }
    [XmlElement(ElementName = "videoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList { get; set; }
 }
}
