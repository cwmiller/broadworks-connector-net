using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class MusicOnHoldSourceAdd16CustomSource 
{
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _audioFile;

    [XmlElement(ElementName = "audioFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AudioFile {
        get => _audioFile;
        set {
            AudioFileSpecified = true;
            _audioFile = value;
        }
    }

    [XmlIgnore]
    public bool AudioFileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _videoFile;

    [XmlElement(ElementName = "videoFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource VideoFile {
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
