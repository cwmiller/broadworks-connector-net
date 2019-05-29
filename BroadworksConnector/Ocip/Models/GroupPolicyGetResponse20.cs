using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPolicyGetResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "callingPlanAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupCallingPlanAccess CallingPlanAccess { get; set; }
    [XmlElement(ElementName = "extensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupExtensionAccess ExtensionAccess { get; set; }
    [XmlElement(ElementName = "ldapIntegrationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess LdapIntegrationAccess { get; set; }
    [XmlElement(ElementName = "voiceMessagingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess VoiceMessagingAccess { get; set; }
    [XmlElement(ElementName = "departmentAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess DepartmentAdminUserAccess { get; set; }
    [XmlElement(ElementName = "departmentAdminTrunkGroupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess DepartmentAdminTrunkGroupAccess { get; set; }
    [XmlElement(ElementName = "departmentAdminPhoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess DepartmentAdminPhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "departmentAdminCallingLineIdNumberAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess DepartmentAdminCallingLineIdNumberAccess { get; set; }
    [XmlElement(ElementName = "userAuthenticationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess UserAuthenticationAccess { get; set; }
    [XmlElement(ElementName = "userGroupDirectoryAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess UserGroupDirectoryAccess { get; set; }
    [XmlElement(ElementName = "userProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserProfileAccess UserProfileAccess { get; set; }
    [XmlElement(ElementName = "userEnhancedCallLogAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserCallLogAccess UserEnhancedCallLogAccess { get; set; }
    [XmlElement(ElementName = "userAutoAttendantNameDialingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess UserAutoAttendantNameDialingAccess { get; set; }
 }
}
