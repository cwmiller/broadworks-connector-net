using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityMobileSubscriberDirectoryNumberGetSummaryListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> _searchCriteriaMobileSubscriberDirectoryNumber;

    [XmlElement(ElementName = "searchCriteriaMobileSubscriberDirectoryNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaMobileSubscriberDirectoryNumber> SearchCriteriaMobileSubscriberDirectoryNumber {
        get => _searchCriteriaMobileSubscriberDirectoryNumber;
        set {
            SearchCriteriaMobileSubscriberDirectoryNumberSpecified = true;
            _searchCriteriaMobileSubscriberDirectoryNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaMobileSubscriberDirectoryNumberSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork _searchCriteriaExactMobileNetwork;

    [XmlElement(ElementName = "searchCriteriaExactMobileNetwork", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactMobileNetwork SearchCriteriaExactMobileNetwork {
        get => _searchCriteriaExactMobileNetwork;
        set {
            SearchCriteriaExactMobileNetworkSpecified = true;
            _searchCriteriaExactMobileNetwork = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactMobileNetworkSpecified { get; set; }
}
}
