using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileVoiceXMLProfileModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "callProcessingPolicyProfileName", IsNullable = false)]
    public string CallProcessingPolicyProfileName { get; set; }
    [XmlElement(ElementName = "useCLIDPolicy", IsNullable = false)]
    public bool UseCLIDPolicy { get; set; }
    [XmlElement(ElementName = "clidPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupCLIDPolicy ClidPolicy { get; set; }
    [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupCLIDPolicy EmergencyClidPolicy { get; set; }
    [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false)]
    public bool AllowAlternateNumbersForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "useGroupName", IsNullable = false)]
    public bool UseGroupName { get; set; }
    [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false)]
    public bool BlockCallingNameForExternalCalls { get; set; }
    [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false)]
    public bool AllowConfigurableCLIDForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "allowDepartmentCLIDNameOverride", IsNullable = false)]
    public bool AllowDepartmentCLIDNameOverride { get; set; }
    [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseCallsCLIDPolicy { get; set; }
    [XmlElement(ElementName = "enterpriseGroupCallsCLIDPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseGroupCallsCLIDPolicy { get; set; }
    [XmlElement(ElementName = "serviceProviderGroupCallsCLIDPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy ServiceProviderGroupCallsCLIDPolicy { get; set; }
    [XmlElement(ElementName = "useCallLimitsPolicy", IsNullable = false)]
    public bool UseCallLimitsPolicy { get; set; }
    [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false)]
    public bool UseMaxSimultaneousCalls { get; set; }
    [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false)]
    public int MaxSimultaneousCalls { get; set; }
    [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false)]
    public bool UseMaxSimultaneousVideoCalls { get; set; }
    [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false)]
    public int MaxSimultaneousVideoCalls { get; set; }
    [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false)]
    public bool UseMaxCallTimeForAnsweredCalls { get; set; }
    [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false)]
    public int MaxCallTimeForAnsweredCallsMinutes { get; set; }
    [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false)]
    public bool UseMaxCallTimeForUnansweredCalls { get; set; }
    [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false)]
    public int MaxCallTimeForUnansweredCallsMinutes { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false)]
    public bool UseMaxConcurrentRedirectedCalls { get; set; }
    [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false)]
    public int MaxConcurrentRedirectedCalls { get; set; }
    [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false)]
    public int MaxRedirectionDepth { get; set; }
    [XmlElement(ElementName = "useTranslationRoutingPolicy", IsNullable = false)]
    public bool UseTranslationRoutingPolicy { get; set; }
    [XmlElement(ElementName = "networkUsageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection { get; set; }
    [XmlElement(ElementName = "enableEnterpriseExtensionDialing", IsNullable = false)]
    public bool EnableEnterpriseExtensionDialing { get; set; }
    [XmlElement(ElementName = "enforceGroupCallingLineIdentityRestriction", IsNullable = false)]
    public bool EnforceGroupCallingLineIdentityRestriction { get; set; }
    [XmlElement(ElementName = "enforceEnterpriseCallingLineIdentityRestriction", IsNullable = false)]
    public bool EnforceEnterpriseCallingLineIdentityRestriction { get; set; }
    [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPrivateDialingPlan", IsNullable = false)]
    public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlan { get; set; }
    [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPublicDialingPlan", IsNullable = false)]
    public bool AllowEnterpriseGroupCallTypingForPublicDialingPlan { get; set; }
    [XmlElement(ElementName = "overrideCLIDRestrictionForPrivateCallCategory", IsNullable = false)]
    public bool OverrideCLIDRestrictionForPrivateCallCategory { get; set; }
    [XmlElement(ElementName = "useEnterpriseCLIDForPrivateCallCategory", IsNullable = false)]
    public bool UseEnterpriseCLIDForPrivateCallCategory { get; set; }
    [XmlElement(ElementName = "useIncomingCLIDPolicy", IsNullable = false)]
    public bool UseIncomingCLIDPolicy { get; set; }
    [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false)]
    public bool EnableDialableCallerID { get; set; }
    [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false)]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCalls { get; set; }
    [XmlElement(ElementName = "useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable", IsNullable = false)]
    public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable { get; set; }
    [XmlElement(ElementName = "useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable", IsNullable = false)]
    public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable { get; set; }
 }
}
