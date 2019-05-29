using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingModifyPolicyRequest15 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
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
    [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection { get; set; }
    [XmlElement(ElementName = "supportedMediaSetName", IsNullable = true)]
    public string SupportedMediaSetName { get; set; }
    [XmlElement(ElementName = "networkUsageSelection", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection { get; set; }
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
    [XmlElement(ElementName = "enableEnterpriseExtensionDialing", IsNullable = false)]
    public bool EnableEnterpriseExtensionDialing { get; set; }
    [XmlElement(ElementName = "conferenceURI", IsNullable = true)]
    public string ConferenceURI { get; set; }
    [XmlElement(ElementName = "maxConferenceParties", IsNullable = false)]
    public int MaxConferenceParties { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false)]
    public bool UseMaxConcurrentRedirectedCalls { get; set; }
    [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false)]
    public int MaxConcurrentRedirectedCalls { get; set; }
    [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false)]
    public bool UseMaxFindMeFollowMeDepth { get; set; }
    [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false)]
    public int MaxFindMeFollowMeDepth { get; set; }
    [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false)]
    public int MaxRedirectionDepth { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false)]
    public bool UseMaxConcurrentFindMeFollowMeInvocations { get; set; }
    [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false)]
    public int MaxConcurrentFindMeFollowMeInvocations { get; set; }
    [XmlElement(ElementName = "clidPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CLIDPolicy ClidPolicy { get; set; }
    [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.CLIDPolicy EmergencyClidPolicy { get; set; }
    [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false)]
    public bool AllowAlternateNumbersForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false)]
    public bool EnableDialableCallerID { get; set; }
    [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false)]
    public bool BlockCallingNameForExternalCalls { get; set; }
    [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false)]
    public bool AllowConfigurableCLIDForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseCallsCLIDPolicy { get; set; }
    [XmlElement(ElementName = "enterpriseGroupCallsCLIDPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseGroupCallsCLIDPolicy { get; set; }
    [XmlElement(ElementName = "serviceProviderGroupCallsCLIDPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy ServiceProviderGroupCallsCLIDPolicy { get; set; }
    [XmlElement(ElementName = "enablePhoneListLookup", IsNullable = false)]
    public bool EnablePhoneListLookup { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentTerminatingAlertingRequests", IsNullable = false)]
    public bool UseMaxConcurrentTerminatingAlertingRequests { get; set; }
    [XmlElement(ElementName = "maxConcurrentTerminatingAlertingRequests", IsNullable = false)]
    public int MaxConcurrentTerminatingAlertingRequests { get; set; }
    [XmlElement(ElementName = "delayTimerToRemoveCancelledCallsInSeconds", IsNullable = false)]
    public int DelayTimerToRemoveCancelledCallsInSeconds { get; set; }
    [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false)]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCalls { get; set; }
    [XmlElement(ElementName = "useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable", IsNullable = false)]
    public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable { get; set; }
    [XmlElement(ElementName = "useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable", IsNullable = false)]
    public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable { get; set; }
    [XmlElement(ElementName = "routeOverrideDomain", IsNullable = true)]
    public string RouteOverrideDomain { get; set; }
    [XmlElement(ElementName = "routeOverridePrefix", IsNullable = true)]
    public string RouteOverridePrefix { get; set; }
    [XmlElement(ElementName = "allowMobileDNForRedirectingIdentity", IsNullable = false)]
    public bool AllowMobileDNForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "conferenceDisableClampTones", IsNullable = false)]
    public bool ConferenceDisableClampTones { get; set; }
 }
}
