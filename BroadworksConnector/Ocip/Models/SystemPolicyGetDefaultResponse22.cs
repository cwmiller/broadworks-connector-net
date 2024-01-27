using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPolicyGetDefaultRequest22.
    /// Contains the default policy settings for the system.
    /// The following elements are only used in AS data mode:
    /// GroupAdminDialableCallerIDAccess
    /// ServiceProviderAdminDialableCallerIDAccess
    /// GroupAdminCommunicationBarringUserProfileAccess (This element is only used for groups in an Enterprise)
    /// GroupAdminVerifyTranslationAndRoutingAccess
    /// ServiceProviderAdminVerifyTranslationAndRoutingAccess
    /// The following elements are only used in XS data mode:
    /// serviceProviderAdminCommunicationBarringAccess
    /// <see cref="SystemPolicyGetDefaultRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14678""}]")]
    public class SystemPolicyGetDefaultResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _groupCallingPlanAccess;

        [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess GroupCallingPlanAccess
        {
            get => _groupCallingPlanAccess;
            set
            {
                GroupCallingPlanAccessSpecified = true;
                _groupCallingPlanAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupCallingPlanAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupExtensionAccess _groupExtensionAccess;

        [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupExtensionAccess GroupExtensionAccess
        {
            get => _groupExtensionAccess;
            set
            {
                GroupExtensionAccessSpecified = true;
                _groupExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess _groupVoiceMessagingAccess;

        [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess GroupVoiceMessagingAccess
        {
            get => _groupVoiceMessagingAccess;
            set
            {
                GroupVoiceMessagingAccessSpecified = true;
                _groupVoiceMessagingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupVoiceMessagingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _groupDepartmentAdminUserAccess;

        [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess GroupDepartmentAdminUserAccess
        {
            get => _groupDepartmentAdminUserAccess;
            set
            {
                GroupDepartmentAdminUserAccessSpecified = true;
                _groupDepartmentAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _groupDepartmentAdminTrunkGroupAccess;

        [XmlElement(ElementName = "groupDepartmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess GroupDepartmentAdminTrunkGroupAccess
        {
            get => _groupDepartmentAdminTrunkGroupAccess;
            set
            {
                GroupDepartmentAdminTrunkGroupAccessSpecified = true;
                _groupDepartmentAdminTrunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminTrunkGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess _groupDepartmentAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "groupDepartmentAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess GroupDepartmentAdminPhoneNumberExtensionAccess
        {
            get => _groupDepartmentAdminPhoneNumberExtensionAccess;
            set
            {
                GroupDepartmentAdminPhoneNumberExtensionAccessSpecified = true;
                _groupDepartmentAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess _groupDepartmentAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "groupDepartmentAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess GroupDepartmentAdminCallingLineIdNumberAccess
        {
            get => _groupDepartmentAdminCallingLineIdNumberAccess;
            set
            {
                GroupDepartmentAdminCallingLineIdNumberAccessSpecified = true;
                _groupDepartmentAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupDepartmentAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _groupUserAuthenticationAccess;

        [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess GroupUserAuthenticationAccess
        {
            get => _groupUserAuthenticationAccess;
            set
            {
                GroupUserAuthenticationAccessSpecified = true;
                _groupUserAuthenticationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserAuthenticationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _groupUserGroupDirectoryAccess;

        [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess GroupUserGroupDirectoryAccess
        {
            get => _groupUserGroupDirectoryAccess;
            set
            {
                GroupUserGroupDirectoryAccessSpecified = true;
                _groupUserGroupDirectoryAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserGroupDirectoryAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserProfileAccess _groupUserProfileAccess;

        [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupUserProfileAccess GroupUserProfileAccess
        {
            get => _groupUserProfileAccess;
            set
            {
                GroupUserProfileAccessSpecified = true;
                _groupUserProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess _groupUserEnhancedCallLogsAccess;

        [XmlElement(ElementName = "groupUserEnhancedCallLogsAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess GroupUserEnhancedCallLogsAccess
        {
            get => _groupUserEnhancedCallLogsAccess;
            set
            {
                GroupUserEnhancedCallLogsAccessSpecified = true;
                _groupUserEnhancedCallLogsAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserEnhancedCallLogsAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess _groupUserAutoAttendantNameDialingAccess;

        [XmlElement(ElementName = "groupUserAutoAttendantNameDialingAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess GroupUserAutoAttendantNameDialingAccess
        {
            get => _groupUserAutoAttendantNameDialingAccess;
            set
            {
                GroupUserAutoAttendantNameDialingAccessSpecified = true;
                _groupUserAutoAttendantNameDialingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupUserAutoAttendantNameDialingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess _groupAdminProfileAccess;

        [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess GroupAdminProfileAccess
        {
            get => _groupAdminProfileAccess;
            set
            {
                GroupAdminProfileAccessSpecified = true;
                _groupAdminProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminUserAccess _groupAdminUserAccess;

        [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminUserAccess GroupAdminUserAccess
        {
            get => _groupAdminUserAccess;
            set
            {
                GroupAdminUserAccessSpecified = true;
                _groupAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess _groupAdminAdminAccess;

        [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess GroupAdminAdminAccess
        {
            get => _groupAdminAdminAccess;
            set
            {
                GroupAdminAdminAccessSpecified = true;
                _groupAdminAdminAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminAdminAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess _groupAdminDepartmentAccess;

        [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess GroupAdminDepartmentAccess
        {
            get => _groupAdminDepartmentAccess;
            set
            {
                GroupAdminDepartmentAccessSpecified = true;
                _groupAdminDepartmentAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminDepartmentAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _groupAdminAccessDeviceAccess;

        [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess GroupAdminAccessDeviceAccess
        {
            get => _groupAdminAccessDeviceAccess;
            set
            {
                GroupAdminAccessDeviceAccessSpecified = true;
                _groupAdminAccessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminAccessDeviceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _groupAdminEnhancedServiceInstanceAccess;

        [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess GroupAdminEnhancedServiceInstanceAccess
        {
            get => _groupAdminEnhancedServiceInstanceAccess;
            set
            {
                GroupAdminEnhancedServiceInstanceAccessSpecified = true;
                _groupAdminEnhancedServiceInstanceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminEnhancedServiceInstanceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _groupAdminFeatureAccessCodeAccess;

        [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess GroupAdminFeatureAccessCodeAccess
        {
            get => _groupAdminFeatureAccessCodeAccess;
            set
            {
                GroupAdminFeatureAccessCodeAccessSpecified = true;
                _groupAdminFeatureAccessCodeAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminFeatureAccessCodeAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _groupAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess GroupAdminPhoneNumberExtensionAccess
        {
            get => _groupAdminPhoneNumberExtensionAccess;
            set
            {
                GroupAdminPhoneNumberExtensionAccessSpecified = true;
                _groupAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess _groupAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "groupAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess GroupAdminCallingLineIdNumberAccess
        {
            get => _groupAdminCallingLineIdNumberAccess;
            set
            {
                GroupAdminCallingLineIdNumberAccessSpecified = true;
                _groupAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess _groupAdminServiceAccess;

        [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess GroupAdminServiceAccess
        {
            get => _groupAdminServiceAccess;
            set
            {
                GroupAdminServiceAccessSpecified = true;
                _groupAdminServiceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminServiceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess _groupAdminTrunkGroupAccess;

        [XmlElement(ElementName = "groupAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess GroupAdminTrunkGroupAccess
        {
            get => _groupAdminTrunkGroupAccess;
            set
            {
                GroupAdminTrunkGroupAccessSpecified = true;
                _groupAdminTrunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminTrunkGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess _groupAdminVerifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "groupAdminVerifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess GroupAdminVerifyTranslationAndRoutingAccess
        {
            get => _groupAdminVerifyTranslationAndRoutingAccess;
            set
            {
                GroupAdminVerifyTranslationAndRoutingAccessSpecified = true;
                _groupAdminVerifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminVerifyTranslationAndRoutingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess _groupAdminSessionAdmissionControlAccess;

        [XmlElement(ElementName = "groupAdminSessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess GroupAdminSessionAdmissionControlAccess
        {
            get => _groupAdminSessionAdmissionControlAccess;
            set
            {
                GroupAdminSessionAdmissionControlAccessSpecified = true;
                _groupAdminSessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminSessionAdmissionControlAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess _groupAdminOfficeZoneAccess;

        [XmlElement(ElementName = "groupAdminOfficeZoneAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminOfficeZoneAccess GroupAdminOfficeZoneAccess
        {
            get => _groupAdminOfficeZoneAccess;
            set
            {
                GroupAdminOfficeZoneAccessSpecified = true;
                _groupAdminOfficeZoneAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminOfficeZoneAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess _groupAdminNumberActivationAccess;

        [XmlElement(ElementName = "groupAdminNumberActivationAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminNumberActivationAccess GroupAdminNumberActivationAccess
        {
            get => _groupAdminNumberActivationAccess;
            set
            {
                GroupAdminNumberActivationAccessSpecified = true;
                _groupAdminNumberActivationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminNumberActivationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess _groupAdminDialableCallerIDAccess;

        [XmlElement(ElementName = "groupAdminDialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess GroupAdminDialableCallerIDAccess
        {
            get => _groupAdminDialableCallerIDAccess;
            set
            {
                GroupAdminDialableCallerIDAccessSpecified = true;
                _groupAdminDialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminDialableCallerIDAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess _groupAdminCommunicationBarringUserProfileAccess;

        [XmlElement(ElementName = "groupAdminCommunicationBarringUserProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess GroupAdminCommunicationBarringUserProfileAccess
        {
            get => _groupAdminCommunicationBarringUserProfileAccess;
            set
            {
                GroupAdminCommunicationBarringUserProfileAccessSpecified = true;
                _groupAdminCommunicationBarringUserProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupAdminCommunicationBarringUserProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _serviceProviderAdminProfileAccess;

        [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ServiceProviderAdminProfileAccess
        {
            get => _serviceProviderAdminProfileAccess;
            set
            {
                ServiceProviderAdminProfileAccessSpecified = true;
                _serviceProviderAdminProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _serviceProviderAdminGroupAccess;

        [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess ServiceProviderAdminGroupAccess
        {
            get => _serviceProviderAdminGroupAccess;
            set
            {
                ServiceProviderAdminGroupAccessSpecified = true;
                _serviceProviderAdminGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess _serviceProviderAdminUserAccess;

        [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess ServiceProviderAdminUserAccess
        {
            get => _serviceProviderAdminUserAccess;
            set
            {
                ServiceProviderAdminUserAccessSpecified = true;
                _serviceProviderAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _serviceProviderAdminAdminAccess;

        [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess ServiceProviderAdminAdminAccess
        {
            get => _serviceProviderAdminAdminAccess;
            set
            {
                ServiceProviderAdminAdminAccessSpecified = true;
                _serviceProviderAdminAdminAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminAdminAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _serviceProviderAdminDepartmentAccess;

        [XmlElement(ElementName = "serviceProviderAdminDepartmentAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess ServiceProviderAdminDepartmentAccess
        {
            get => _serviceProviderAdminDepartmentAccess;
            set
            {
                ServiceProviderAdminDepartmentAccessSpecified = true;
                _serviceProviderAdminDepartmentAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminDepartmentAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _serviceProviderAdminAccessDeviceAccess;

        [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess ServiceProviderAdminAccessDeviceAccess
        {
            get => _serviceProviderAdminAccessDeviceAccess;
            set
            {
                ServiceProviderAdminAccessDeviceAccessSpecified = true;
                _serviceProviderAdminAccessDeviceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminAccessDeviceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _serviceProviderAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess ServiceProviderAdminPhoneNumberExtensionAccess
        {
            get => _serviceProviderAdminPhoneNumberExtensionAccess;
            set
            {
                ServiceProviderAdminPhoneNumberExtensionAccessSpecified = true;
                _serviceProviderAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess _serviceProviderAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "serviceProviderAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess ServiceProviderAdminCallingLineIdNumberAccess
        {
            get => _serviceProviderAdminCallingLineIdNumberAccess;
            set
            {
                ServiceProviderAdminCallingLineIdNumberAccessSpecified = true;
                _serviceProviderAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceProviderAdminServiceAccess;

        [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceProviderAdminServiceAccess
        {
            get => _serviceProviderAdminServiceAccess;
            set
            {
                ServiceProviderAdminServiceAccessSpecified = true;
                _serviceProviderAdminServiceAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminServiceAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _serviceProviderAdminServicePackAccess;

        [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServiceProviderAdminServicePackAccess
        {
            get => _serviceProviderAdminServicePackAccess;
            set
            {
                ServiceProviderAdminServicePackAccessSpecified = true;
                _serviceProviderAdminServicePackAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminServicePackAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess _serviceProviderAdminSessionAdmissionControlAccess;

        [XmlElement(ElementName = "serviceProviderAdminSessionAdmissionControlAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess ServiceProviderAdminSessionAdmissionControlAccess
        {
            get => _serviceProviderAdminSessionAdmissionControlAccess;
            set
            {
                ServiceProviderAdminSessionAdmissionControlAccessSpecified = true;
                _serviceProviderAdminSessionAdmissionControlAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminSessionAdmissionControlAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess _serviceProviderAdminVerifyTranslationAndRoutingAccess;

        [XmlElement(ElementName = "serviceProviderAdminVerifyTranslationAndRoutingAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess ServiceProviderAdminVerifyTranslationAndRoutingAccess
        {
            get => _serviceProviderAdminVerifyTranslationAndRoutingAccess;
            set
            {
                ServiceProviderAdminVerifyTranslationAndRoutingAccessSpecified = true;
                _serviceProviderAdminVerifyTranslationAndRoutingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminVerifyTranslationAndRoutingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _serviceProviderAdminWebBrandingAccess;

        [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess ServiceProviderAdminWebBrandingAccess
        {
            get => _serviceProviderAdminWebBrandingAccess;
            set
            {
                ServiceProviderAdminWebBrandingAccessSpecified = true;
                _serviceProviderAdminWebBrandingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminWebBrandingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess _serviceProviderAdminOfficeZoneAccess;

        [XmlElement(ElementName = "serviceProviderAdminOfficeZoneAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess ServiceProviderAdminOfficeZoneAccess
        {
            get => _serviceProviderAdminOfficeZoneAccess;
            set
            {
                ServiceProviderAdminOfficeZoneAccessSpecified = true;
                _serviceProviderAdminOfficeZoneAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminOfficeZoneAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess _serviceProviderAdminCommunicationBarringAccess;

        [XmlElement(ElementName = "serviceProviderAdminCommunicationBarringAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess ServiceProviderAdminCommunicationBarringAccess
        {
            get => _serviceProviderAdminCommunicationBarringAccess;
            set
            {
                ServiceProviderAdminCommunicationBarringAccessSpecified = true;
                _serviceProviderAdminCommunicationBarringAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminCommunicationBarringAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _enterpriseAdminNetworkPolicyAccess;

        [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess EnterpriseAdminNetworkPolicyAccess
        {
            get => _enterpriseAdminNetworkPolicyAccess;
            set
            {
                EnterpriseAdminNetworkPolicyAccessSpecified = true;
                _enterpriseAdminNetworkPolicyAccess = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseAdminNetworkPolicyAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess _enterpriseAdminNumberActivationAccess;

        [XmlElement(ElementName = "enterpriseAdminNumberActivationAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess EnterpriseAdminNumberActivationAccess
        {
            get => _enterpriseAdminNumberActivationAccess;
            set
            {
                EnterpriseAdminNumberActivationAccessSpecified = true;
                _enterpriseAdminNumberActivationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseAdminNumberActivationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess _serviceProviderAdminDialableCallerIDAccess;

        [XmlElement(ElementName = "serviceProviderAdminDialableCallerIDAccess", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:14678")]
        public BroadWorksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess ServiceProviderAdminDialableCallerIDAccess
        {
            get => _serviceProviderAdminDialableCallerIDAccess;
            set
            {
                ServiceProviderAdminDialableCallerIDAccessSpecified = true;
                _serviceProviderAdminDialableCallerIDAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderAdminDialableCallerIDAccessSpecified { get; set; }

    }
}
