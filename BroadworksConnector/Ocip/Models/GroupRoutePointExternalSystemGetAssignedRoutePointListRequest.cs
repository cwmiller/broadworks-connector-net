using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointExternalSystemGetAssignedRoutePointListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _externalSystem;

    [XmlElement(ElementName = "externalSystem", IsNullable = false, Namespace = "")]
    public string ExternalSystem {
        get => _externalSystem;
        set {
            ExternalSystemSpecified = true;
            _externalSystem = value;
        }
    }

    [XmlIgnore]
    public bool ExternalSystemSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaRoutePointName> _searchCriteriaRoutePointName;

    [XmlElement(ElementName = "searchCriteriaRoutePointName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaRoutePointName> SearchCriteriaRoutePointName {
        get => _searchCriteriaRoutePointName;
        set {
            SearchCriteriaRoutePointNameSpecified = true;
            _searchCriteriaRoutePointName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaRoutePointNameSpecified { get; set; }
}
}
