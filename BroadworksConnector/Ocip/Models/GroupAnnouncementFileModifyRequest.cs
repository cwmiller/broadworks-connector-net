using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAnnouncementFileModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.AnnouncementFileKey _announcementFileKey;

    [XmlElement(ElementName = "announcementFileKey", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AnnouncementFileKey AnnouncementFileKey {
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
    private BroadWorksConnector.Ocip.Models.LabeledMediaFileResource _announcementFile;

    [XmlElement(ElementName = "announcementFile", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.LabeledMediaFileResource AnnouncementFile {
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
