using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterStrandedCallGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.MediaFileType _audioMediaType;

    [XmlElement(ElementName = "audioMediaType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaFileType AudioMediaType {
        get => _audioMediaType;
        set {
            AudioMediaTypeSpecified = true;
            _audioMediaType = value;
        }
    }

    [XmlIgnore]
    public bool AudioMediaTypeSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.MediaFileType _videoMediaType;

    [XmlElement(ElementName = "videoMediaType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaFileType VideoMediaType {
        get => _videoMediaType;
        set {
            VideoMediaTypeSpecified = true;
            _videoMediaType = value;
        }
    }

    [XmlIgnore]
    public bool VideoMediaTypeSpecified { get; set; }
}
}
