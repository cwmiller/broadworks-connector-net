using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCustomRingbackUserAddCriteriaRequest16 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _criteriaName;

    [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
    public string CriteriaName {
        get => _criteriaName;
        set {
            CriteriaNameSpecified = true;
            _criteriaName = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaNameSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.ExtendedMediaFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.ExtendedMediaFileResource _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.ExtendedMediaFileResource _callWaitingAudioFile;

    [XmlElement(ElementName = "callWaitingAudioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource CallWaitingAudioFile {
        get => _callWaitingAudioFile;
        set {
            CallWaitingAudioFileSpecified = true;
            _callWaitingAudioFile = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingAudioFileSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.ExtendedMediaFileResource _callWaitingVideoFile;

    [XmlElement(ElementName = "callWaitingVideoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ExtendedMediaFileResource CallWaitingVideoFile {
        get => _callWaitingVideoFile;
        set {
            CallWaitingVideoFileSpecified = true;
            _callWaitingVideoFile = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingVideoFileSpecified { get; set; }
}
}
