using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceModify21AnnouncementCustomSourceMediaFiles 
{
    private BroadworksConnector.Ocip.Models.AnnouncementFileKey _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AnnouncementFileKey _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey VideoFile {
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
