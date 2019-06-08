using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemDeviceProfileAuthenticationLockoutGetRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> _searchCriteriaServiceProviderId;

    [XmlElement(ElementName = "searchCriteriaServiceProviderId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaServiceProviderId> SearchCriteriaServiceProviderId {
        get => _searchCriteriaServiceProviderId;
        set {
            SearchCriteriaServiceProviderIdSpecified = true;
            _searchCriteriaServiceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaServiceProviderIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType _searchCriteriaExactOrganizationType;

    [XmlElement(ElementName = "searchCriteriaExactOrganizationType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactOrganizationType SearchCriteriaExactOrganizationType {
        get => _searchCriteriaExactOrganizationType;
        set {
            SearchCriteriaExactOrganizationTypeSpecified = true;
            _searchCriteriaExactOrganizationType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactOrganizationTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> _searchCriteriaGroupId;

    [XmlElement(ElementName = "searchCriteriaGroupId", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaGroupId> SearchCriteriaGroupId {
        get => _searchCriteriaGroupId;
        set {
            SearchCriteriaGroupIdSpecified = true;
            _searchCriteriaGroupId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaGroupIdSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> _searchCriteriaDeviceName;

    [XmlElement(ElementName = "searchCriteriaDeviceName", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaDeviceName> SearchCriteriaDeviceName {
        get => _searchCriteriaDeviceName;
        set {
            SearchCriteriaDeviceNameSpecified = true;
            _searchCriteriaDeviceName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaDeviceNameSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType _searchCriteriaExactDeviceType;

    [XmlElement(ElementName = "searchCriteriaExactDeviceType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SearchCriteriaExactDeviceType SearchCriteriaExactDeviceType {
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
