using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPolicyGetRequest14sp4.
    /// Contains the policy settings for the group.
    /// <see cref="GroupPolicyGetRequest14sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:12227""}]")]
    public class GroupPolicyGetResponse14sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _callingPlanAccess;

        [XmlElement(ElementName = "callingPlanAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess CallingPlanAccess
        {
            get => _callingPlanAccess;
            set
            {
                CallingPlanAccessSpecified = true;
                _callingPlanAccess = value;
            }
        }

        [XmlIgnore]
        protected bool CallingPlanAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupExtensionAccess _extensionAccess;

        [XmlElement(ElementName = "extensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupExtensionAccess ExtensionAccess
        {
            get => _extensionAccess;
            set
            {
                ExtensionAccessSpecified = true;
                _extensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool ExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess _ldapIntegrationAccess;

        [XmlElement(ElementName = "ldapIntegrationAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess LdapIntegrationAccess
        {
            get => _ldapIntegrationAccess;
            set
            {
                LdapIntegrationAccessSpecified = true;
                _ldapIntegrationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool LdapIntegrationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess _voiceMessagingAccess;

        [XmlElement(ElementName = "voiceMessagingAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess VoiceMessagingAccess
        {
            get => _voiceMessagingAccess;
            set
            {
                VoiceMessagingAccessSpecified = true;
                _voiceMessagingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessagingAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _departmentAdminUserAccess;

        [XmlElement(ElementName = "departmentAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess DepartmentAdminUserAccess
        {
            get => _departmentAdminUserAccess;
            set
            {
                DepartmentAdminUserAccessSpecified = true;
                _departmentAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAdminUserAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _departmentAdminTrunkGroupAccess;

        [XmlElement(ElementName = "departmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess DepartmentAdminTrunkGroupAccess
        {
            get => _departmentAdminTrunkGroupAccess;
            set
            {
                DepartmentAdminTrunkGroupAccessSpecified = true;
                _departmentAdminTrunkGroupAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAdminTrunkGroupAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _userAuthenticationAccess;

        [XmlElement(ElementName = "userAuthenticationAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess UserAuthenticationAccess
        {
            get => _userAuthenticationAccess;
            set
            {
                UserAuthenticationAccessSpecified = true;
                _userAuthenticationAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserAuthenticationAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _userGroupDirectoryAccess;

        [XmlElement(ElementName = "userGroupDirectoryAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess UserGroupDirectoryAccess
        {
            get => _userGroupDirectoryAccess;
            set
            {
                UserGroupDirectoryAccessSpecified = true;
                _userGroupDirectoryAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserGroupDirectoryAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserProfileAccess _userProfileAccess;

        [XmlElement(ElementName = "userProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupUserProfileAccess UserProfileAccess
        {
            get => _userProfileAccess;
            set
            {
                UserProfileAccessSpecified = true;
                _userProfileAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserProfileAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess _userEnhancedCallLogAccess;

        [XmlElement(ElementName = "userEnhancedCallLogAccess", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:12227")]
        public BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess UserEnhancedCallLogAccess
        {
            get => _userEnhancedCallLogAccess;
            set
            {
                UserEnhancedCallLogAccessSpecified = true;
                _userEnhancedCallLogAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserEnhancedCallLogAccessSpecified { get; set; }

    }
}
