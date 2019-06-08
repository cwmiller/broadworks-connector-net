using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterMediaOnHoldSourceRead17 
{
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _audioMessageSourceSelection;

    [XmlElement(ElementName = "audioMessageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection AudioMessageSourceSelection {
        get => _audioMessageSourceSelection;
        set {
            AudioMessageSourceSelectionSpecified = true;
            _audioMessageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioMessageSourceSelectionSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalAudioSource;

    [XmlElement(ElementName = "externalAudioSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalAudioSource {
        get => _externalAudioSource;
        set {
            ExternalAudioSourceSpecified = true;
            _externalAudioSource = value;
        }
    }

    [XmlIgnore]
    public bool ExternalAudioSourceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection _videoMessageSourceSelection;

    [XmlElement(ElementName = "videoMessageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterMediaOnHoldMessageSelection VideoMessageSourceSelection {
        get => _videoMessageSourceSelection;
        set {
            VideoMessageSourceSelectionSpecified = true;
            _videoMessageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoMessageSourceSelectionSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 _externalVideoSource;

    [XmlElement(ElementName = "externalVideoSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointRead14 ExternalVideoSource {
        get => _externalVideoSource;
        set {
            ExternalVideoSourceSpecified = true;
            _externalVideoSource = value;
        }
    }

    [XmlIgnore]
    public bool ExternalVideoSourceSpecified { get; set; }
}
}
