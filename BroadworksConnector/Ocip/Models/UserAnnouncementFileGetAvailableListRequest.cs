using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileGetAvailableListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.AnnouncementFileType _announcementFileType;

    [XmlElement(ElementName = "announcementFileType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementFileType AnnouncementFileType {
        get => _announcementFileType;
        set {
            AnnouncementFileTypeSpecified = true;
            _announcementFileType = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementFileTypeSpecified { get; set; }
}
}
