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
    /// passwordRulesAccess
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:1692""}]")]
    public class ServiceProviderAdminModifyPolicyRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
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

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess? _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess? ProfileAccess
        {
            get => _profileAccess;
            set
            {
                ProfileAccessSpecified = (value != null);
                _profileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess? _groupAccess;

        [XmlElement(ElementName = "groupAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess? GroupAccess
        {
            get => _groupAccess;
            set
            {
                GroupAccessSpecified = (value != null);
                _groupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess? _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess? UserAccess
        {
            get => _userAccess;
            set
            {
                UserAccessSpecified = (value != null);
                _userAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess? _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess? AdminAccess
        {
            get => _adminAccess;
            set
            {
                AdminAccessSpecified = (value != null);
                _adminAccess = value;
            }
        }

        [XmlIgnore]
        protected bool AdminAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess? _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess? DepartmentAccess
        {
            get => _departmentAccess;
            set
            {
                DepartmentAccessSpecified = (value != null);
                _departmentAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess? _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess? AccessDeviceAccess
        {
            get => _accessDeviceAccess;
            set
            {
                AccessDeviceAccessSpecified = (value != null);
                _accessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool AccessDeviceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess? _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess? PhoneNumberExtensionAccess
        {
            get => _phoneNumberExtensionAccess;
            set
            {
                PhoneNumberExtensionAccessSpecified = (value != null);
                _phoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool PhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess? _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess? CallingLineIdNumberAccess
        {
            get => _callingLineIdNumberAccess;
            set
            {
                CallingLineIdNumberAccessSpecified = (value != null);
                _callingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool CallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess? _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess? ServiceAccess
        {
            get => _serviceAccess;
            set
            {
                ServiceAccessSpecified = (value != null);
                _serviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess? _servicePackAccess;

        [XmlElement(ElementName = "servicePackAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess? ServicePackAccess
        {
            get => _servicePackAccess;
            set
            {
                ServicePackAccessSpecified = (value != null);
                _servicePackAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServicePackAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess? _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess? SessionAdmissionControlAccess
        {
            get => _sessionAdmissionControlAccess;
            set
            {
                SessionAdmissionControlAccessSpecified = (value != null);
                _sessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        protected bool SessionAdmissionControlAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess? _webBrandingAccess;

        [XmlElement(ElementName = "webBrandingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess? WebBrandingAccess
        {
            get => _webBrandingAccess;
            set
            {
                WebBrandingAccessSpecified = (value != null);
                _webBrandingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool WebBrandingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess? _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess? OfficeZoneAccess
        {
            get => _officeZoneAccess;
            set
            {
                OfficeZoneAccessSpecified = (value != null);
                _officeZoneAccess = value;
            }
        }

        [XmlIgnore]
        protected bool OfficeZoneAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess? _communicationBarringAccess;

        [XmlElement(ElementName = "communicationBarringAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess? CommunicationBarringAccess
        {
            get => _communicationBarringAccess;
            set
            {
                CommunicationBarringAccessSpecified = (value != null);
                _communicationBarringAccess = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess? _networkPolicyAccess;

        [XmlElement(ElementName = "networkPolicyAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess? NetworkPolicyAccess
        {
            get => _networkPolicyAccess;
            set
            {
                NetworkPolicyAccessSpecified = (value != null);
                _networkPolicyAccess = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkPolicyAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess? _numberActivationAccess;

        [XmlElement(ElementName = "numberActivationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess? NumberActivationAccess
        {
            get => _numberActivationAccess;
            set
            {
                NumberActivationAccessSpecified = (value != null);
                _numberActivationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool NumberActivationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess? _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess? DialableCallerIDAccess
        {
            get => _dialableCallerIDAccess;
            set
            {
                DialableCallerIDAccessSpecified = (value != null);
                _dialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DialableCallerIDAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess? _verifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "verifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess? VerifyTranslationAndRoutingAccess
        {
            get => _verifyTranslationAndRoutingAccess;
            set
            {
                VerifyTranslationAndRoutingAccessSpecified = (value != null);
                _verifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool VerifyTranslationAndRoutingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminPasswordRulesAccess? _passwordRulesAccess;

        [XmlElement(ElementName = "passwordRulesAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:1692")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPasswordRulesAccess? PasswordRulesAccess
        {
            get => _passwordRulesAccess;
            set
            {
                PasswordRulesAccessSpecified = (value != null);
                _passwordRulesAccess = value;
            }
        }

        [XmlIgnore]
        protected bool PasswordRulesAccessSpecified { get; set; }

    }
}
