using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCustomRingbackUserGetCriteriaResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.TimeSchedule _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule {
        get => _timeSchedule;
        set {
            TimeScheduleSpecified = true;
            _timeSchedule = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

    [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
    private bool _blacklisted;

    [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
    public bool Blacklisted {
        get => _blacklisted;
        set {
            BlacklistedSpecified = true;
            _blacklisted = value;
        }
    }

    [XmlIgnore]
    public bool BlacklistedSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria {
        get => _fromDnCriteria;
        set {
            FromDnCriteriaSpecified = true;
            _fromDnCriteria = value;
        }
    }

    [XmlIgnore]
    public bool FromDnCriteriaSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallToNumber> _callToNumber;

    [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallToNumber> CallToNumber {
        get => _callToNumber;
        set {
            CallToNumberSpecified = true;
            _callToNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallToNumberSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

    [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection {
        get => _audioSelection;
        set {
            AudioSelectionSpecified = true;
            _audioSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private string _audioFileUrl;

    [XmlElement(ElementName = "audioFileUrl", IsNullable = false, Namespace = "")]
    public string AudioFileUrl {
        get => _audioFileUrl;
        set {
            AudioFileUrlSpecified = true;
            _audioFileUrl = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileUrlSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

    [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection {
        get => _videoSelection;
        set {
            VideoSelectionSpecified = true;
            _videoSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
    private string _videoFileUrl;

    [XmlElement(ElementName = "videoFileUrl", IsNullable = false, Namespace = "")]
    public string VideoFileUrl {
        get => _videoFileUrl;
        set {
            VideoFileUrlSpecified = true;
            _videoFileUrl = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileUrlSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingAudioSelection;

    [XmlElement(ElementName = "callWaitingAudioSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingAudioSelection {
        get => _callWaitingAudioSelection;
        set {
            CallWaitingAudioSelectionSpecified = true;
            _callWaitingAudioSelection = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingAudioSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _callWaitingAudioFile;

    [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingAudioFile {
        get => _callWaitingAudioFile;
        set {
            CallWaitingAudioFileSpecified = true;
            _callWaitingAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingAudioFileSpecified { get; set; }
    private string _callWaitingAudioFileUrl;

    [XmlElement(ElementName = "callWaitingAudioFileUrl", IsNullable = false, Namespace = "")]
    public string CallWaitingAudioFileUrl {
        get => _callWaitingAudioFileUrl;
        set {
            CallWaitingAudioFileUrlSpecified = true;
            _callWaitingAudioFileUrl = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingAudioFileUrlSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection _callWaitingVideoSelection;

    [XmlElement(ElementName = "callWaitingVideoSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedFileResourceSelection CallWaitingVideoSelection {
        get => _callWaitingVideoSelection;
        set {
            CallWaitingVideoSelectionSpecified = true;
            _callWaitingVideoSelection = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingVideoSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey _callWaitingVideoFile;

    [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileLevelKey CallWaitingVideoFile {
        get => _callWaitingVideoFile;
        set {
            CallWaitingVideoFileSpecified = true;
            _callWaitingVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingVideoFileSpecified { get; set; }
    private string _callWaitingVideoFileUrl;

    [XmlElement(ElementName = "callWaitingVideoFileUrl", IsNullable = false, Namespace = "")]
    public string CallWaitingVideoFileUrl {
        get => _callWaitingVideoFileUrl;
        set {
            CallWaitingVideoFileUrlSpecified = true;
            _callWaitingVideoFileUrl = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingVideoFileUrlSpecified { get; set; }
}
}
