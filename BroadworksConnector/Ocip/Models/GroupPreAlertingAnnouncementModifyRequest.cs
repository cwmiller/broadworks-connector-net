using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreAlertingAnnouncementModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private string _groupId;

    [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
    public string GroupId {
        get => _groupId;
        set {
            GroupIdSpecified = true;
            _groupId = value;
        }
    }

    [XmlIgnore]
    public bool GroupIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.PreAlertingAnnouncementInterrupt _announcementInterruption;

    [XmlElement(ElementName = "announcementInterruption", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.PreAlertingAnnouncementInterrupt AnnouncementInterruption {
        get => _announcementInterruption;
        set {
            AnnouncementInterruptionSpecified = true;
            _announcementInterruption = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementInterruptionSpecified { get; set; }
    private string _interruptionDigitSequence;

    [XmlElement(ElementName = "interruptionDigitSequence", IsNullable = false, Namespace = "")]
    public string InterruptionDigitSequence {
        get => _interruptionDigitSequence;
        set {
            InterruptionDigitSequenceSpecified = true;
            _interruptionDigitSequence = value;
        }
    }

    [XmlIgnore]
    public bool InterruptionDigitSequenceSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _audioSelection;

    [XmlElement(ElementName = "audioSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection AudioSelection {
        get => _audioSelection;
        set {
            AudioSelectionSpecified = true;
            _audioSelection = value;
        }
    }

    [XmlIgnore]
    public bool AudioSelectionSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection _videoSelection;

    [XmlElement(ElementName = "videoSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ExtendedFileResourceSelection VideoSelection {
        get => _videoSelection;
        set {
            VideoSelectionSpecified = true;
            _videoSelection = value;
        }
    }

    [XmlIgnore]
    public bool VideoSelectionSpecified { get; set; }
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
