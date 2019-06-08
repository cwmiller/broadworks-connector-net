using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterNightServiceModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterScheduledServiceAction Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private string _businessHours;

    [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
    public string BusinessHours {
        get => _businessHours;
        set {
            BusinessHoursSpecified = true;
            _businessHours = value;
        }
    }

    [XmlIgnore]
    public bool BusinessHoursSpecified { get; set; }
    private bool _forceNightService;

    [XmlElement(ElementName = "forceNightService", IsNullable = false, Namespace = "")]
    public bool ForceNightService {
        get => _forceNightService;
        set {
            ForceNightServiceSpecified = true;
            _forceNightService = value;
        }
    }

    [XmlIgnore]
    public bool ForceNightServiceSpecified { get; set; }
    private bool _allowManualOverrideViaFAC;

    [XmlElement(ElementName = "allowManualOverrideViaFAC", IsNullable = false, Namespace = "")]
    public bool AllowManualOverrideViaFAC {
        get => _allowManualOverrideViaFAC;
        set {
            AllowManualOverrideViaFACSpecified = true;
            _allowManualOverrideViaFAC = value;
        }
    }

    [XmlIgnore]
    public bool AllowManualOverrideViaFACSpecified { get; set; }
    private string _transferPhoneNumber;

    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
    public string TransferPhoneNumber {
        get => _transferPhoneNumber;
        set {
            TransferPhoneNumberSpecified = true;
            _transferPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferPhoneNumberSpecified { get; set; }
    private bool _playAnnouncementBeforeAction;

    [XmlElement(ElementName = "playAnnouncementBeforeAction", IsNullable = false, Namespace = "")]
    public bool PlayAnnouncementBeforeAction {
        get => _playAnnouncementBeforeAction;
        set {
            PlayAnnouncementBeforeActionSpecified = true;
            _playAnnouncementBeforeAction = value;
        }
    }

    [XmlIgnore]
    public bool PlayAnnouncementBeforeActionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

    [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection {
        get => _audioMessageSelection;
        set {
            AudioMessageSelectionSpecified = true;
            _audioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection {
        get => _videoMessageSelection;
        set {
            VideoMessageSelectionSpecified = true;
            _videoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode _manualAnnouncementMode;

    [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode ManualAnnouncementMode {
        get => _manualAnnouncementMode;
        set {
            ManualAnnouncementModeSpecified = true;
            _manualAnnouncementMode = value;
        }
    }

    [XmlIgnore]
    public bool ManualAnnouncementModeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualAudioMessageSelection;

    [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection ManualAudioMessageSelection {
        get => _manualAudioMessageSelection;
        set {
            ManualAudioMessageSelectionSpecified = true;
            _manualAudioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool ManualAudioMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _manualAudioFile;

    [XmlElement(ElementName = "manualAudioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource ManualAudioFile {
        get => _manualAudioFile;
        set {
            ManualAudioFileSpecified = true;
            _manualAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool ManualAudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _manualVideoMessageSelection;

    [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection ManualVideoMessageSelection {
        get => _manualVideoMessageSelection;
        set {
            ManualVideoMessageSelectionSpecified = true;
            _manualVideoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool ManualVideoMessageSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource _manualVideoFile;

    [XmlElement(ElementName = "manualVideoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedMediaFileResource ManualVideoFile {
        get => _manualVideoFile;
        set {
            ManualVideoFileSpecified = true;
            _manualVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool ManualVideoFileSpecified { get; set; }
}
}
