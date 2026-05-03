using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system's default policy settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The following elements are only used in AS data mode and ignored in XS mode:
    /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
    /// GroupAdminVerifyTranslationAndRoutingAccess
    /// ServiceProviderVerifyTranslationAndRoutingAccess
    /// groupUserAutoAttendantNameDialingAccess
    /// serviceProviderAdminPasswordRulesAccess
    /// groupAdminPasswordRulesAccess
    /// The following elements are only used in XS data mode and ignored in AS mode:
    /// serviceProviderAdminCommunicationBarringAccess
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14943""}]")]
    public class SystemPolicyModifyDefaultRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess? _groupCallingPlanAccess;

        [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess? GroupCallingPlanAccess
        {
            get => _groupCallingPlanAccess;
            set
            {
                GroupCallingPlanAccessSpecified = (value != null);
                _groupCallingPlanAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCallingPlanAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupExtensionAccess? _groupExtensionAccess;

        [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupExtensionAccess? GroupExtensionAccess
        {
            get => _groupExtensionAccess;
            set
            {
                GroupExtensionAccessSpecified = (value != null);
                _groupExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess? _groupVoiceMessagingAccess;

        [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess? GroupVoiceMessagingAccess
        {
            get => _groupVoiceMessagingAccess;
            set
            {
                GroupVoiceMessagingAccessSpecified = (value != null);
                _groupVoiceMessagingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupVoiceMessagingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess? _groupDepartmentAdminUserAccess;

        [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess? GroupDepartmentAdminUserAccess
        {
            get => _groupDepartmentAdminUserAccess;
            set
            {
                GroupDepartmentAdminUserAccessSpecified = (value != null);
                _groupDepartmentAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess? _groupDepartmentAdminTrunkGroupAccess;

        [XmlElement(ElementName = "groupDepartmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess? GroupDepartmentAdminTrunkGroupAccess
        {
            get => _groupDepartmentAdminTrunkGroupAccess;
            set
            {
                GroupDepartmentAdminTrunkGroupAccessSpecified = (value != null);
                _groupDepartmentAdminTrunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminTrunkGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess? _groupDepartmentAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "groupDepartmentAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess? GroupDepartmentAdminPhoneNumberExtensionAccess
        {
            get => _groupDepartmentAdminPhoneNumberExtensionAccess;
            set
            {
                GroupDepartmentAdminPhoneNumberExtensionAccessSpecified = (value != null);
                _groupDepartmentAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess? _groupDepartmentAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "groupDepartmentAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess? GroupDepartmentAdminCallingLineIdNumberAccess
        {
            get => _groupDepartmentAdminCallingLineIdNumberAccess;
            set
            {
                GroupDepartmentAdminCallingLineIdNumberAccessSpecified = (value != null);
                _groupDepartmentAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess? _groupUserAuthenticationAccess;

        [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess? GroupUserAuthenticationAccess
        {
            get => _groupUserAuthenticationAccess;
            set
            {
                GroupUserAuthenticationAccessSpecified = (value != null);
                _groupUserAuthenticationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserAuthenticationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess? _groupUserGroupDirectoryAccess;

        [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess? GroupUserGroupDirectoryAccess
        {
            get => _groupUserGroupDirectoryAccess;
            set
            {
                GroupUserGroupDirectoryAccessSpecified = (value != null);
                _groupUserGroupDirectoryAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserGroupDirectoryAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserProfileAccess? _groupUserProfileAccess;

        [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupUserProfileAccess? GroupUserProfileAccess
        {
            get => _groupUserProfileAccess;
            set
            {
                GroupUserProfileAccessSpecified = (value != null);
                _groupUserProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess? _groupUserEnhancedCallLogsAccess;

        [XmlElement(ElementName = "groupUserEnhancedCallLogsAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess? GroupUserEnhancedCallLogsAccess
        {
            get => _groupUserEnhancedCallLogsAccess;
            set
            {
                GroupUserEnhancedCallLogsAccessSpecified = (value != null);
                _groupUserEnhancedCallLogsAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserEnhancedCallLogsAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess? _groupUserAutoAttendantNameDialingAccess;

        [XmlElement(ElementName = "groupUserAutoAttendantNameDialingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess? GroupUserAutoAttendantNameDialingAccess
        {
            get => _groupUserAutoAttendantNameDialingAccess;
            set
            {
                GroupUserAutoAttendantNameDialingAccessSpecified = (value != null);
                _groupUserAutoAttendantNameDialingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserAutoAttendantNameDialingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess? _groupAdminProfileAccess;

        [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess? GroupAdminProfileAccess
        {
            get => _groupAdminProfileAccess;
            set
            {
                GroupAdminProfileAccessSpecified = (value != null);
                _groupAdminProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminUserAccess? _groupAdminUserAccess;

        [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminUserAccess? GroupAdminUserAccess
        {
            get => _groupAdminUserAccess;
            set
            {
                GroupAdminUserAccessSpecified = (value != null);
                _groupAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess? _groupAdminAdminAccess;

        [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess? GroupAdminAdminAccess
        {
            get => _groupAdminAdminAccess;
            set
            {
                GroupAdminAdminAccessSpecified = (value != null);
                _groupAdminAdminAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminAdminAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess? _groupAdminDepartmentAccess;

        [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess? GroupAdminDepartmentAccess
        {
            get => _groupAdminDepartmentAccess;
            set
            {
                GroupAdminDepartmentAccessSpecified = (value != null);
                _groupAdminDepartmentAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminDepartmentAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess? _groupAdminAccessDeviceAccess;

        [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess? GroupAdminAccessDeviceAccess
        {
            get => _groupAdminAccessDeviceAccess;
            set
            {
                GroupAdminAccessDeviceAccessSpecified = (value != null);
                _groupAdminAccessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminAccessDeviceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess? _groupAdminEnhancedServiceInstanceAccess;

        [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess? GroupAdminEnhancedServiceInstanceAccess
        {
            get => _groupAdminEnhancedServiceInstanceAccess;
            set
            {
                GroupAdminEnhancedServiceInstanceAccessSpecified = (value != null);
                _groupAdminEnhancedServiceInstanceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminEnhancedServiceInstanceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess? _groupAdminFeatureAccessCodeAccess;

        [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess? GroupAdminFeatureAccessCodeAccess
        {
            get => _groupAdminFeatureAccessCodeAccess;
            set
            {
                GroupAdminFeatureAccessCodeAccessSpecified = (value != null);
                _groupAdminFeatureAccessCodeAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminFeatureAccessCodeAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess? _groupAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess? GroupAdminPhoneNumberExtensionAccess
        {
            get => _groupAdminPhoneNumberExtensionAccess;
            set
            {
                GroupAdminPhoneNumberExtensionAccessSpecified = (value != null);
                _groupAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess? _groupAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "groupAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess? GroupAdminCallingLineIdNumberAccess
        {
            get => _groupAdminCallingLineIdNumberAccess;
            set
            {
                GroupAdminCallingLineIdNumberAccessSpecified = (value != null);
                _groupAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess? _groupAdminServiceAccess;

        [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess? GroupAdminServiceAccess
        {
            get => _groupAdminServiceAccess;
            set
            {
                GroupAdminServiceAccessSpecified = (value != null);
                _groupAdminServiceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminServiceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess? _groupAdminTrunkGroupAccess;

        [XmlElement(ElementName = "groupAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess? GroupAdminTrunkGroupAccess
        {
            get => _groupAdminTrunkGroupAccess;
            set
            {
                GroupAdminTrunkGroupAccessSpecified = (value != null);
                _groupAdminTrunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminTrunkGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess? _groupAdminVerifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "groupAdminVerifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess? GroupAdminVerifyTranslationAndRoutingAccess
        {
            get => _groupAdminVerifyTranslationAndRoutingAccess;
            set
            {
                GroupAdminVerifyTranslationAndRoutingAccessSpecified = (value != null);
                _groupAdminVerifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminVerifyTranslationAndRoutingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess? _groupAdminSessionAdmissionControlAccess;

        [XmlElement(ElementName = "groupAdminSessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess? GroupAdminSessionAdmissionControlAccess
        {
            get => _groupAdminSessionAdmissionControlAccess;
            set
            {
                GroupAdminSessionAdmissionControlAccessSpecified = (value != null);
                _groupAdminSessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminSessionAdmissionControlAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess? _groupAdminDialableCallerIDAccess;

        [XmlElement(ElementName = "groupAdminDialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess? GroupAdminDialableCallerIDAccess
        {
            get => _groupAdminDialableCallerIDAccess;
            set
            {
                GroupAdminDialableCallerIDAccessSpecified = (value != null);
                _groupAdminDialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminDialableCallerIDAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess? _groupAdminOfficeZoneAccess;

        [XmlElement(ElementName = "groupAdminOfficeZoneAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess? GroupAdminOfficeZoneAccess
        {
            get => _groupAdminOfficeZoneAccess;
            set
            {
                GroupAdminOfficeZoneAccessSpecified = (value != null);
                _groupAdminOfficeZoneAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminOfficeZoneAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess? _groupAdminNumberActivationAccess;

        [XmlElement(ElementName = "groupAdminNumberActivationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess? GroupAdminNumberActivationAccess
        {
            get => _groupAdminNumberActivationAccess;
            set
            {
                GroupAdminNumberActivationAccessSpecified = (value != null);
                _groupAdminNumberActivationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminNumberActivationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess? _groupAdminCommunicationBarringUserProfileAccess;

        [XmlElement(ElementName = "groupAdminCommunicationBarringUserProfileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess? GroupAdminCommunicationBarringUserProfileAccess
        {
            get => _groupAdminCommunicationBarringUserProfileAccess;
            set
            {
                GroupAdminCommunicationBarringUserProfileAccessSpecified = (value != null);
                _groupAdminCommunicationBarringUserProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminCommunicationBarringUserProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminPasswordRulesAccess? _groupAdminPasswordRulesAccess;

        [XmlElement(ElementName = "groupAdminPasswordRulesAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.GroupAdminPasswordRulesAccess? GroupAdminPasswordRulesAccess
        {
            get => _groupAdminPasswordRulesAccess;
            set
            {
                GroupAdminPasswordRulesAccessSpecified = (value != null);
                _groupAdminPasswordRulesAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminPasswordRulesAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess? _serviceProviderAdminProfileAccess;

        [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess? ServiceProviderAdminProfileAccess
        {
            get => _serviceProviderAdminProfileAccess;
            set
            {
                ServiceProviderAdminProfileAccessSpecified = (value != null);
                _serviceProviderAdminProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess? _serviceProviderAdminGroupAccess;

        [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess? ServiceProviderAdminGroupAccess
        {
            get => _serviceProviderAdminGroupAccess;
            set
            {
                ServiceProviderAdminGroupAccessSpecified = (value != null);
                _serviceProviderAdminGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess? _serviceProviderAdminUserAccess;

        [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess? ServiceProviderAdminUserAccess
        {
            get => _serviceProviderAdminUserAccess;
            set
            {
                ServiceProviderAdminUserAccessSpecified = (value != null);
                _serviceProviderAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess? _serviceProviderAdminAdminAccess;

        [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess? ServiceProviderAdminAdminAccess
        {
            get => _serviceProviderAdminAdminAccess;
            set
            {
                ServiceProviderAdminAdminAccessSpecified = (value != null);
                _serviceProviderAdminAdminAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminAdminAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess? _serviceProviderAdminDepartmentAccess;

        [XmlElement(ElementName = "ServiceProviderAdminDepartmentAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess? ServiceProviderAdminDepartmentAccess
        {
            get => _serviceProviderAdminDepartmentAccess;
            set
            {
                ServiceProviderAdminDepartmentAccessSpecified = (value != null);
                _serviceProviderAdminDepartmentAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminDepartmentAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess? _serviceProviderAdminAccessDeviceAccess;

        [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess? ServiceProviderAdminAccessDeviceAccess
        {
            get => _serviceProviderAdminAccessDeviceAccess;
            set
            {
                ServiceProviderAdminAccessDeviceAccessSpecified = (value != null);
                _serviceProviderAdminAccessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminAccessDeviceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess? _serviceProviderAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess? ServiceProviderAdminPhoneNumberExtensionAccess
        {
            get => _serviceProviderAdminPhoneNumberExtensionAccess;
            set
            {
                ServiceProviderAdminPhoneNumberExtensionAccessSpecified = (value != null);
                _serviceProviderAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess? _serviceProviderAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "serviceProviderAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess? ServiceProviderAdminCallingLineIdNumberAccess
        {
            get => _serviceProviderAdminCallingLineIdNumberAccess;
            set
            {
                ServiceProviderAdminCallingLineIdNumberAccessSpecified = (value != null);
                _serviceProviderAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess? _serviceProviderAdminServiceAccess;

        [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess? ServiceProviderAdminServiceAccess
        {
            get => _serviceProviderAdminServiceAccess;
            set
            {
                ServiceProviderAdminServiceAccessSpecified = (value != null);
                _serviceProviderAdminServiceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminServiceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess? _serviceProviderAdminServicePackAccess;

        [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess? ServiceProviderAdminServicePackAccess
        {
            get => _serviceProviderAdminServicePackAccess;
            set
            {
                ServiceProviderAdminServicePackAccessSpecified = (value != null);
                _serviceProviderAdminServicePackAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminServicePackAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess? _serviceProviderAdminSessionAdmissionControlAccess;

        [XmlElement(ElementName = "serviceProviderAdminSessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess? ServiceProviderAdminSessionAdmissionControlAccess
        {
            get => _serviceProviderAdminSessionAdmissionControlAccess;
            set
            {
                ServiceProviderAdminSessionAdmissionControlAccessSpecified = (value != null);
                _serviceProviderAdminSessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminSessionAdmissionControlAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess? _serviceProviderAdminVerifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "serviceProviderAdminVerifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess? ServiceProviderAdminVerifyTranslationAndRoutingAccess
        {
            get => _serviceProviderAdminVerifyTranslationAndRoutingAccess;
            set
            {
                ServiceProviderAdminVerifyTranslationAndRoutingAccessSpecified = (value != null);
                _serviceProviderAdminVerifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminVerifyTranslationAndRoutingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess? _serviceProviderAdminWebBrandingAccess;

        [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess? ServiceProviderAdminWebBrandingAccess
        {
            get => _serviceProviderAdminWebBrandingAccess;
            set
            {
                ServiceProviderAdminWebBrandingAccessSpecified = (value != null);
                _serviceProviderAdminWebBrandingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminWebBrandingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess? _serviceProviderAdminOfficeZoneAccess;

        [XmlElement(ElementName = "serviceProviderAdminOfficeZoneAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess? ServiceProviderAdminOfficeZoneAccess
        {
            get => _serviceProviderAdminOfficeZoneAccess;
            set
            {
                ServiceProviderAdminOfficeZoneAccessSpecified = (value != null);
                _serviceProviderAdminOfficeZoneAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminOfficeZoneAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess? _serviceProviderAdminCommunicationBarringAccess;

        [XmlElement(ElementName = "serviceProviderAdminCommunicationBarringAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess? ServiceProviderAdminCommunicationBarringAccess
        {
            get => _serviceProviderAdminCommunicationBarringAccess;
            set
            {
                ServiceProviderAdminCommunicationBarringAccessSpecified = (value != null);
                _serviceProviderAdminCommunicationBarringAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminCommunicationBarringAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess? _enterpriseAdminNetworkPolicyAccess;

        [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess? EnterpriseAdminNetworkPolicyAccess
        {
            get => _enterpriseAdminNetworkPolicyAccess;
            set
            {
                EnterpriseAdminNetworkPolicyAccessSpecified = (value != null);
                _enterpriseAdminNetworkPolicyAccess = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseAdminNetworkPolicyAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess? _serviceProviderAdminDialableCallerIDAccess;

        [XmlElement(ElementName = "serviceProviderAdminDialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess? ServiceProviderAdminDialableCallerIDAccess
        {
            get => _serviceProviderAdminDialableCallerIDAccess;
            set
            {
                ServiceProviderAdminDialableCallerIDAccessSpecified = (value != null);
                _serviceProviderAdminDialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminDialableCallerIDAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess? _enterpriseAdminNumberActivationAccess;

        [XmlElement(ElementName = "enterpriseAdminNumberActivationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess? EnterpriseAdminNumberActivationAccess
        {
            get => _enterpriseAdminNumberActivationAccess;
            set
            {
                EnterpriseAdminNumberActivationAccessSpecified = (value != null);
                _enterpriseAdminNumberActivationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseAdminNumberActivationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminPasswordRulesAccess? _serviceProviderAdminPasswordRulesAccess;

        [XmlElement(ElementName = "serviceProviderAdminPasswordRulesAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14943")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPasswordRulesAccess? ServiceProviderAdminPasswordRulesAccess
        {
            get => _serviceProviderAdminPasswordRulesAccess;
            set
            {
                ServiceProviderAdminPasswordRulesAccessSpecified = (value != null);
                _serviceProviderAdminPasswordRulesAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminPasswordRulesAccessSpecified { get; set; }

    }
}
