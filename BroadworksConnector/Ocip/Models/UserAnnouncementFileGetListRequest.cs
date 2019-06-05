using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.AnnouncementFileType _announcementFileType;

    [XmlElement(ElementName = "announcementFileType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AnnouncementFileType AnnouncementFileType {
        get => _announcementFileType;
        set {
            AnnouncementFileTypeSpecified = true;
            _announcementFileType = value;
        }
    }

    [XmlIgnore]
    public bool AnnouncementFileTypeSpecified { get; set; }
    private bool _includeAnnouncementTable;

    [XmlElement(ElementName = "includeAnnouncementTable", IsNullable = false, Namespace = "")]
    public bool IncludeAnnouncementTable {
        get => _includeAnnouncementTable;
        set {
            IncludeAnnouncementTableSpecified = true;
            _includeAnnouncementTable = value;
        }
    }

    [XmlIgnore]
    public bool IncludeAnnouncementTableSpecified { get; set; }
    private int _responseSizeLimit;

    [XmlElement(ElementName = "responseSizeLimit", IsNullable = false, Namespace = "")]
    public int ResponseSizeLimit {
        get => _responseSizeLimit;
        set {
            ResponseSizeLimitSpecified = true;
            _responseSizeLimit = value;
        }
    }

    [XmlIgnore]
    public bool ResponseSizeLimitSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> _searchCriteriaAnnouncementFileName;

    [XmlElement(ElementName = "searchCriteriaAnnouncementFileName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAnnouncementFileName> SearchCriteriaAnnouncementFileName {
        get => _searchCriteriaAnnouncementFileName;
        set {
            SearchCriteriaAnnouncementFileNameSpecified = true;
            _searchCriteriaAnnouncementFileName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaAnnouncementFileNameSpecified { get; set; }
}
}
