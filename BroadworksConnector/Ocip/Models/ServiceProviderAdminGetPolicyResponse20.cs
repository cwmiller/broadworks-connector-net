using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAdminGetPolicyRequest20.
    /// Contains the policy settings for the service provider administrator.
    /// The networkPolicyAccess and numberActivationAccess are returned only for the enterprise administrator.
    /// The following elements are only used in AS data mode:
    /// dialableCallerIDAccess
    /// verifyTranslationAndRoutingAccess
        /// <see cref="ServiceProviderAdminGetPolicyRequest20"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ServiceProviderAdminGetPolicyResponse20 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ProfileAccess {
            get => _profileAccess;
            set {
                ProfileAccessSpecified = true;
                _profileAccess = value;
            }
        }

        [XmlIgnore]
        public bool ProfileAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _groupAccess;

        [XmlElement(ElementName = "groupAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess GroupAccess {
            get => _groupAccess;
            set {
                GroupAccessSpecified = true;
                _groupAccess = value;
            }
        }

        [XmlIgnore]
        public bool GroupAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess UserAccess {
            get => _userAccess;
            set {
                UserAccessSpecified = true;
                _userAccess = value;
            }
        }

        [XmlIgnore]
        public bool UserAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess AdminAccess {
            get => _adminAccess;
            set {
                AdminAccessSpecified = true;
                _adminAccess = value;
            }
        }

        [XmlIgnore]
        public bool AdminAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess DepartmentAccess {
            get => _departmentAccess;
            set {
                DepartmentAccessSpecified = true;
                _departmentAccess = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess AccessDeviceAccess {
            get => _accessDeviceAccess;
            set {
                AccessDeviceAccessSpecified = true;
                _accessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess {
            get => _phoneNumberExtensionAccess;
            set {
                PhoneNumberExtensionAccessSpecified = true;
                _phoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberExtensionAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess CallingLineIdNumberAccess {
            get => _callingLineIdNumberAccess;
            set {
                CallingLineIdNumberAccessSpecified = true;
                _callingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdNumberAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceAccess {
            get => _serviceAccess;
            set {
                ServiceAccessSpecified = true;
                _serviceAccess = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _servicePackAccess;

        [XmlElement(ElementName = "servicePackAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServicePackAccess {
            get => _servicePackAccess;
            set {
                ServicePackAccessSpecified = true;
                _servicePackAccess = value;
            }
        }

        [XmlIgnore]
        public bool ServicePackAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess SessionAdmissionControlAccess {
            get => _sessionAdmissionControlAccess;
            set {
                SessionAdmissionControlAccessSpecified = true;
                _sessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        public bool SessionAdmissionControlAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _webBrandingAccess;

        [XmlElement(ElementName = "webBrandingAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess WebBrandingAccess {
            get => _webBrandingAccess;
            set {
                WebBrandingAccessSpecified = true;
                _webBrandingAccess = value;
            }
        }

        [XmlIgnore]
        public bool WebBrandingAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess OfficeZoneAccess {
            get => _officeZoneAccess;
            set {
                OfficeZoneAccessSpecified = true;
                _officeZoneAccess = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess _communicationBarringAccess;

        [XmlElement(ElementName = "communicationBarringAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess CommunicationBarringAccess {
            get => _communicationBarringAccess;
            set {
                CommunicationBarringAccessSpecified = true;
                _communicationBarringAccess = value;
            }
        }

        [XmlIgnore]
        public bool CommunicationBarringAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _networkPolicyAccess;

        [XmlElement(ElementName = "networkPolicyAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess NetworkPolicyAccess {
            get => _networkPolicyAccess;
            set {
                NetworkPolicyAccessSpecified = true;
                _networkPolicyAccess = value;
            }
        }

        [XmlIgnore]
        public bool NetworkPolicyAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess _numberActivationAccess;

        [XmlElement(ElementName = "numberActivationAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess NumberActivationAccess {
            get => _numberActivationAccess;
            set {
                NumberActivationAccessSpecified = true;
                _numberActivationAccess = value;
            }
        }

        [XmlIgnore]
        public bool NumberActivationAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess DialableCallerIDAccess {
            get => _dialableCallerIDAccess;
            set {
                DialableCallerIDAccessSpecified = true;
                _dialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        public bool DialableCallerIDAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess _verifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "verifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess VerifyTranslationAndRoutingAccess {
            get => _verifyTranslationAndRoutingAccess;
            set {
                VerifyTranslationAndRoutingAccessSpecified = true;
                _verifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        public bool VerifyTranslationAndRoutingAccessSpecified { get; set; }
        
    }
}
