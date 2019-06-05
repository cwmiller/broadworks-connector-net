using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCustomRingbackUserGetCriteriaResponse15sp2 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private string _audioFileDescription;

    [XmlElement(ElementName = "audioFileDescription", IsNullable = false, Namespace = "")]
    public string AudioFileDescription {
        get => _audioFileDescription;
        set {
            AudioFileDescriptionSpecified = true;
            _audioFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileDescriptionSpecified { get; set; }
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
    private string _videoFileDescription;

    [XmlElement(ElementName = "videoFileDescription", IsNullable = false, Namespace = "")]
    public string VideoFileDescription {
        get => _videoFileDescription;
        set {
            VideoFileDescriptionSpecified = true;
            _videoFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileDescriptionSpecified { get; set; }
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
    private string _callWaitingAudioFileDescription;

    [XmlElement(ElementName = "callWaitingAudioFileDescription", IsNullable = false, Namespace = "")]
    public string CallWaitingAudioFileDescription {
        get => _callWaitingAudioFileDescription;
        set {
            CallWaitingAudioFileDescriptionSpecified = true;
            _callWaitingAudioFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingAudioFileDescriptionSpecified { get; set; }
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
    private string _callWaitingVideoFileDescription;

    [XmlElement(ElementName = "callWaitingVideoFileDescription", IsNullable = false, Namespace = "")]
    public string CallWaitingVideoFileDescription {
        get => _callWaitingVideoFileDescription;
        set {
            CallWaitingVideoFileDescriptionSpecified = true;
            _callWaitingVideoFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool CallWaitingVideoFileDescriptionSpecified { get; set; }
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
