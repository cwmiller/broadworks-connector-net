using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSecurityClassificationGetClassificationResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _audioAnnouncementFileDescription;

    [XmlElement(ElementName = "audioAnnouncementFileDescription", IsNullable = false, Namespace = "")]
    public string AudioAnnouncementFileDescription {
        get => _audioAnnouncementFileDescription;
        set {
            AudioAnnouncementFileDescriptionSpecified = true;
            _audioAnnouncementFileDescription = value;
        }
    }

    [XmlIgnore]
    public bool AudioAnnouncementFileDescriptionSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.MediaFileType _audioAnnouncementFileType;

    [XmlElement(ElementName = "audioAnnouncementFileType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MediaFileType AudioAnnouncementFileType {
        get => _audioAnnouncementFileType;
        set {
            AudioAnnouncementFileTypeSpecified = true;
            _audioAnnouncementFileType = value;
        }
    }

    [XmlIgnore]
    public bool AudioAnnouncementFileTypeSpecified { get; set; }
}
}
