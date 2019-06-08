using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupAdminGetPolicyResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess _profileAccess;

    [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess ProfileAccess {
        get => _profileAccess;
        set {
            ProfileAccessSpecified = true;
            _profileAccess = value;
        }
    }

    [XmlIgnore]
    public bool ProfileAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminUserAccess _userAccess;

    [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminUserAccess UserAccess {
        get => _userAccess;
        set {
            UserAccessSpecified = true;
            _userAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess _adminAccess;

    [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess AdminAccess {
        get => _adminAccess;
        set {
            AdminAccessSpecified = true;
            _adminAccess = value;
        }
    }

    [XmlIgnore]
    public bool AdminAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess _departmentAccess;

    [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess DepartmentAccess {
        get => _departmentAccess;
        set {
            DepartmentAccessSpecified = true;
            _departmentAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _accessDeviceAccess;

    [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess AccessDeviceAccess {
        get => _accessDeviceAccess;
        set {
            AccessDeviceAccessSpecified = true;
            _accessDeviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _enhancedServiceInstanceAccess;

    [XmlElement(ElementName = "enhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess EnhancedServiceInstanceAccess {
        get => _enhancedServiceInstanceAccess;
        set {
            EnhancedServiceInstanceAccessSpecified = true;
            _enhancedServiceInstanceAccess = value;
        }
    }

    [XmlIgnore]
    public bool EnhancedServiceInstanceAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _featureAccessCodeAccess;

    [XmlElement(ElementName = "featureAccessCodeAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess FeatureAccessCodeAccess {
        get => _featureAccessCodeAccess;
        set {
            FeatureAccessCodeAccessSpecified = true;
            _featureAccessCodeAccess = value;
        }
    }

    [XmlIgnore]
    public bool FeatureAccessCodeAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

    [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess {
        get => _phoneNumberExtensionAccess;
        set {
            PhoneNumberExtensionAccessSpecified = true;
            _phoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberExtensionAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess _serviceAccess;

    [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess ServiceAccess {
        get => _serviceAccess;
        set {
            ServiceAccessSpecified = true;
            _serviceAccess = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessSpecified { get; set; }
}
}