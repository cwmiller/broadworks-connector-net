using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the group administrator's policy settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// dialableCallerIDAccess
    /// verifyTranslationAndRoutingAccess
    /// communicationBarringUserProfileAccess (only applicable to groups in an Enterprise)
    /// passwordRulesAccess
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4b0e7857796c636464362260a2f8e5ee:1831""}]")]
    public class GroupAdminModifyPolicyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess? _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess? ProfileAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminUserAccess? _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminUserAccess? UserAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess? _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess? AdminAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess? _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess? DepartmentAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess? _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess? AccessDeviceAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess? _enhancedServiceInstanceAccess;

        [XmlElement(ElementName = "enhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess? EnhancedServiceInstanceAccess
        {
            get => _enhancedServiceInstanceAccess;
            set
            {
                EnhancedServiceInstanceAccessSpecified = (value != null);
                _enhancedServiceInstanceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool EnhancedServiceInstanceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess? _featureAccessCodeAccess;

        [XmlElement(ElementName = "featureAccessCodeAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess? FeatureAccessCodeAccess
        {
            get => _featureAccessCodeAccess;
            set
            {
                FeatureAccessCodeAccessSpecified = (value != null);
                _featureAccessCodeAccess = value;
            }
        }

        [XmlIgnore]
        protected bool FeatureAccessCodeAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess? _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess? PhoneNumberExtensionAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess? _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess? CallingLineIdNumberAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess? _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess? ServiceAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess? _trunkGroupAccess;

        [XmlElement(ElementName = "trunkGroupAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess? TrunkGroupAccess
        {
            get => _trunkGroupAccess;
            set
            {
                TrunkGroupAccessSpecified = (value != null);
                _trunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool TrunkGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess? _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess? SessionAdmissionControlAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess? _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess? OfficeZoneAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess? _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess? DialableCallerIDAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess? _numberActivationAccess;

        [XmlElement(ElementName = "numberActivationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess? NumberActivationAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess? _verifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "verifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess? VerifyTranslationAndRoutingAccess
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

        protected BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess? _communicationBarringUserProfileAccess;

        [XmlElement(ElementName = "communicationBarringUserProfileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess? CommunicationBarringUserProfileAccess
        {
            get => _communicationBarringUserProfileAccess;
            set
            {
                CommunicationBarringUserProfileAccessSpecified = (value != null);
                _communicationBarringUserProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool CommunicationBarringUserProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminPasswordRulesAccess? _passwordRulesAccess;

        [XmlElement(ElementName = "passwordRulesAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4b0e7857796c636464362260a2f8e5ee:1831")]
        public BroadWorksConnector.Ocip.Models.GroupAdminPasswordRulesAccess? PasswordRulesAccess
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
