using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterStrandedCallGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.CallCenterStrandedCallProcessingAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterStrandedCallProcessingAction Action {
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
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _audioUrlList;

    [XmlElement(ElementName = "audioUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList AudioUrlList {
        get => _audioUrlList;
        set {
            AudioUrlListSpecified = true;
            _audioUrlList = value;
        }
    }

    [XmlIgnore]
    public bool AudioUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _audioFileList;

    [XmlElement(ElementName = "audioFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList AudioFileList {
        get => _audioFileList;
        set {
            AudioFileListSpecified = true;
            _audioFileList = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _audioMediaTypeList;

    [XmlElement(ElementName = "audioMediaTypeList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList AudioMediaTypeList {
        get => _audioMediaTypeList;
        set {
            AudioMediaTypeListSpecified = true;
            _audioMediaTypeList = value;
        }
    }

    [XmlIgnore]
    public bool AudioMediaTypeListSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList _videoUrlList;

    [XmlElement(ElementName = "videoUrlList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementURLList VideoUrlList {
        get => _videoUrlList;
        set {
            VideoUrlListSpecified = true;
            _videoUrlList = value;
        }
    }

    [XmlIgnore]
    public bool VideoUrlListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList _videoFileList;

    [XmlElement(ElementName = "videoFileList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementDescriptionList VideoFileList {
        get => _videoFileList;
        set {
            VideoFileListSpecified = true;
            _videoFileList = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileListSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList _videoMediaTypeList;

    [XmlElement(ElementName = "videoMediaTypeList", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterAnnouncementMediaFileTypeList VideoMediaTypeList {
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
