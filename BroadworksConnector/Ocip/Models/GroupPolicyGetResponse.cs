using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupPolicyGetRequest.
    /// Contains the policy settings for the group.
        /// <see cref="GroupPolicyGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupPolicyGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess _callingPlanAccess;

        [XmlElement(ElementName = "callingPlanAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupCallingPlanAccess CallingPlanAccess {
            get => _callingPlanAccess;
            set {
                CallingPlanAccessSpecified = true;
                _callingPlanAccess = value;
            }
        }

        [XmlIgnore]
        public bool CallingPlanAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupExtensionAccess _extensionAccess;

        [XmlElement(ElementName = "extensionAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupExtensionAccess ExtensionAccess {
            get => _extensionAccess;
            set {
                ExtensionAccessSpecified = true;
                _extensionAccess = value;
            }
        }

        [XmlIgnore]
        public bool ExtensionAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess _ldapIntegrationAccess;

        [XmlElement(ElementName = "ldapIntegrationAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupLDAPIntegrationAccess LdapIntegrationAccess {
            get => _ldapIntegrationAccess;
            set {
                LdapIntegrationAccessSpecified = true;
                _ldapIntegrationAccess = value;
            }
        }

        [XmlIgnore]
        public bool LdapIntegrationAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess _voiceMessagingAccess;

        [XmlElement(ElementName = "voiceMessagingAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupVoiceMessagingAccess VoiceMessagingAccess {
            get => _voiceMessagingAccess;
            set {
                VoiceMessagingAccessSpecified = true;
                _voiceMessagingAccess = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMessagingAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess _departmentAdminUserAccess;

        [XmlElement(ElementName = "departmentAdminUserAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminUserAccess DepartmentAdminUserAccess {
            get => _departmentAdminUserAccess;
            set {
                DepartmentAdminUserAccessSpecified = true;
                _departmentAdminUserAccess = value;
            }
        }

        [XmlIgnore]
        public bool DepartmentAdminUserAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess _userAuthenticationAccess;

        [XmlElement(ElementName = "userAuthenticationAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupUserAuthenticationAccess UserAuthenticationAccess {
            get => _userAuthenticationAccess;
            set {
                UserAuthenticationAccessSpecified = true;
                _userAuthenticationAccess = value;
            }
        }

        [XmlIgnore]
        public bool UserAuthenticationAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess _userGroupDirectoryAccess;

        [XmlElement(ElementName = "userGroupDirectoryAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupUserGroupDirectoryAccess UserGroupDirectoryAccess {
            get => _userGroupDirectoryAccess;
            set {
                UserGroupDirectoryAccessSpecified = true;
                _userGroupDirectoryAccess = value;
            }
        }

        [XmlIgnore]
        public bool UserGroupDirectoryAccessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.GroupUserProfileAccess _userProfileAccess;

        [XmlElement(ElementName = "userProfileAccess", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.GroupUserProfileAccess UserProfileAccess {
            get => _userProfileAccess;
            set {
                UserProfileAccessSpecified = true;
                _userProfileAccess = value;
            }
        }

        [XmlIgnore]
        public bool UserProfileAccessSpecified { get; set; }
        
    }
}
