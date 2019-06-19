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
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:1336""}]")]
    public class GroupAdminModifyPolicyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool UserIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess _profileAccess;

        [XmlElement(ElementName = "profileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool ProfileAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminUserAccess _userAccess;

        [XmlElement(ElementName = "userAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool UserAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess _adminAccess;

        [XmlElement(ElementName = "adminAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool AdminAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess _departmentAccess;

        [XmlElement(ElementName = "departmentAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool DepartmentAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _accessDeviceAccess;

        [XmlElement(ElementName = "accessDeviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool AccessDeviceAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _enhancedServiceInstanceAccess;

        [XmlElement(ElementName = "enhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool EnhancedServiceInstanceAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _featureAccessCodeAccess;

        [XmlElement(ElementName = "featureAccessCodeAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool FeatureAccessCodeAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _phoneNumberExtensionAccess;

        [XmlElement(ElementName = "phoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool PhoneNumberExtensionAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess _callingLineIdNumberAccess;

        [XmlElement(ElementName = "callingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool CallingLineIdNumberAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess _serviceAccess;

        [XmlElement(ElementName = "serviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool ServiceAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess _trunkGroupAccess;

        [XmlElement(ElementName = "trunkGroupAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool TrunkGroupAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess _sessionAdmissionControlAccess;

        [XmlElement(ElementName = "sessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool SessionAdmissionControlAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess _officeZoneAccess;

        [XmlElement(ElementName = "officeZoneAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool OfficeZoneAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess _dialableCallerIDAccess;

        [XmlElement(ElementName = "dialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
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
        public bool DialableCallerIDAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess _numberActivationAccess;

        [XmlElement(ElementName = "numberActivationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
        public BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess NumberActivationAccess
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

        private BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess _verifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "verifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
        public BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess VerifyTranslationAndRoutingAccess
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

        private BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess _communicationBarringUserProfileAccess;

        [XmlElement(ElementName = "communicationBarringUserProfileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:1336")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess CommunicationBarringUserProfileAccess
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
