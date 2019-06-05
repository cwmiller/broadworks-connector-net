using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallRecordingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecordingOption20 _recordingOption;

    [XmlElement(ElementName = "recordingOption", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecordingOption20 RecordingOption {
        get => _recordingOption;
        set {
            RecordingOptionSpecified = true;
            _recordingOption = value;
        }
    }

    [XmlIgnore]
    public bool RecordingOptionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.RecordingPauseResumeNotificationType _pauseResumeNotification;

    [XmlElement(ElementName = "pauseResumeNotification", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.RecordingPauseResumeNotificationType PauseResumeNotification {
        get => _pauseResumeNotification;
        set {
            PauseResumeNotificationSpecified = true;
            _pauseResumeNotification = value;
        }
    }

    [XmlIgnore]
    public bool PauseResumeNotificationSpecified { get; set; }
    private bool _enableCallRecordingAnnouncement;

    [XmlElement(ElementName = "enableCallRecordingAnnouncement", IsNullable = false, Namespace = "")]
    public bool EnableCallRecordingAnnouncement {
        get => _enableCallRecordingAnnouncement;
        set {
            EnableCallRecordingAnnouncementSpecified = true;
            _enableCallRecordingAnnouncement = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallRecordingAnnouncementSpecified { get; set; }
    private bool _enableRecordCallRepeatWarningTone;

    [XmlElement(ElementName = "enableRecordCallRepeatWarningTone", IsNullable = false, Namespace = "")]
    public bool EnableRecordCallRepeatWarningTone {
        get => _enableRecordCallRepeatWarningTone;
        set {
            EnableRecordCallRepeatWarningToneSpecified = true;
            _enableRecordCallRepeatWarningTone = value;
        }
    }

    [XmlIgnore]
    public bool EnableRecordCallRepeatWarningToneSpecified { get; set; }
    private int _recordCallRepeatWarningToneTimerSeconds;

    [XmlElement(ElementName = "recordCallRepeatWarningToneTimerSeconds", IsNullable = false, Namespace = "")]
    public int RecordCallRepeatWarningToneTimerSeconds {
        get => _recordCallRepeatWarningToneTimerSeconds;
        set {
            RecordCallRepeatWarningToneTimerSecondsSpecified = true;
            _recordCallRepeatWarningToneTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RecordCallRepeatWarningToneTimerSecondsSpecified { get; set; }
    private bool _enableVoiceMailRecording;

    [XmlElement(ElementName = "enableVoiceMailRecording", IsNullable = false, Namespace = "")]
    public bool EnableVoiceMailRecording {
        get => _enableVoiceMailRecording;
        set {
            EnableVoiceMailRecordingSpecified = true;
            _enableVoiceMailRecording = value;
        }
    }

    [XmlIgnore]
    public bool EnableVoiceMailRecordingSpecified { get; set; }
}
}
