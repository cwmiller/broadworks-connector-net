using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.AnnouncementFileKey _announcementFileKey;

    [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey {
        get => _announcementFileKey;
        set {
            AnnouncementFileKeySpecified = true;
            _announcementFileKey = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementFileKeySpecified { get; set; }
    private string _newAnnouncementFileName;

    [XmlElement(ElementName = "newAnnouncementFileName", IsNullable = false, Namespace = "")]
    public string NewAnnouncementFileName {
        get => _newAnnouncementFileName;
        set {
            NewAnnouncementFileNameSpecified = true;
            _newAnnouncementFileName = value;
        }
    }

    [XmlIgnore]
    public bool NewAnnouncementFileNameSpecified { get; set; }
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
