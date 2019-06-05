using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDnGetSummaryListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
        get => _searchCriteriaGroupId;
        set {
            SearchCriteriaGroupIdSpecified = true;
            _searchCriteriaGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupIdSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> _searchCriteriaDn;

    [XmlElement(ElementName = "searchCriteriaDn", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDn> SearchCriteriaDn {
        get => _searchCriteriaDn;
        set {
            SearchCriteriaDnSpecified = true;
            _searchCriteriaDn = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDnSpecified { get; set; }
}
}
