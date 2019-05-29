using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemPolicyGetDefaultResponse20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "groupCallingPlanAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupCallingPlanAccess GroupCallingPlanAccess { get; set; }
    [XmlElement(ElementName = "groupExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupExtensionAccess GroupExtensionAccess { get; set; }
    [XmlElement(ElementName = "groupLDAPIntegrationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupLDAPIntegrationAccess GroupLDAPIntegrationAccess { get; set; }
    [XmlElement(ElementName = "groupVoiceMessagingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupVoiceMessagingAccess GroupVoiceMessagingAccess { get; set; }
    [XmlElement(ElementName = "groupDepartmentAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminUserAccess GroupDepartmentAdminUserAccess { get; set; }
    [XmlElement(ElementName = "groupDepartmentAdminTrunkGroupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminTrunkGroupAccess GroupDepartmentAdminTrunkGroupAccess { get; set; }
    [XmlElement(ElementName = "groupDepartmentAdminPhoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminPhoneNumberExtensionAccess GroupDepartmentAdminPhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "groupDepartmentAdminCallingLineIdNumberAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupDepartmentAdminCallingLineIdNumberAccess GroupDepartmentAdminCallingLineIdNumberAccess { get; set; }
    [XmlElement(ElementName = "groupUserAuthenticationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserAuthenticationAccess GroupUserAuthenticationAccess { get; set; }
    [XmlElement(ElementName = "groupUserGroupDirectoryAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserGroupDirectoryAccess GroupUserGroupDirectoryAccess { get; set; }
    [XmlElement(ElementName = "groupUserProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserProfileAccess GroupUserProfileAccess { get; set; }
    [XmlElement(ElementName = "groupUserEnhancedCallLogsAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserCallLogAccess GroupUserEnhancedCallLogsAccess { get; set; }
    [XmlElement(ElementName = "groupUserAutoAttendantNameDialingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupUserAutoAttendantNameDialingAccess GroupUserAutoAttendantNameDialingAccess { get; set; }
    [XmlElement(ElementName = "groupAdminProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminProfileAccess GroupAdminProfileAccess { get; set; }
    [XmlElement(ElementName = "groupAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminUserAccess GroupAdminUserAccess { get; set; }
    [XmlElement(ElementName = "groupAdminAdminAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminAdminAccess GroupAdminAdminAccess { get; set; }
    [XmlElement(ElementName = "groupAdminDepartmentAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminDepartmentAccess GroupAdminDepartmentAccess { get; set; }
    [XmlElement(ElementName = "groupAdminAccessDeviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminAccessDeviceAccess GroupAdminAccessDeviceAccess { get; set; }
    [XmlElement(ElementName = "groupAdminEnhancedServiceInstanceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminEnhancedServiceInstanceAccess GroupAdminEnhancedServiceInstanceAccess { get; set; }
    [XmlElement(ElementName = "groupAdminFeatureAccessCodeAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminFeatureAccessCodeAccess GroupAdminFeatureAccessCodeAccess { get; set; }
    [XmlElement(ElementName = "groupAdminPhoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminPhoneNumberExtensionAccess GroupAdminPhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "groupAdminCallingLineIdNumberAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminCallingLineIdNumberAccess GroupAdminCallingLineIdNumberAccess { get; set; }
    [XmlElement(ElementName = "groupAdminServiceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminServiceAccess GroupAdminServiceAccess { get; set; }
    [XmlElement(ElementName = "groupAdminTrunkGroupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminTrunkGroupAccess GroupAdminTrunkGroupAccess { get; set; }
    [XmlElement(ElementName = "groupAdminVerifyTranslationAndRoutingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminVerifyTranslationAndRoutingAccess GroupAdminVerifyTranslationAndRoutingAccess { get; set; }
    [XmlElement(ElementName = "groupAdminSessionAdmissionControlAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminSessionAdmissionControlAccess GroupAdminSessionAdmissionControlAccess { get; set; }
    [XmlElement(ElementName = "groupAdminOfficeZoneAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminOfficeZoneAccess GroupAdminOfficeZoneAccess { get; set; }
    [XmlElement(ElementName = "groupAdminNumberActivationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminNumberActivationAccess GroupAdminNumberActivationAccess { get; set; }
    [XmlElement(ElementName = "groupAdminDialableCallerIDAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminDialableCallerIDAccess GroupAdminDialableCallerIDAccess { get; set; }
    [XmlElement(ElementName = "groupAdminCommunicationBarringUserProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupAdminCommunicationBarringUserProfileAccess GroupAdminCommunicationBarringUserProfileAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminProfileAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminProfileAccess ServiceProviderAdminProfileAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminGroupAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminGroupAccess ServiceProviderAdminGroupAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminUserAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminUserAccess ServiceProviderAdminUserAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminAdminAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAdminAccess ServiceProviderAdminAdminAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminDepartmentAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDepartmentAccess ServiceProviderAdminDepartmentAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminAccessDeviceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminAccessDeviceAccess ServiceProviderAdminAccessDeviceAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminPhoneNumberExtensionAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminPhoneNumberExtensionAccess ServiceProviderAdminPhoneNumberExtensionAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminCallingLineIdNumberAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCallingLineIdNumberAccess ServiceProviderAdminCallingLineIdNumberAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminServiceAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServiceAccess ServiceProviderAdminServiceAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminServicePackAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminServicePackAccess ServiceProviderAdminServicePackAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminSessionAdmissionControlAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminSessionAdmissionControlAccess ServiceProviderAdminSessionAdmissionControlAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminVerifyTranslationAndRoutingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminVerifyTranslationAndRoutingAccess ServiceProviderAdminVerifyTranslationAndRoutingAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminWebBrandingAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminWebBrandingAccess ServiceProviderAdminWebBrandingAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminOfficeZoneAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminOfficeZoneAccess ServiceProviderAdminOfficeZoneAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminCommunicationBarringAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminCommunicationBarringAccess ServiceProviderAdminCommunicationBarringAccess { get; set; }
    [XmlElement(ElementName = "enterpriseAdminNetworkPolicyAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNetworkPolicyAccess EnterpriseAdminNetworkPolicyAccess { get; set; }
    [XmlElement(ElementName = "enterpriseAdminNumberActivationAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseAdminNumberActivationAccess EnterpriseAdminNumberActivationAccess { get; set; }
    [XmlElement(ElementName = "serviceProviderAdminDialableCallerIDAccess", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderAdminDialableCallerIDAccess ServiceProviderAdminDialableCallerIDAccess { get; set; }
 }
}
