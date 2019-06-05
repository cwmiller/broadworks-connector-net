using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointNightServiceModifyRequest20 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.CallCenterScheduledServiceAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterScheduledServiceAction Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TimeSchedule _businessHours;

    [XmlElement(ElementName = "businessHours", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TimeSchedule BusinessHours {
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
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _audioMessageSelection;

    [XmlElement(ElementName = "audioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioMessageSelection {
        get => _audioMessageSelection;
        set {
            AudioMessageSelectionSpecified = true;
            _audioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioMessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _audioUrlList;

    [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify AudioUrlList {
        get => _audioUrlList;
        set {
            AudioUrlListSpecified = true;
            _audioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool AudioUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 _audioFileList;

    [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 AudioFileList {
        get => _audioFileList;
        set {
            AudioFileListSpecified = true;
            _audioFileList = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _videoMessageSelection;

    [XmlElement(ElementName = "videoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoMessageSelection {
        get => _videoMessageSelection;
        set {
            VideoMessageSelectionSpecified = true;
            _videoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoMessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _videoUrlList;

    [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify VideoUrlList {
        get => _videoUrlList;
        set {
            VideoUrlListSpecified = true;
            _videoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool VideoUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 _videoFileList;

    [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 VideoFileList {
        get => _videoFileList;
        set {
            VideoFileListSpecified = true;
            _videoFileList = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode _manualAnnouncementMode;

    [XmlElement(ElementName = "manualAnnouncementMode", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterManualNightServiceAnnouncementMode ManualAnnouncementMode {
        get => _manualAnnouncementMode;
        set {
            ManualAnnouncementModeSpecified = true;
            _manualAnnouncementMode = value;
        }
    }

    [XmlIgnore]
    public bool ManualAnnouncementModeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _manualAudioMessageSelection;

    [XmlElement(ElementName = "manualAudioMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualAudioMessageSelection {
        get => _manualAudioMessageSelection;
        set {
            ManualAudioMessageSelectionSpecified = true;
            _manualAudioMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool ManualAudioMessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _manualAudioUrlList;

    [XmlElement(ElementName = "manualAudioUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify ManualAudioUrlList {
        get => _manualAudioUrlList;
        set {
            ManualAudioUrlListSpecified = true;
            _manualAudioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool ManualAudioUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 _manualAudioFileList;

    [XmlElement(ElementName = "manualAudioFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 ManualAudioFileList {
        get => _manualAudioFileList;
        set {
            ManualAudioFileListSpecified = true;
            _manualAudioFileList = value;
        }
    }

    [XmlIgnore]
    public bool ManualAudioFileListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _manualVideoMessageSelection;

    [XmlElement(ElementName = "manualVideoMessageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection ManualVideoMessageSelection {
        get => _manualVideoMessageSelection;
        set {
            ManualVideoMessageSelectionSpecified = true;
            _manualVideoMessageSelection = value;
        }
    }

    [XmlIgnore]
    public bool ManualVideoMessageSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify _manualVideoUrlList;

    [XmlElement(ElementName = "manualVideoUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLListModify ManualVideoUrlList {
        get => _manualVideoUrlList;
        set {
            ManualVideoUrlListSpecified = true;
            _manualVideoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool ManualVideoUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 _manualVideoFileList;

    [XmlElement(ElementName = "manualVideoFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementFileListModify20 ManualVideoFileList {
        get => _manualVideoFileList;
        set {
            ManualVideoFileListSpecified = true;
            _manualVideoFileList = value;
        }
    }

    [XmlIgnore]
    public bool ManualVideoFileListSpecified { get; set; }
}
}
