using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterNightServiceGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledServiceAction Action { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours { get; set; }
    [XmlElement(ElementName = "forceNightService", IsNullable = false)]
    public bool ForceNightService { get; set; }
    [XmlElement(ElementName = "allowManualOverrideViaFAC", IsNullable = false)]
    public bool AllowManualOverrideViaFAC { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false)]
    public bool PlayAnnouncementBeforeAction { get; set; }
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
    [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode ManualAnnouncementMode { get; set; }
    [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "manualAudioUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList ManualAudioUrlList { get; set; }
    [XmlElement(ElementName = "manualAudioFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 ManualAudioFileList { get; set; }
    [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "manualVideoUrlList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList ManualVideoUrlList { get; set; }
    [XmlElement(ElementName = "manualVideoFileList", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 ManualVideoFileList { get; set; }
 }
}
