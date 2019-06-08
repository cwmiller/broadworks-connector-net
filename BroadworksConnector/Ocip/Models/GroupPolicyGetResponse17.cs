using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPolicyGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess _departmentAdminTrunkGroupAccess;

    [XmlElement(ElementName = "departmentAdminTrunkGroupAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess DepartmentAdminTrunkGroupAccess {
        get => _departmentAdminTrunkGroupAccess;
        set {
            DepartmentAdminTrunkGroupAccessSpecified = true;
            _departmentAdminTrunkGroupAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAdminTrunkGroupAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess _departmentAdminPhoneNumberExtensionAccess;

    [XmlElement(ElementName = "departmentAdminPhoneNumberExtensionAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess DepartmentAdminPhoneNumberExtensionAccess {
        get => _departmentAdminPhoneNumberExtensionAccess;
        set {
            DepartmentAdminPhoneNumberExtensionAccessSpecified = true;
            _departmentAdminPhoneNumberExtensionAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAdminPhoneNumberExtensionAccessSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess _departmentAdminCallingLineIdNumberAccess;

    [XmlElement(ElementName = "departmentAdminCallingLineIdNumberAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess DepartmentAdminCallingLineIdNumberAccess {
        get => _departmentAdminCallingLineIdNumberAccess;
        set {
            DepartmentAdminCallingLineIdNumberAccessSpecified = true;
            _departmentAdminCallingLineIdNumberAccess = value;
        }
    }

    [XmlIgnore]
    public bool DepartmentAdminCallingLineIdNumberAccessSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess _userEnhancedCallLogAccess;

    [XmlElement(ElementName = "userEnhancedCallLogAccess", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupUserCallLogAccess UserEnhancedCallLogAccess {
        get => _userEnhancedCallLogAccess;
        set {
            UserEnhancedCallLogAccessSpecified = true;
            _userEnhancedCallLogAccess = value;
        }
    }

    [XmlIgnore]
    public bool UserEnhancedCallLogAccessSpecified { get; set; }
}
}