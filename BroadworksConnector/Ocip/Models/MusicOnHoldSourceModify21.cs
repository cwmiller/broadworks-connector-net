using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceModify21 
{
    private BroadworksConnector.Ocip.Models.AudioFileCodecExtended _audioFilePreferredCodec;

    [XmlElement(ElementName = "audioFilePreferredCodec", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AudioFileCodecExtended AudioFilePreferredCodec {
        get => _audioFilePreferredCodec;
        set {
            AudioFilePreferredCodecSpecified = true;
            _audioFilePreferredCodec = value;
        }
    }

    [XmlIgnore]
    public bool AudioFilePreferredCodecSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection _messageSourceSelection;

    [XmlElement(ElementName = "messageSourceSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldMessageSelection MessageSourceSelection {
        get => _messageSourceSelection;
        set {
            MessageSourceSelectionSpecified = true;
            _messageSourceSelection = value;
        }
    }

    [XmlIgnore]
    public bool MessageSourceSelectionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldSourceModify21LabeledCustomSourceMediaFiles _labeledCustomSourceMediaFiles;

    [XmlElement(ElementName = "labeledCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceModify21LabeledCustomSourceMediaFiles LabeledCustomSourceMediaFiles {
        get => _labeledCustomSourceMediaFiles;
        set {
            LabeledCustomSourceMediaFilesSpecified = true;
            _labeledCustomSourceMediaFiles = value;
        }
    }

    [XmlIgnore]
    public bool LabeledCustomSourceMediaFilesSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldSourceModify21AnnouncementCustomSourceMediaFiles _announcementCustomSourceMediaFiles;

    [XmlElement(ElementName = "announcementCustomSourceMediaFiles", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceModify21AnnouncementCustomSourceMediaFiles AnnouncementCustomSourceMediaFiles {
        get => _announcementCustomSourceMediaFiles;
        set {
            AnnouncementCustomSourceMediaFilesSpecified = true;
            _announcementCustomSourceMediaFiles = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementCustomSourceMediaFilesSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MusicOnHoldSourceModify21ExternalSource _externalSource;

    [XmlElement(ElementName = "externalSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MusicOnHoldSourceModify21ExternalSource ExternalSource {
        get => _externalSource;
        set {
            ExternalSourceSpecified = true;
            _externalSource = value;
        }
    }

    [XmlIgnore]
    public bool ExternalSourceSpecified { get; set; }
}
}
