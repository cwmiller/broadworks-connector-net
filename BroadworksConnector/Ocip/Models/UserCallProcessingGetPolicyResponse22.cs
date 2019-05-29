using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallProcessingGetPolicyResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "useUserCLIDSetting", IsNullable = false)]
    public bool UseUserCLIDSetting { get; set; }
    [XmlElement(ElementName = "useUserMediaSetting", IsNullable = false)]
    public bool UseUserMediaSetting { get; set; }
    [XmlElement(ElementName = "useUserCallLimitsSetting", IsNullable = false)]
    public bool UseUserCallLimitsSetting { get; set; }
    [XmlElement(ElementName = "useUserDCLIDSetting", IsNullable = false)]
    public bool UseUserDCLIDSetting { get; set; }
    [XmlElement(ElementName = "useUserTranslationRoutingSetting", IsNullable = false)]
    public bool UseUserTranslationRoutingSetting { get; set; }
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
    [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false)]
    public string SupportedMediaSetName { get; set; }
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
    public BroadworksConnector.Ocip.Models.GroupCLIDPolicy ClidPolicy { get; set; }
    [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.GroupCLIDPolicy EmergencyClidPolicy { get; set; }
    [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false)]
    public bool AllowAlternateNumbersForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "useGroupName", IsNullable = false)]
    public bool UseGroupName { get; set; }
    [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false)]
    public bool BlockCallingNameForExternalCalls { get; set; }
    [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false)]
    public bool EnableDialableCallerID { get; set; }
    [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false)]
    public bool AllowConfigurableCLIDForRedirectingIdentity { get; set; }
    [XmlElement(ElementName = "allowDepartmentCLIDNameOverride", IsNullable = false)]
    public bool AllowDepartmentCLIDNameOverride { get; set; }
    [XmlElement(ElementName = "useUserPhoneListLookupSetting", IsNullable = false)]
    public bool UseUserPhoneListLookupSetting { get; set; }
    [XmlElement(ElementName = "enablePhoneListLookup", IsNullable = false)]
    public bool EnablePhoneListLookup { get; set; }
    [XmlElement(ElementName = "useMaxConcurrentTerminatingAlertingRequests", IsNullable = false)]
    public bool UseMaxConcurrentTerminatingAlertingRequests { get; set; }
    [XmlElement(ElementName = "maxConcurrentTerminatingAlertingRequests", IsNullable = false)]
    public int MaxConcurrentTerminatingAlertingRequests { get; set; }
    [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false)]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCalls { get; set; }
    [XmlElement(ElementName = "routeOverrideDomain", IsNullable = false)]
    public string RouteOverrideDomain { get; set; }
    [XmlElement(ElementName = "routeOverridePrefix", IsNullable = false)]
    public string RouteOverridePrefix { get; set; }
 }
}
