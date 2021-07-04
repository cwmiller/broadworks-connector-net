using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the service provider administrator's policy settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The networkPolicyAccess is only modified for the enterprise administrator.
    /// The following elements are only used in AS data mode:
    /// dialableCallerIDAccess
    /// verifyTranslationAndroutingAccess
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f1088f4c5ceb30d524d2ba0f8097c393:1610""}]")]
    public class ServiceProviderAdminModifyPolicyRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess _communicationBarringAccess;

        [XmlElement(ElementName = "communicationBarringAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess CommunicationBarringAccess
        {
            get => _communicationBarringAccess;
            set
            {
                CommunicationBarringAccessSpecified = true;
                _communicationBarringAccess = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _networkPolicyAccess;

        [XmlElement(ElementName = "networkPolicyAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess _numberActivationAccess;

        [XmlElement(ElementName = "numberActivationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess NumberActivationAccess
        {
            get => _numberActivationAccess;
            set
            {
                NumberActivationAccessSpecified = true;
                _numberActivationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool NumberActivationAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess DialableCallerIDAccess
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess _verifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "verifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f1088f4c5ceb30d524d2ba0f8097c393:1610")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess VerifyTranslationAndRoutingAccess
        {
            get => _verifyTranslationAndRoutingAccess;
            set
            {
                VerifyTranslationAndRoutingAccessSpecified = true;
                _verifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool VerifyTranslationAndRoutingAccessSpecified { get; set; }

    }
}
