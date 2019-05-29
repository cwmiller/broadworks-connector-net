using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterNightServiceGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledServiceAction Action { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = false)]
    public string BusinessHours { get; set; }
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
    [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode ManualAnnouncementMode { get; set; }
    [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "manualAudioFileUrl", IsNullable = false)]
    public string ManualAudioFileUrl { get; set; }
    [XmlElement(ElementName = "manualAudioFileDescription", IsNullable = false)]
    public string ManualAudioFileDescription { get; set; }
    [XmlElement(ElementName = "manualAudioMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType ManualAudioMediaType { get; set; }
    [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "manualVideoFileUrl", IsNullable = false)]
    public string ManualVideoFileUrl { get; set; }
    [XmlElement(ElementName = "manualVideoFileDescription", IsNullable = false)]
    public string ManualVideoFileDescription { get; set; }
    [XmlElement(ElementName = "manualVideoMediaType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaFileType ManualVideoMediaType { get; set; }
 }
}
