using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationLockoutGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
        get => _searchCriteriaServiceProviderId;
        set {
            SearchCriteriaServiceProviderIdSpecified = true;
            _searchCriteriaServiceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

    [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType {
        get => _searchCriteriaExactOrganizationType;
        set {
            SearchCriteriaExactOrganizationTypeSpecified = true;
            _searchCriteriaExactOrganizationType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactOrganizationTypeSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> _searchCriteriaDeviceName;

    [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName {
        get => _searchCriteriaDeviceName;
        set {
            SearchCriteriaDeviceNameSpecified = true;
            _searchCriteriaDeviceName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType _searchCriteriaExactDeviceType;

    [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactDeviceType SearchCriteriaExactDeviceType {
        get => _searchCriteriaExactDeviceType;
        set {
            SearchCriteriaExactDeviceTypeSpecified = true;
            _searchCriteriaExactDeviceType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactDeviceTypeSpecified { get; set; }
}
}
