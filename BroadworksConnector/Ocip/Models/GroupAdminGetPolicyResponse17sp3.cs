using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupAdminGetPolicyRequest17sp3.
    /// Contains the policy settings for the group administrator.
    /// The following elements are only used in AS data mode:
    /// dialableCallerIDAccess
    /// <see cref="GroupAdminGetPolicyRequest17sp3"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:18477""}]")]
    public class GroupAdminGetPolicyResponse17sp3 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess ProfileAccess
        {
            get => _profileAccess;
            set
            {
                ProfileAccessSpecified = true;
                _profileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminUserAccess _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminUserAccess UserAccess
        {
            get => _userAccess;
            set
            {
                UserAccessSpecified = true;
                _userAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess AdminAccess
        {
            get => _adminAccess;
            set
            {
                AdminAccessSpecified = true;
                _adminAccess = value;
            }
        }

        [XmlIgnore]
        protected bool AdminAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess DepartmentAccess
        {
            get => _departmentAccess;
            set
            {
                DepartmentAccessSpecified = true;
                _departmentAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess AccessDeviceAccess
        {
            get => _accessDeviceAccess;
            set
            {
                AccessDeviceAccessSpecified = true;
                _accessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _enhancedServiceInstanceAccess;

        [XmlElement(ElementName = "enhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess EnhancedServiceInstanceAccess
        {
            get => _enhancedServiceInstanceAccess;
            set
            {
                EnhancedServiceInstanceAccessSpecified = true;
                _enhancedServiceInstanceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool EnhancedServiceInstanceAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _featureAccessCodeAccess;

        [XmlElement(ElementName = "featureAccessCodeAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess FeatureAccessCodeAccess
        {
            get => _featureAccessCodeAccess;
            set
            {
                FeatureAccessCodeAccessSpecified = true;
                _featureAccessCodeAccess = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess
        {
            get => _phoneNumberExtensionAccess;
            set
            {
                PhoneNumberExtensionAccessSpecified = true;
                _phoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberExtensionAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess CallingLineIdNumberAccess
        {
            get => _callingLineIdNumberAccess;
            set
            {
                CallingLineIdNumberAccessSpecified = true;
                _callingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdNumberAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess ServiceAccess
        {
            get => _serviceAccess;
            set
            {
                ServiceAccessSpecified = true;
                _serviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess _trunkGroupAccess;

        [XmlElement(ElementName = "trunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess TrunkGroupAccess
        {
            get => _trunkGroupAccess;
            set
            {
                TrunkGroupAccessSpecified = true;
                _trunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess SessionAdmissionControlAccess
        {
            get => _sessionAdmissionControlAccess;
            set
            {
                SessionAdmissionControlAccessSpecified = true;
                _sessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        protected bool SessionAdmissionControlAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess OfficeZoneAccess
        {
            get => _officeZoneAccess;
            set
            {
                OfficeZoneAccessSpecified = true;
                _officeZoneAccess = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:18477")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess DialableCallerIDAccess
        {
            get => _dialableCallerIDAccess;
            set
            {
                DialableCallerIDAccessSpecified = true;
                _dialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DialableCallerIDAccessSpecified { get; set; }

    }
}
