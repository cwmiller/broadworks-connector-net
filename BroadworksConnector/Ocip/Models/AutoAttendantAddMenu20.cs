using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class AutoAttendantAddMenu20 
{
    private BroadWorksConnector.Ocip.Models.AnnouncementSelection _announcementSelection;

    [XmlElement(ElementName = "announcementSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementSelection AnnouncementSelection {
        get => _announcementSelection;
        set {
            AnnouncementSelectionSpecified = true;
            _announcementSelection = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementSelectionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementFileLevelKey VideoFile {
        get => _videoFile;
        set {
            VideoFileSpecified = true;
            _videoFile = value;
        }
    }

    [XmlIgnore]
    public bool VideoFileSpecified { get; set; }
    private bool _enableFirstMenuLevelExtensionDialing;

    [XmlElement(ElementName = "enableFirstMenuLevelExtensionDialing", IsNullable = false, Namespace = "")]
    public bool EnableFirstMenuLevelExtensionDialing {
        get => _enableFirstMenuLevelExtensionDialing;
        set {
            EnableFirstMenuLevelExtensionDialingSpecified = true;
            _enableFirstMenuLevelExtensionDialing = value;
        }
    }

    [XmlIgnore]
    public bool EnableFirstMenuLevelExtensionDialingSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration20> _keyConfiguration;

    [XmlElement(ElementName = "keyConfiguration", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.AutoAttendantKeyConfiguration20> KeyConfiguration {
        get => _keyConfiguration;
        set {
            KeyConfigurationSpecified = true;
            _keyConfiguration = value;
        }
    }

    [XmlIgnore]
    public bool KeyConfigurationSpecified { get; set; }
}
}