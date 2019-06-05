using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderAdminGetPolicyResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _profileAccess;

    [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ProfileAccess {
        get => _profileAccess;
        set {
            ProfileAccessSpecified = true;
            _profileAccess = value;
        }
    }

    [XmlIgnore]
    public bool ProfileAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _groupAccess;

    [XmlElement(ElementName = "groupAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess GroupAccess {
        get => _groupAccess;
        set {
            GroupAccessSpecified = true;
            _groupAccess = value;
        }
    }

    [XmlIgnore]
    public bool GroupAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess _userAccess;

    [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess UserAccess {
        get => _userAccess;
        set {
            UserAccessSpecified = true;
            _userAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _adminAccess;

    [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess AdminAccess {
        get => _adminAccess;
        set {
            AdminAccessSpecified = true;
            _adminAccess = value;
        }
    }

    [XmlIgnore]
    public bool AdminAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _departmentAccess;

    [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess DepartmentAccess {
        get => _departmentAccess;
        set {
            DepartmentAccessSpecified = true;
            _departmentAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _accessDeviceAccess;

    [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess AccessDeviceAccess {
        get => _accessDeviceAccess;
        set {
            AccessDeviceAccessSpecified = true;
            _accessDeviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

    [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess {
        get => _phoneNumberExtensionAccess;
        set {
            PhoneNumberExtensionAccessSpecified = true;
            _phoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberExtensionAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess _callingLineIdNumberAccess;

    [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess CallingLineIdNumberAccess {
        get => _callingLineIdNumberAccess;
        set {
            CallingLineIdNumberAccessSpecified = true;
            _callingLineIdNumberAccess = value;
        }
    }

    [XmlIgnore]
    public bool CallingLineIdNumberAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceAccess;

    [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceAccess {
        get => _serviceAccess;
        set {
            ServiceAccessSpecified = true;
            _serviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _servicePackAccess;

    [XmlElement(ElementName = "servicePackAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServicePackAccess {
        get => _servicePackAccess;
        set {
            ServicePackAccessSpecified = true;
            _servicePackAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServicePackAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess _sessionAdmissionControlAccess;

    [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess SessionAdmissionControlAccess {
        get => _sessionAdmissionControlAccess;
        set {
            SessionAdmissionControlAccessSpecified = true;
            _sessionAdmissionControlAccess = value;
        }
    }

    [XmlIgnore]
    public bool SessionAdmissionControlAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _webBrandingAccess;

    [XmlElement(ElementName = "webBrandingAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess WebBrandingAccess {
        get => _webBrandingAccess;
        set {
            WebBrandingAccessSpecified = true;
            _webBrandingAccess = value;
        }
    }

    [XmlIgnore]
    public bool WebBrandingAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess _officeZoneAccess;

    [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess OfficeZoneAccess {
        get => _officeZoneAccess;
        set {
            OfficeZoneAccessSpecified = true;
            _officeZoneAccess = value;
        }
    }

    [XmlIgnore]
    public bool OfficeZoneAccessSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _networkPolicyAccess;

    [XmlElement(ElementName = "networkPolicyAccess", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess NetworkPolicyAccess {
        get => _networkPolicyAccess;
        set {
            NetworkPolicyAccessSpecified = true;
            _networkPolicyAccess = value;
        }
    }

    [XmlIgnore]
    public bool NetworkPolicyAccessSpecified { get; set; }
}
}
