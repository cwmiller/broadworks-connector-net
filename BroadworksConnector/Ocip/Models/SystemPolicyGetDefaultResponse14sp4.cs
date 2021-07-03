using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemPolicyGetDefaultRequest14sp4.
    /// Contains the default policy settings for the system.
    /// <see cref="SystemPolicyGetDefaultRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:28619""}]")]
    public class SystemPolicyGetDefaultResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _groupCallingPlanAccess;

        [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupExtensionAccess _groupExtensionAccess;

        [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess _groupLDAPIntegrationAccess;

        [XmlElement(ElementName = "groupLDAPIntegrationAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
        public BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess GroupLDAPIntegrationAccess
        {
            get => _groupLDAPIntegrationAccess;
            set
            {
                GroupLDAPIntegrationAccessSpecified = true;
                _groupLDAPIntegrationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool GroupLDAPIntegrationAccessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess _groupVoiceMessagingAccess;

        [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _groupDepartmentAdminUserAccess;

        [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _groupDepartmentAdminTrunkGroupAccess;

        [XmlElement(ElementName = "groupDepartmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _groupUserAuthenticationAccess;

        [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _groupUserGroupDirectoryAccess;

        [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserProfileAccess _groupUserProfileAccess;

        [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess _groupUserEnhancedCallLogsAccess;

        [XmlElement(ElementName = "groupUserEnhancedCallLogsAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminProfileAccess _groupAdminProfileAccess;

        [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminUserAccess _groupAdminUserAccess;

        [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminAdminAccess _groupAdminAdminAccess;

        [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminDepartmentAccess _groupAdminDepartmentAccess;

        [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminAccessDeviceAccess _groupAdminAccessDeviceAccess;

        [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess _groupAdminEnhancedServiceInstanceAccess;

        [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess _groupAdminFeatureAccessCodeAccess;

        [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess _groupAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminServiceAccess _groupAdminServiceAccess;

        [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.GroupAdminTrunkGroupAccess _groupAdminTrunkGroupAccess;

        [XmlElement(ElementName = "groupAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminProfileAccess _serviceProviderAdminProfileAccess;

        [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminGroupAccess _serviceProviderAdminGroupAccess;

        [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminUserAccess _serviceProviderAdminUserAccess;

        [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAdminAccess _serviceProviderAdminAdminAccess;

        [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess _serviceProviderAdminDepartmentAccess;

        [XmlElement(ElementName = "serviceProviderAdminDepartmentAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess _serviceProviderAdminAccessDeviceAccess;

        [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess _serviceProviderAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServiceAccess _serviceProviderAdminServiceAccess;

        [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess _serviceProviderAdminServicePackAccess;

        [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess _serviceProviderAdminWebBrandingAccess;

        [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

        private BroadWorksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess _enterpriseAdminNetworkPolicyAccess;

        [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:28619")]
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

    }
}
