using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemGetRegistrationContactListRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
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
    private string _svcProviderId;

    [XmlElement(ElementName = "svcProviderId", IsNullable = false, Namespace = "")]
    public string SvcProviderId {
        get => _svcProviderId;
        set {
            SvcProviderIdSpecified = true;
            _svcProviderId = value;
        }
    }

    [XmlIgnore]
    public bool SvcProviderIdSpecified { get; set; }
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
    private string _linePort;

    [XmlElement(ElementName = "linePort", IsNullable = false, Namespace = "")]
    public string LinePort {
        get => _linePort;
        set {
            LinePortSpecified = true;
            _linePort = value;
        }
    }

    [XmlIgnore]
    public bool LinePortSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AccessDeviceLevel _deviceLevel;

    [XmlElement(ElementName = "deviceLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceLevel DeviceLevel {
        get => _deviceLevel;
        set {
            DeviceLevelSpecified = true;
            _deviceLevel = value;
        }
    }

    [XmlIgnore]
    public bool DeviceLevelSpecified { get; set; }
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
    private string _deviceType;

    [XmlElement(ElementName = "deviceType", IsNullable = false, Namespace = "")]
    public string DeviceType {
        get => _deviceType;
        set {
            DeviceTypeSpecified = true;
            _deviceType = value;
        }
    }

    [XmlIgnore]
    public bool DeviceTypeSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaRegistrationURI> _searchCriteriaRegistrationURI;

    [XmlElement(ElementName = "searchCriteriaRegistrationURI", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaRegistrationURI> SearchCriteriaRegistrationURI {
        get => _searchCriteriaRegistrationURI;
        set {
            SearchCriteriaRegistrationURISpecified = true;
            _searchCriteriaRegistrationURI = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaRegistrationURISpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.SearchCriteriaSIPContact> _searchCriteriaSIPContact;

    [XmlElement(ElementName = "searchCriteriaSIPContact", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.SearchCriteriaSIPContact> SearchCriteriaSIPContact {
        get => _searchCriteriaSIPContact;
        set {
            SearchCriteriaSIPContactSpecified = true;
            _searchCriteriaSIPContact = value;
        }
    }

    [XmlIgnore]
    public bool SearchCriteriaSIPContactSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.RegistrationEndpointType _endpointType;

    [XmlElement(ElementName = "endpointType", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.RegistrationEndpointType EndpointType {
        get => _endpointType;
        set {
            EndpointTypeSpecified = true;
            _endpointType = value;
        }
    }

    [XmlIgnore]
    public bool EndpointTypeSpecified { get; set; }
    private bool _expired;

    [XmlElement(ElementName = "expired", IsNullable = false, Namespace = "")]
    public bool Expired {
        get => _expired;
        set {
            ExpiredSpecified = true;
            _expired = value;
        }
    }

    [XmlIgnore]
    public bool ExpiredSpecified { get; set; }
}
}
