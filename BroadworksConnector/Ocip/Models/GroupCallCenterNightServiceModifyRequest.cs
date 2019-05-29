using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterNightServiceModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceUserId", IsNullable = false)]
    public string ServiceUserId { get; set; }
    [XmlElement(ElementName = "action", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledServiceAction Action { get; set; }
    [XmlElement(ElementName = "businessHours", IsNullable = true)]
    public string BusinessHours { get; set; }
    [XmlElement(ElementName = "forceNightService", IsNullable = false)]
    public bool ForceNightService { get; set; }
    [XmlElement(ElementName = "allowManualOverrideViaFAC", IsNullable = false)]
    public bool AllowManualOverrideViaFAC { get; set; }
    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true)]
    public string TransferPhoneNumber { get; set; }
    [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false)]
    public bool PlayAnnouncementBeforeAction { get; set; }
    [XmlElement(ElementName = "audioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection { get; set; }
    [XmlElement(ElementName = "audioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile { get; set; }
    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection { get; set; }
    [XmlElement(ElementName = "videoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile { get; set; }
    [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode ManualAnnouncementMode { get; set; }
    [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualAudioMessageSelection { get; set; }
    [XmlElement(ElementName = "manualAudioFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource ManualAudioFile { get; set; }
    [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualVideoMessageSelection { get; set; }
    [XmlElement(ElementName = "manualVideoFile", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource ManualVideoFile { get; set; }
 }
}
