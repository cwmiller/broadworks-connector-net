using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderAdminGetPolicyRequest17.
    /// Contains the policy settings for the service provider administrator.
    /// The networkPolicyAccess is returned only for the enterprise administrator.
    /// <see cref="ServiceProviderAdminGetPolicyRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:17139""}]")]
    public class ServiceProviderAdminGetPolicyResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ProfileAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _groupAccess;

        [XmlElement(ElementName = "groupAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess GroupAccess
        {
            get => _groupAccess;
            set
            {
                GroupAccessSpecified = true;
                _groupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess UserAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess AdminAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess DepartmentAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess AccessDeviceAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess PhoneNumberExtensionAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess CallingLineIdNumberAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _servicePackAccess;

        [XmlElement(ElementName = "servicePackAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServicePackAccess
        {
            get => _servicePackAccess;
            set
            {
                ServicePackAccessSpecified = true;
                _servicePackAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess SessionAdmissionControlAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _webBrandingAccess;

        [XmlElement(ElementName = "webBrandingAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess WebBrandingAccess
        {
            get => _webBrandingAccess;
            set
            {
                WebBrandingAccessSpecified = true;
                _webBrandingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool WebBrandingAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess OfficeZoneAccess
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

        private BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _networkPolicyAccess;

        [XmlElement(ElementName = "networkPolicyAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:17139")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess NetworkPolicyAccess
        {
            get => _networkPolicyAccess;
            set
            {
                NetworkPolicyAccessSpecified = true;
                _networkPolicyAccess = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkPolicyAccessSpecified { get; set; }

    }
}
