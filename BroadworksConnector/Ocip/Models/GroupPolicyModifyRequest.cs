using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the policies for a Group.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode:
    /// userAutoAttendantNameDialingAccess
    /// 
    /// Replaced by: GroupPolicyModifyRequest22 in AS data mode
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupPolicyModifyRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""240b50f54d060859e5e275082fdf49f9:4210""}]")]
    public class GroupPolicyModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _callingPlanAccess;

        [XmlElement(ElementName = "callingPlanAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess _departmentAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "departmentAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess DepartmentAdminPhoneNumberExtensionAccess
        {
            get => _departmentAdminPhoneNumberExtensionAccess;
            set
            {
                DepartmentAdminPhoneNumberExtensionAccessSpecified = true;
                _departmentAdminPhoneNumberExtensionAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAdminPhoneNumberExtensionAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess _departmentAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "departmentAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess DepartmentAdminCallingLineIdNumberAccess
        {
            get => _departmentAdminCallingLineIdNumberAccess;
            set
            {
                DepartmentAdminCallingLineIdNumberAccessSpecified = true;
                _departmentAdminCallingLineIdNumberAccess = value;
            }
        }

        [XmlIgnore]
        protected bool DepartmentAdminCallingLineIdNumberAccessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _userAuthenticationAccess;

        [XmlElement(ElementName = "userAuthenticationAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
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

        protected BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess _userAutoAttendantNameDialingAccess;

        [XmlElement(ElementName = "userAutoAttendantNameDialingAccess", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"240b50f54d060859e5e275082fdf49f9:4210")]
        public BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess UserAutoAttendantNameDialingAccess
        {
            get => _userAutoAttendantNameDialingAccess;
            set
            {
                UserAutoAttendantNameDialingAccessSpecified = true;
                _userAutoAttendantNameDialingAccess = value;
            }
        }

        [XmlIgnore]
        protected bool UserAutoAttendantNameDialingAccessSpecified { get; set; }

    }
}
