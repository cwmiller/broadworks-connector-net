using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _announcementFileName;

    [XmlElement(ElementName = "announcementFileName", IsNullable = false, Namespace = "")]
    public string AnnouncementFileName {
        get => _announcementFileName;
        set {
            AnnouncementFileNameSpecified = true;
            _announcementFileName = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementFileNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.LabeledMediaFileResource _announcementFile;

    [XmlElement(ElementName = "announcementFile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile {
        get => _announcementFile;
        set {
            AnnouncementFileSpecified = true;
            _announcementFile = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementFileSpecified { get; set; }
}
}
