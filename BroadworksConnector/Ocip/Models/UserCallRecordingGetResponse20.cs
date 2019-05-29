using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallRecordingGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "recordingOption", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecordingOption20 RecordingOption { get; set; }
    [XmlElement(ElementName = "pauseResumeNotification", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.RecordingPauseResumeNotificationType PauseResumeNotification { get; set; }
    [XmlElement(ElementName = "enableCallRecordingAnnouncement", IsNullable = false)]
    public bool EnableCallRecordingAnnouncement { get; set; }
    [XmlElement(ElementName = "enableRecordCallRepeatWarningTone", IsNullable = false)]
    public bool EnableRecordCallRepeatWarningTone { get; set; }
    [XmlElement(ElementName = "recordCallRepeatWarningToneTimerSeconds", IsNullable = false)]
    public int RecordCallRepeatWarningToneTimerSeconds { get; set; }
    [XmlElement(ElementName = "enableVoiceMailRecording", IsNullable = false)]
    public bool EnableVoiceMailRecording { get; set; }
 }
}
