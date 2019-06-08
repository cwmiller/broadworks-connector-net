using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPersonalPhoneListGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> _searchCriteriaUserPersonalPhoneListName;

    [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListName> SearchCriteriaUserPersonalPhoneListName {
        get => _searchCriteriaUserPersonalPhoneListName;
        set {
            SearchCriteriaUserPersonalPhoneListNameSpecified = true;
            _searchCriteriaUserPersonalPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserPersonalPhoneListNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> _searchCriteriaUserPersonalPhoneListNumber;

    [XmlElement(ElementName = "searchCriteriaUserPersonalPhoneListNumber", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaUserPersonalPhoneListNumber> SearchCriteriaUserPersonalPhoneListNumber {
        get => _searchCriteriaUserPersonalPhoneListNumber;
        set {
            SearchCriteriaUserPersonalPhoneListNumberSpecified = true;
            _searchCriteriaUserPersonalPhoneListNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserPersonalPhoneListNumberSpecified { get; set; }
}
}
