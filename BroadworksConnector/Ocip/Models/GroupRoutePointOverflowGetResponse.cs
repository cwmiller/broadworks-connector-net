using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointOverflowGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.CallCenterOverflowProcessingAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterOverflowProcessingAction Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private string _transferPhoneNumber;

    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
    public string TransferPhoneNumber {
        get => _transferPhoneNumber;
        set {
            TransferPhoneNumberSpecified = true;
            _transferPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferPhoneNumberSpecified { get; set; }
    private bool _overflowAfterTimeout;

    [XmlElement(ElementName = "overflowAfterTimeout", IsNullable = false, Namespace = "")]
    public bool OverflowAfterTimeout {
        get => _overflowAfterTimeout;
        set {
            OverflowAfterTimeoutSpecified = true;
            _overflowAfterTimeout = value;
        }
    }

    [XmlIgnore]
    public bool OverflowAfterTimeoutSpecified { get; set; }
    private int _timeoutSeconds;

    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
    public int TimeoutSeconds {
        get => _timeoutSeconds;
        set {
            TimeoutSecondsSpecified = true;
            _timeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeoutSecondsSpecified { get; set; }
    private bool _playAnnouncementBeforeOverflowProcessing;

    [XmlElement(ElementName = "playAnnouncementBeforeOverflowProcessing", IsNullable = false, Namespace = "")]
    public bool PlayAnnouncementBeforeOverflowProcessing {
        get => _playAnnouncementBeforeOverflowProcessing;
        set {
            PlayAnnouncementBeforeOverflowProcessingSpecified = true;
            _playAnnouncementBeforeOverflowProcessing = value;
        }
    }

    [XmlIgnore]
    public bool PlayAnnouncementBeforeOverflowProcessingSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

    [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList {
        get => _audioUrlList;
        set {
            AudioUrlListSpecified = true;
            _audioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool AudioUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _audioFileList;

    [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList AudioFileList {
        get => _audioFileList;
        set {
            AudioFileListSpecified = true;
            _audioFileList = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _audioMediaTypeList;

    [XmlElement(ElementName = "audioMediaTypeList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList AudioMediaTypeList {
        get => _audioMediaTypeList;
        set {
            AudioMediaTypeListSpecified = true;
            _audioMediaTypeList = value;
        }
    }

    [XmlIgnore]
    public bool AudioMediaTypeListSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

    [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList {
        get => _videoUrlList;
        set {
            VideoUrlListSpecified = true;
            _videoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool VideoUrlListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _videoFileList;

    [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList VideoFileList {
        get => _videoFileList;
        set {
            VideoFileListSpecified = true;
            _videoFileList = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileListSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _videoMediaTypeList;

    [XmlElement(ElementName = "videoMediaTypeList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList VideoMediaTypeList {
        get => _videoMediaTypeList;
        set {
            VideoMediaTypeListSpecified = true;
            _videoMediaTypeList = value;
        }
    }

    [XmlIgnore]
    public bool VideoMediaTypeListSpecified { get; set; }
}
}
