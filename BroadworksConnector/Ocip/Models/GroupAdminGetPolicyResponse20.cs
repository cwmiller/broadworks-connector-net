using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAdminGetPolicyResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
    {
        private BroadworksConnector.Ocip.Models.GroupAdminProfileAccess _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminProfileAccess ProfileAccess
        {
            get => _profileAccess;
            set
            {
                ProfileAccessSpecified = true;
                _profileAccess = value;
            }
        }

        [XmlIgnore]
        public bool ProfileAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminUserAccess _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminUserAccess UserAccess
        {
            get => _userAccess;
            set
            {
                UserAccessSpecified = true;
                _userAccess = value;
            }
        }

        [XmlIgnore]
        public bool UserAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminAdminAccess _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminAdminAccess AdminAccess
        {
            get => _adminAccess;
            set
            {
                AdminAccessSpecified = true;
                _adminAccess = value;
            }
        }

        [XmlIgnore]
        public bool AdminAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess DepartmentAccess
        {
            get => _departmentAccess;
            set
            {
                DepartmentAccessSpecified = true;
                _departmentAccess = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess AccessDeviceAccess
        {
            get => _accessDeviceAccess;
            set
            {
                AccessDeviceAccessSpecified = true;
                _accessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        public bool AccessDeviceAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _enhancedServiceInstanceAccess;

        [XmlElement(ElementName = "enhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess EnhancedServiceInstanceAccess
        {
            get => _enhancedServiceInstanceAccess;
            set
            {
                EnhancedServiceInstanceAccessSpecified = true;
                _enhancedServiceInstanceAccess = value;
            }
        }

        [XmlIgnore]
        public bool EnhancedServiceInstanceAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _featureAccessCodeAccess;

        [XmlElement(ElementName = "featureAccessCodeAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess FeatureAccessCodeAccess
        {
            get => _featureAccessCodeAccess;
            set
            {
                FeatureAccessCodeAccessSpecified = true;
                _featureAccessCodeAccess = value;
            }
        }

        [XmlIgnore]
        public bool FeatureAccessCodeAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess
        {
            get => _phoneNumberExtensionAccess;
            set
            {
                PhoneNumberExtensionAccessSpecified = true;
                _phoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        public bool PhoneNumberExtensionAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess CallingLineIdNumberAccess
        {
            get => _callingLineIdNumberAccess;
            set
            {
                CallingLineIdNumberAccessSpecified = true;
                _callingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        public bool CallingLineIdNumberAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminServiceAccess _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminServiceAccess ServiceAccess
        {
            get => _serviceAccess;
            set
            {
                ServiceAccessSpecified = true;
                _serviceAccess = value;
            }
        }

        [XmlIgnore]
        public bool ServiceAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminTrunkGroupAccess _trunkGroupAccess;

        [XmlElement(ElementName = "trunkGroupAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminTrunkGroupAccess TrunkGroupAccess
        {
            get => _trunkGroupAccess;
            set
            {
                TrunkGroupAccessSpecified = true;
                _trunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        public bool TrunkGroupAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess SessionAdmissionControlAccess
        {
            get => _sessionAdmissionControlAccess;
            set
            {
                SessionAdmissionControlAccessSpecified = true;
                _sessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        public bool SessionAdmissionControlAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminOfficeZoneAccess _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminOfficeZoneAccess OfficeZoneAccess
        {
            get => _officeZoneAccess;
            set
            {
                OfficeZoneAccessSpecified = true;
                _officeZoneAccess = value;
            }
        }

        [XmlIgnore]
        public bool OfficeZoneAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminNumberActivationAccess _numberActivationAccess;

        [XmlElement(ElementName = "numberActivationAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminNumberActivationAccess NumberActivationAccess
        {
            get => _numberActivationAccess;
            set
            {
                NumberActivationAccessSpecified = true;
                _numberActivationAccess = value;
            }
        }

        [XmlIgnore]
        public bool NumberActivationAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess DialableCallerIDAccess
        {
            get => _dialableCallerIDAccess;
            set
            {
                DialableCallerIDAccessSpecified = true;
                _dialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        public bool DialableCallerIDAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess _verifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "verifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess VerifyTranslationAndRoutingAccess
        {
            get => _verifyTranslationAndRoutingAccess;
            set
            {
                VerifyTranslationAndRoutingAccessSpecified = true;
                _verifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        public bool VerifyTranslationAndRoutingAccessSpecified { get; set; }
        private BroadworksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess _communicationBarringUserProfileAccess;

        [XmlElement(ElementName = "communicationBarringUserProfileAccess", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess CommunicationBarringUserProfileAccess
        {
            get => _communicationBarringUserProfileAccess;
            set
            {
                CommunicationBarringUserProfileAccessSpecified = true;
                _communicationBarringUserProfileAccess = value;
            }
        }

        [XmlIgnore]
        public bool CommunicationBarringUserProfileAccessSpecified { get; set; }
    }
}
