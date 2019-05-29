using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCustomRingbackUserGetCriteriaResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "timeSchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule { get; set; }
    [XmlElement(ElementName = "holidaySchedule", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule { get; set; }
    [XmlElement(ElementName = "blacklisted", IsNullable = false)]
    public bool Blacklisted { get; set; }
    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria { get; set; }
    [XmlElement(ElementName = "callToNumber", IsNullable = false)]
    public List<BroadworksConnector.Ocip.Models.CallToNumber> CallToNumber { get; set; }
    [XmlElement(ElementName = "audioSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile { get; set; }
    [XmlElement(ElementName = "audioFileUrl", IsNullable = false)]
    public string AudioFileUrl { get; set; }
    [XmlElement(ElementName = "videoSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile { get; set; }
    [XmlElement(ElementName = "videoFileUrl", IsNullable = false)]
    public string VideoFileUrl { get; set; }
    [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingAudioSelection { get; set; }
    [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingAudioFile { get; set; }
    [XmlElement(ElementName = "callWaitingAudioFileUrl", IsNullable = false)]
    public string CallWaitingAudioFileUrl { get; set; }
    [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingVideoSelection { get; set; }
    [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingVideoFile { get; set; }
    [XmlElement(ElementName = "callWaitingVideoFileUrl", IsNullable = false)]
    public string CallWaitingVideoFileUrl { get; set; }
 }
}
