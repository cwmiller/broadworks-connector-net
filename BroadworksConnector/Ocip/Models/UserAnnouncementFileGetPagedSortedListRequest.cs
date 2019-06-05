using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAnnouncementFileGetPagedSortedListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ResponsePagingControl _responsePagingControl;

    [XmlElement(ElementName = "responsePagingControl", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ResponsePagingControl ResponsePagingControl {
        get => _responsePagingControl;
        set {
            ResponsePagingControlSpecified = true;
            _responsePagingControl = value;
        }
    }

    [XmlIgnore]
    public bool ResponsePagingControlSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByAnnouncementFileName _sortByAnnouncementFileName;

    [XmlElement(ElementName = "sortByAnnouncementFileName", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByAnnouncementFileName SortByAnnouncementFileName {
        get => _sortByAnnouncementFileName;
        set {
            SortByAnnouncementFileNameSpecified = true;
            _sortByAnnouncementFileName = value;
        }
    }

    [XmlIgnore]
    public bool SortByAnnouncementFileNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SortByAnnouncementFileSize _sortByAnnouncementFileSize;

    [XmlElement(ElementName = "sortByAnnouncementFileSize", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SortByAnnouncementFileSize SortByAnnouncementFileSize {
        get => _sortByAnnouncementFileSize;
        set {
            SortByAnnouncementFileSizeSpecified = true;
            _sortByAnnouncementFileSize = value;
        }
    }

    [XmlIgnore]
    public bool SortByAnnouncementFileSizeSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType _searchCriteriaExactAnnouncementFileType;

    [XmlElement(ElementName = "searchCriteriaExactAnnouncementFileType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactAnnouncementFileType SearchCriteriaExactAnnouncementFileType {
        get => _searchCriteriaExactAnnouncementFileType;
        set {
            SearchCriteriaExactAnnouncementFileTypeSpecified = true;
            _searchCriteriaExactAnnouncementFileType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactAnnouncementFileTypeSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaExactMediaFileType> _searchCriteriaExactMediaFileType;

    [XmlElement(ElementName = "searchCriteriaExactMediaFileType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExactMediaFileType> SearchCriteriaExactMediaFileType {
        get => _searchCriteriaExactMediaFileType;
        set {
            SearchCriteriaExactMediaFileTypeSpecified = true;
            _searchCriteriaExactMediaFileType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactMediaFileTypeSpecified { get; set; }
    private bool _searchCriteriaModeOr;

    [XmlElement(ElementName = "searchCriteriaModeOr", IsNullable = false, Namespace = "")]
    public bool SearchCriteriaModeOr {
        get => _searchCriteriaModeOr;
        set {
            SearchCriteriaModeOrSpecified = true;
            _searchCriteriaModeOr = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaModeOrSpecified { get; set; }
}
}
