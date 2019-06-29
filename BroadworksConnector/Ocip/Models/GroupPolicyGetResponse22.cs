using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPolicyGetRequest22.
    /// Contains the policy settings for the group.
    /// <see cref="GroupPolicyGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""f3a93cf15de4abd7903673e44ee3e07b:5979""}]")]
    public class GroupPolicyGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _callingPlanAccess;

        [XmlElement(ElementName = "callingPlanAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupExtensionAccess _extensionAccess;

        [XmlElement(ElementName = "extensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess _voiceMessagingAccess;

        [XmlElement(ElementName = "voiceMessagingAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _departmentAdminUserAccess;

        [XmlElement(ElementName = "departmentAdminUserAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _departmentAdminTrunkGroupAccess;

        [XmlElement(ElementName = "departmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess _departmentAdminPhoneNumberExtensionAccess;

        [XmlElement(ElementName = "departmentAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess _departmentAdminCallingLineIdNumberAccess;

        [XmlElement(ElementName = "departmentAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _userAuthenticationAccess;

        [XmlElement(ElementName = "userAuthenticationAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _userGroupDirectoryAccess;

        [XmlElement(ElementName = "userGroupDirectoryAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserProfileAccess _userProfileAccess;

        [XmlElement(ElementName = "userProfileAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess _userEnhancedCallLogAccess;

        [XmlElement(ElementName = "userEnhancedCallLogAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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

        private BroadWorksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess _userAutoAttendantNameDialingAccess;

        [XmlElement(ElementName = "userAutoAttendantNameDialingAccess", IsNullable = false, Namespace = "")]
        [Group(@"f3a93cf15de4abd7903673e44ee3e07b:5979")]
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
