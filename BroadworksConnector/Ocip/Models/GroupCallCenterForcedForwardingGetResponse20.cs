using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterForcedForwardingGetResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
    private bool _allowEnableViaFAC;

    [XmlElement(ElementName = "allowEnableViaFAC", IsNullable = false, Namespace = "")]
    public bool AllowEnableViaFAC {
        get => _allowEnableViaFAC;
        set {
            AllowEnableViaFACSpecified = true;
            _allowEnableViaFAC = value;
        }
    }

    [XmlIgnore]
    public bool AllowEnableViaFACSpecified { get; set; }
    private bool _playAnnouncementBeforeForwarding;

    [XmlElement(ElementName = "playAnnouncementBeforeForwarding", IsNullable = false, Namespace = "")]
    public bool PlayAnnouncementBeforeForwarding {
        get => _playAnnouncementBeforeForwarding;
        set {
            PlayAnnouncementBeforeForwardingSpecified = true;
            _playAnnouncementBeforeForwarding = value;
        }
    }

    [XmlIgnore]
    public bool PlayAnnouncementBeforeForwardingSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _audioFileList;

    [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 AudioFileList {
        get => _audioFileList;
        set {
            AudioFileListSpecified = true;
            _audioFileList = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileListSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 _videoFileList;

    [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterAnnouncementFileListRead20 VideoFileList {
        get => _videoFileList;
        set {
            VideoFileListSpecified = true;
            _videoFileList = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileListSpecified { get; set; }
}
}
