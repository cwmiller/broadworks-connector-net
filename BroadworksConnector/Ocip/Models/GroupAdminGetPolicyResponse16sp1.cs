using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class GroupAdminGetPolicyResponse16sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    }
}
