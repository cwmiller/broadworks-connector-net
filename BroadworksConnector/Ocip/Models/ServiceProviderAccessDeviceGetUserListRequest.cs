using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAccessDeviceGetUserListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _deviceName;

    [XmlElement(ElementName = "deviceName", IsNullable = false, Namespace = "")]
    public string DeviceName {
        get => _deviceName;
        set {
            DeviceNameSpecified = true;
            _deviceName = value;
        }
    }

    [XmlIgnore]
    public bool DeviceNameSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaLinePortUserPart> _searchCriteriaLinePortUserPart;

    [XmlElement(ElementName = "searchCriteriaLinePortUserPart", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaLinePortUserPart> SearchCriteriaLinePortUserPart {
        get => _searchCriteriaLinePortUserPart;
        set {
            SearchCriteriaLinePortUserPartSpecified = true;
            _searchCriteriaLinePortUserPart = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaLinePortUserPartSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaLinePortDomain> _searchCriteriaLinePortDomain;

    [XmlElement(ElementName = "searchCriteriaLinePortDomain", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaLinePortDomain> SearchCriteriaLinePortDomain {
        get => _searchCriteriaLinePortDomain;
        set {
            SearchCriteriaLinePortDomainSpecified = true;
            _searchCriteriaLinePortDomain = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaLinePortDomainSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> _searchCriteriaUserLastName;

    [XmlElement(ElementName = "searchCriteriaUserLastName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserLastName> SearchCriteriaUserLastName {
        get => _searchCriteriaUserLastName;
        set {
            SearchCriteriaUserLastNameSpecified = true;
            _searchCriteriaUserLastName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserLastNameSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> _searchCriteriaUserFirstName;

    [XmlElement(ElementName = "searchCriteriaUserFirstName", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserFirstName> SearchCriteriaUserFirstName {
        get => _searchCriteriaUserFirstName;
        set {
            SearchCriteriaUserFirstNameSpecified = true;
            _searchCriteriaUserFirstName = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserFirstNameSpecified { get; set; }
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
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> _searchCriteriaUserId;

    [XmlElement(ElementName = "searchCriteriaUserId", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaUserId> SearchCriteriaUserId {
        get => _searchCriteriaUserId;
        set {
            SearchCriteriaUserIdSpecified = true;
            _searchCriteriaUserId = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaUserIdSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactEndpointType _searchCriteriaExactEndpointType;

    [XmlElement(ElementName = "searchCriteriaExactEndpointType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactEndpointType SearchCriteriaExactEndpointType {
        get => _searchCriteriaExactEndpointType;
        set {
            SearchCriteriaExactEndpointTypeSpecified = true;
            _searchCriteriaExactEndpointType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactEndpointTypeSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserType _searchCriteriaExactUserType;

    [XmlElement(ElementName = "searchCriteriaExactUserType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserType SearchCriteriaExactUserType {
        get => _searchCriteriaExactUserType;
        set {
            SearchCriteriaExactUserTypeSpecified = true;
            _searchCriteriaExactUserType = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserTypeSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> _searchCriteriaExtension;

    [XmlElement(ElementName = "searchCriteriaExtension", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaExtension> SearchCriteriaExtension {
        get => _searchCriteriaExtension;
        set {
            SearchCriteriaExtensionSpecified = true;
            _searchCriteriaExtension = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExtensionSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment _searchCriteriaExactUserDepartment;

    [XmlElement(ElementName = "searchCriteriaExactUserDepartment", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactUserDepartment SearchCriteriaExactUserDepartment {
        get => _searchCriteriaExactUserDepartment;
        set {
            SearchCriteriaExactUserDepartmentSpecified = true;
            _searchCriteriaExactUserDepartment = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactUserDepartmentSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.SearchCriteriaExactPortNumber _searchCriteriaExactPortNumber;

    [XmlElement(ElementName = "searchCriteriaExactPortNumber", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SearchCriteriaExactPortNumber SearchCriteriaExactPortNumber {
        get => _searchCriteriaExactPortNumber;
        set {
            SearchCriteriaExactPortNumberSpecified = true;
            _searchCriteriaExactPortNumber = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaExactPortNumberSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity> _searchCriteriaAccessDeviceEndpointPrivateIdentity;

    [XmlElement(ElementName = "searchCriteriaAccessDeviceEndpointPrivateIdentity", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SearchCriteriaAccessDeviceEndpointPrivateIdentity> SearchCriteriaAccessDeviceEndpointPrivateIdentity {
        get => _searchCriteriaAccessDeviceEndpointPrivateIdentity;
        set {
            SearchCriteriaAccessDeviceEndpointPrivateIdentitySpecified = true;
            _searchCriteriaAccessDeviceEndpointPrivateIdentity = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaAccessDeviceEndpointPrivateIdentitySpecified { get; set; }
}
}
