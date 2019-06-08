using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterComfortMessageBypassModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private int _callWaitingAgeThresholdSeconds;

    [XmlElement(ElementName = "callWaitingAgeThresholdSeconds", IsNullable = false, Namespace = "")]
    public int CallWaitingAgeThresholdSeconds {
        get => _callWaitingAgeThresholdSeconds;
        set {
            CallWaitingAgeThresholdSecondsSpecified = true;
            _callWaitingAgeThresholdSeconds = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingAgeThresholdSecondsSpecified { get; set; }
    private bool _playAnnouncementAfterRinging;

    [XmlElement(ElementName = "playAnnouncementAfterRinging", IsNullable = false, Namespace = "")]
    public bool PlayAnnouncementAfterRinging {
        get => _playAnnouncementAfterRinging;
        set {
            PlayAnnouncementAfterRingingSpecified = true;
            _playAnnouncementAfterRinging = value;
        }
    }

    [XmlIgnore]
    public bool PlayAnnouncementAfterRingingSpecified { get; set; }
    private int _ringTimeBeforePlayingAnnouncementSeconds;

    [XmlElement(ElementName = "ringTimeBeforePlayingAnnouncementSeconds", IsNullable = false, Namespace = "")]
    public int RingTimeBeforePlayingAnnouncementSeconds {
        get => _ringTimeBeforePlayingAnnouncementSeconds;
        set {
            RingTimeBeforePlayingAnnouncementSecondsSpecified = true;
            _ringTimeBeforePlayingAnnouncementSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RingTimeBeforePlayingAnnouncementSecondsSpecified { get; set; }
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
}
}
