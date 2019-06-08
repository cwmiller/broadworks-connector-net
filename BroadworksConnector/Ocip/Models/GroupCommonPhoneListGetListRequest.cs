using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCommonPhoneListGetListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> _searchCriteriaGroupCommonPhoneListName;

    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListName> SearchCriteriaGroupCommonPhoneListName {
        get => _searchCriteriaGroupCommonPhoneListName;
        set {
            SearchCriteriaGroupCommonPhoneListNameSpecified = true;
            _searchCriteriaGroupCommonPhoneListName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupCommonPhoneListNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> _searchCriteriaGroupCommonPhoneListNumber;

    [XmlElement(ElementName = "searchCriteriaGroupCommonPhoneListNumber", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupCommonPhoneListNumber> SearchCriteriaGroupCommonPhoneListNumber {
        get => _searchCriteriaGroupCommonPhoneListNumber;
        set {
            SearchCriteriaGroupCommonPhoneListNumberSpecified = true;
            _searchCriteriaGroupCommonPhoneListNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupCommonPhoneListNumberSpecified { get; set; }
}
}
