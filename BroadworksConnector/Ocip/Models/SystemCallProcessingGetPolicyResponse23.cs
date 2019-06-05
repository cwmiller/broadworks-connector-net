using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingGetPolicyResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useMaxSimultaneousCalls;

    [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxSimultaneousCalls {
        get => _useMaxSimultaneousCalls;
        set {
            UseMaxSimultaneousCallsSpecified = true;
            _useMaxSimultaneousCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxSimultaneousCallsSpecified { get; set; }
    private int _maxSimultaneousCalls;

    [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
    public int MaxSimultaneousCalls {
        get => _maxSimultaneousCalls;
        set {
            MaxSimultaneousCallsSpecified = true;
            _maxSimultaneousCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxSimultaneousCallsSpecified { get; set; }
    private bool _useMaxSimultaneousVideoCalls;

    [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxSimultaneousVideoCalls {
        get => _useMaxSimultaneousVideoCalls;
        set {
            UseMaxSimultaneousVideoCallsSpecified = true;
            _useMaxSimultaneousVideoCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxSimultaneousVideoCallsSpecified { get; set; }
    private int _maxSimultaneousVideoCalls;

    [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
    public int MaxSimultaneousVideoCalls {
        get => _maxSimultaneousVideoCalls;
        set {
            MaxSimultaneousVideoCallsSpecified = true;
            _maxSimultaneousVideoCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxSimultaneousVideoCallsSpecified { get; set; }
    private bool _useMaxCallTimeForAnsweredCalls;

    [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxCallTimeForAnsweredCalls {
        get => _useMaxCallTimeForAnsweredCalls;
        set {
            UseMaxCallTimeForAnsweredCallsSpecified = true;
            _useMaxCallTimeForAnsweredCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxCallTimeForAnsweredCallsSpecified { get; set; }
    private int _maxCallTimeForAnsweredCallsMinutes;

    [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false, Namespace = "")]
    public int MaxCallTimeForAnsweredCallsMinutes {
        get => _maxCallTimeForAnsweredCallsMinutes;
        set {
            MaxCallTimeForAnsweredCallsMinutesSpecified = true;
            _maxCallTimeForAnsweredCallsMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MaxCallTimeForAnsweredCallsMinutesSpecified { get; set; }
    private bool _useMaxCallTimeForUnansweredCalls;

    [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxCallTimeForUnansweredCalls {
        get => _useMaxCallTimeForUnansweredCalls;
        set {
            UseMaxCallTimeForUnansweredCallsSpecified = true;
            _useMaxCallTimeForUnansweredCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxCallTimeForUnansweredCallsSpecified { get; set; }
    private int _maxCallTimeForUnansweredCallsMinutes;

    [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false, Namespace = "")]
    public int MaxCallTimeForUnansweredCallsMinutes {
        get => _maxCallTimeForUnansweredCallsMinutes;
        set {
            MaxCallTimeForUnansweredCallsMinutesSpecified = true;
            _maxCallTimeForUnansweredCallsMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MaxCallTimeForUnansweredCallsMinutesSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

    [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection {
        get => _mediaPolicySelection;
        set {
            MediaPolicySelectionSpecified = true;
            _mediaPolicySelection = value;
        }
    }

    [XmlIgnore]
    public bool MediaPolicySelectionSpecified { get; set; }
    private string _supportedMediaSetName;

    [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false, Namespace = "")]
    public string SupportedMediaSetName {
        get => _supportedMediaSetName;
        set {
            SupportedMediaSetNameSpecified = true;
            _supportedMediaSetName = value;
        }
    }

    [XmlIgnore]
    public bool SupportedMediaSetNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.NetworkUsageSelection _networkUsageSelection;

    [XmlElement(ElementName = "networkUsageSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection {
        get => _networkUsageSelection;
        set {
            NetworkUsageSelectionSpecified = true;
            _networkUsageSelection = value;
        }
    }

    [XmlIgnore]
    public bool NetworkUsageSelectionSpecified { get; set; }
    private bool _enforceGroupCallingLineIdentityRestriction;

    [XmlElement(ElementName = "enforceGroupCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
    public bool EnforceGroupCallingLineIdentityRestriction {
        get => _enforceGroupCallingLineIdentityRestriction;
        set {
            EnforceGroupCallingLineIdentityRestrictionSpecified = true;
            _enforceGroupCallingLineIdentityRestriction = value;
        }
    }

    [XmlIgnore]
    public bool EnforceGroupCallingLineIdentityRestrictionSpecified { get; set; }
    private bool _enforceEnterpriseCallingLineIdentityRestriction;

    [XmlElement(ElementName = "enforceEnterpriseCallingLineIdentityRestriction", IsNullable = false, Namespace = "")]
    public bool EnforceEnterpriseCallingLineIdentityRestriction {
        get => _enforceEnterpriseCallingLineIdentityRestriction;
        set {
            EnforceEnterpriseCallingLineIdentityRestrictionSpecified = true;
            _enforceEnterpriseCallingLineIdentityRestriction = value;
        }
    }

    [XmlIgnore]
    public bool EnforceEnterpriseCallingLineIdentityRestrictionSpecified { get; set; }
    private bool _allowEnterpriseGroupCallTypingForPrivateDialingPlan;

    [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPrivateDialingPlan", IsNullable = false, Namespace = "")]
    public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlan {
        get => _allowEnterpriseGroupCallTypingForPrivateDialingPlan;
        set {
            AllowEnterpriseGroupCallTypingForPrivateDialingPlanSpecified = true;
            _allowEnterpriseGroupCallTypingForPrivateDialingPlan = value;
        }
    }

    [XmlIgnore]
    public bool AllowEnterpriseGroupCallTypingForPrivateDialingPlanSpecified { get; set; }
    private bool _allowEnterpriseGroupCallTypingForPublicDialingPlan;

    [XmlElement(ElementName = "allowEnterpriseGroupCallTypingForPublicDialingPlan", IsNullable = false, Namespace = "")]
    public bool AllowEnterpriseGroupCallTypingForPublicDialingPlan {
        get => _allowEnterpriseGroupCallTypingForPublicDialingPlan;
        set {
            AllowEnterpriseGroupCallTypingForPublicDialingPlanSpecified = true;
            _allowEnterpriseGroupCallTypingForPublicDialingPlan = value;
        }
    }

    [XmlIgnore]
    public bool AllowEnterpriseGroupCallTypingForPublicDialingPlanSpecified { get; set; }
    private bool _overrideCLIDRestrictionForPrivateCallCategory;

    [XmlElement(ElementName = "overrideCLIDRestrictionForPrivateCallCategory", IsNullable = false, Namespace = "")]
    public bool OverrideCLIDRestrictionForPrivateCallCategory {
        get => _overrideCLIDRestrictionForPrivateCallCategory;
        set {
            OverrideCLIDRestrictionForPrivateCallCategorySpecified = true;
            _overrideCLIDRestrictionForPrivateCallCategory = value;
        }
    }

    [XmlIgnore]
    public bool OverrideCLIDRestrictionForPrivateCallCategorySpecified { get; set; }
    private bool _useEnterpriseCLIDForPrivateCallCategory;

    [XmlElement(ElementName = "useEnterpriseCLIDForPrivateCallCategory", IsNullable = false, Namespace = "")]
    public bool UseEnterpriseCLIDForPrivateCallCategory {
        get => _useEnterpriseCLIDForPrivateCallCategory;
        set {
            UseEnterpriseCLIDForPrivateCallCategorySpecified = true;
            _useEnterpriseCLIDForPrivateCallCategory = value;
        }
    }

    [XmlIgnore]
    public bool UseEnterpriseCLIDForPrivateCallCategorySpecified { get; set; }
    private bool _enableEnterpriseExtensionDialing;

    [XmlElement(ElementName = "enableEnterpriseExtensionDialing", IsNullable = false, Namespace = "")]
    public bool EnableEnterpriseExtensionDialing {
        get => _enableEnterpriseExtensionDialing;
        set {
            EnableEnterpriseExtensionDialingSpecified = true;
            _enableEnterpriseExtensionDialing = value;
        }
    }

    [XmlIgnore]
    public bool EnableEnterpriseExtensionDialingSpecified { get; set; }
    private string _conferenceURI;

    [XmlElement(ElementName = "conferenceURI", IsNullable = false, Namespace = "")]
    public string ConferenceURI {
        get => _conferenceURI;
        set {
            ConferenceURISpecified = true;
            _conferenceURI = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceURISpecified { get; set; }
    private int _maxConferenceParties;

    [XmlElement(ElementName = "maxConferenceParties", IsNullable = false, Namespace = "")]
    public int MaxConferenceParties {
        get => _maxConferenceParties;
        set {
            MaxConferencePartiesSpecified = true;
            _maxConferenceParties = value;
        }
    }

    [XmlIgnore]
    public bool MaxConferencePartiesSpecified { get; set; }
    private bool _useMaxConcurrentRedirectedCalls;

    [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
    public bool UseMaxConcurrentRedirectedCalls {
        get => _useMaxConcurrentRedirectedCalls;
        set {
            UseMaxConcurrentRedirectedCallsSpecified = true;
            _useMaxConcurrentRedirectedCalls = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxConcurrentRedirectedCallsSpecified { get; set; }
    private int _maxConcurrentRedirectedCalls;

    [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
    public int MaxConcurrentRedirectedCalls {
        get => _maxConcurrentRedirectedCalls;
        set {
            MaxConcurrentRedirectedCallsSpecified = true;
            _maxConcurrentRedirectedCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentRedirectedCallsSpecified { get; set; }
    private bool _useMaxFindMeFollowMeDepth;

    [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
    public bool UseMaxFindMeFollowMeDepth {
        get => _useMaxFindMeFollowMeDepth;
        set {
            UseMaxFindMeFollowMeDepthSpecified = true;
            _useMaxFindMeFollowMeDepth = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxFindMeFollowMeDepthSpecified { get; set; }
    private int _maxFindMeFollowMeDepth;

    [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
    public int MaxFindMeFollowMeDepth {
        get => _maxFindMeFollowMeDepth;
        set {
            MaxFindMeFollowMeDepthSpecified = true;
            _maxFindMeFollowMeDepth = value;
        }
    }

    [XmlIgnore]
    public bool MaxFindMeFollowMeDepthSpecified { get; set; }
    private int _maxRedirectionDepth;

    [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
    public int MaxRedirectionDepth {
        get => _maxRedirectionDepth;
        set {
            MaxRedirectionDepthSpecified = true;
            _maxRedirectionDepth = value;
        }
    }

    [XmlIgnore]
    public bool MaxRedirectionDepthSpecified { get; set; }
    private bool _useMaxConcurrentFindMeFollowMeInvocations;

    [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
    public bool UseMaxConcurrentFindMeFollowMeInvocations {
        get => _useMaxConcurrentFindMeFollowMeInvocations;
        set {
            UseMaxConcurrentFindMeFollowMeInvocationsSpecified = true;
            _useMaxConcurrentFindMeFollowMeInvocations = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }
    private int _maxConcurrentFindMeFollowMeInvocations;

    [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
    public int MaxConcurrentFindMeFollowMeInvocations {
        get => _maxConcurrentFindMeFollowMeInvocations;
        set {
            MaxConcurrentFindMeFollowMeInvocationsSpecified = true;
            _maxConcurrentFindMeFollowMeInvocations = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CLIDPolicy _clidPolicy;

    [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CLIDPolicy ClidPolicy {
        get => _clidPolicy;
        set {
            ClidPolicySpecified = true;
            _clidPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ClidPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CLIDPolicy _emergencyClidPolicy;

    [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CLIDPolicy EmergencyClidPolicy {
        get => _emergencyClidPolicy;
        set {
            EmergencyClidPolicySpecified = true;
            _emergencyClidPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EmergencyClidPolicySpecified { get; set; }
    private bool _allowAlternateNumbersForRedirectingIdentity;

    [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false, Namespace = "")]
    public bool AllowAlternateNumbersForRedirectingIdentity {
        get => _allowAlternateNumbersForRedirectingIdentity;
        set {
            AllowAlternateNumbersForRedirectingIdentitySpecified = true;
            _allowAlternateNumbersForRedirectingIdentity = value;
        }
    }

    [XmlIgnore]
    public bool AllowAlternateNumbersForRedirectingIdentitySpecified { get; set; }
    private bool _blockCallingNameForExternalCalls;

    [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false, Namespace = "")]
    public bool BlockCallingNameForExternalCalls {
        get => _blockCallingNameForExternalCalls;
        set {
            BlockCallingNameForExternalCallsSpecified = true;
            _blockCallingNameForExternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool BlockCallingNameForExternalCallsSpecified { get; set; }
    private bool _enableDialableCallerID;

    [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false, Namespace = "")]
    public bool EnableDialableCallerID {
        get => _enableDialableCallerID;
        set {
            EnableDialableCallerIDSpecified = true;
            _enableDialableCallerID = value;
        }
    }

    [XmlIgnore]
    public bool EnableDialableCallerIDSpecified { get; set; }
    private bool _allowConfigurableCLIDForRedirectingIdentity;

    [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false, Namespace = "")]
    public bool AllowConfigurableCLIDForRedirectingIdentity {
        get => _allowConfigurableCLIDForRedirectingIdentity;
        set {
            AllowConfigurableCLIDForRedirectingIdentitySpecified = true;
            _allowConfigurableCLIDForRedirectingIdentity = value;
        }
    }

    [XmlIgnore]
    public bool AllowConfigurableCLIDForRedirectingIdentitySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseCallsCLIDPolicy;

    [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseCallsCLIDPolicy {
        get => _enterpriseCallsCLIDPolicy;
        set {
            EnterpriseCallsCLIDPolicySpecified = true;
            _enterpriseCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseCallsCLIDPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseGroupCallsCLIDPolicy;

    [XmlElement(ElementName = "enterpriseGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseGroupCallsCLIDPolicy {
        get => _enterpriseGroupCallsCLIDPolicy;
        set {
            EnterpriseGroupCallsCLIDPolicySpecified = true;
            _enterpriseGroupCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseGroupCallsCLIDPolicySpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy _serviceProviderGroupCallsCLIDPolicy;

    [XmlElement(ElementName = "serviceProviderGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy ServiceProviderGroupCallsCLIDPolicy {
        get => _serviceProviderGroupCallsCLIDPolicy;
        set {
            ServiceProviderGroupCallsCLIDPolicySpecified = true;
            _serviceProviderGroupCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderGroupCallsCLIDPolicySpecified { get; set; }
    private bool _enablePhoneListLookup;

    [XmlElement(ElementName = "enablePhoneListLookup", IsNullable = false, Namespace = "")]
    public bool EnablePhoneListLookup {
        get => _enablePhoneListLookup;
        set {
            EnablePhoneListLookupSpecified = true;
            _enablePhoneListLookup = value;
        }
    }

    [XmlIgnore]
    public bool EnablePhoneListLookupSpecified { get; set; }
    private bool _useMaxConcurrentTerminatingAlertingRequests;

    [XmlElement(ElementName = "useMaxConcurrentTerminatingAlertingRequests", IsNullable = false, Namespace = "")]
    public bool UseMaxConcurrentTerminatingAlertingRequests {
        get => _useMaxConcurrentTerminatingAlertingRequests;
        set {
            UseMaxConcurrentTerminatingAlertingRequestsSpecified = true;
            _useMaxConcurrentTerminatingAlertingRequests = value;
        }
    }

    [XmlIgnore]
    public bool UseMaxConcurrentTerminatingAlertingRequestsSpecified { get; set; }
    private int _maxConcurrentTerminatingAlertingRequests;

    [XmlElement(ElementName = "maxConcurrentTerminatingAlertingRequests", IsNullable = false, Namespace = "")]
    public int MaxConcurrentTerminatingAlertingRequests {
        get => _maxConcurrentTerminatingAlertingRequests;
        set {
            MaxConcurrentTerminatingAlertingRequestsSpecified = true;
            _maxConcurrentTerminatingAlertingRequests = value;
        }
    }

    [XmlIgnore]
    public bool MaxConcurrentTerminatingAlertingRequestsSpecified { get; set; }
    private int _delayTimerToRemoveCancelledCallsInSeconds;

    [XmlElement(ElementName = "delayTimerToRemoveCancelledCallsInSeconds", IsNullable = false, Namespace = "")]
    public int DelayTimerToRemoveCancelledCallsInSeconds {
        get => _delayTimerToRemoveCancelledCallsInSeconds;
        set {
            DelayTimerToRemoveCancelledCallsInSecondsSpecified = true;
            _delayTimerToRemoveCancelledCallsInSeconds = value;
        }
    }

    [XmlIgnore]
    public bool DelayTimerToRemoveCancelledCallsInSecondsSpecified { get; set; }
    private bool _includeRedirectionsInMaximumNumberOfConcurrentCalls;

    [XmlElement(ElementName = "includeRedirectionsInMaximumNumberOfConcurrentCalls", IsNullable = false, Namespace = "")]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCalls {
        get => _includeRedirectionsInMaximumNumberOfConcurrentCalls;
        set {
            IncludeRedirectionsInMaximumNumberOfConcurrentCallsSpecified = true;
            _includeRedirectionsInMaximumNumberOfConcurrentCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncludeRedirectionsInMaximumNumberOfConcurrentCallsSpecified { get; set; }
    private bool _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable;

    [XmlElement(ElementName = "useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable", IsNullable = false, Namespace = "")]
    public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable {
        get => _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable;
        set {
            UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailableSpecified = true;
            _useUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool UseUserPhoneNumberForGroupCallsWhenInternalCLIDUnavailableSpecified { get; set; }
    private bool _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable;

    [XmlElement(ElementName = "useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable", IsNullable = false, Namespace = "")]
    public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable {
        get => _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable;
        set {
            UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailableSpecified = true;
            _useUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool UseUserPhoneNumberForEnterpriseCallsWhenInternalCLIDUnavailableSpecified { get; set; }
    private string _routeOverrideDomain;

    [XmlElement(ElementName = "routeOverrideDomain", IsNullable = false, Namespace = "")]
    public string RouteOverrideDomain {
        get => _routeOverrideDomain;
        set {
            RouteOverrideDomainSpecified = true;
            _routeOverrideDomain = value;
        }
    }

    [XmlIgnore]
    public bool RouteOverrideDomainSpecified { get; set; }
    private string _routeOverridePrefix;

    [XmlElement(ElementName = "routeOverridePrefix", IsNullable = false, Namespace = "")]
    public string RouteOverridePrefix {
        get => _routeOverridePrefix;
        set {
            RouteOverridePrefixSpecified = true;
            _routeOverridePrefix = value;
        }
    }

    [XmlIgnore]
    public bool RouteOverridePrefixSpecified { get; set; }
    private bool _allowMobileDNForRedirectingIdentity;

    [XmlElement(ElementName = "allowMobileDNForRedirectingIdentity", IsNullable = false, Namespace = "")]
    public bool AllowMobileDNForRedirectingIdentity {
        get => _allowMobileDNForRedirectingIdentity;
        set {
            AllowMobileDNForRedirectingIdentitySpecified = true;
            _allowMobileDNForRedirectingIdentity = value;
        }
    }

    [XmlIgnore]
    public bool AllowMobileDNForRedirectingIdentitySpecified { get; set; }
    private bool _conferenceDisableClampTones;

    [XmlElement(ElementName = "conferenceDisableClampTones", IsNullable = false, Namespace = "")]
    public bool ConferenceDisableClampTones {
        get => _conferenceDisableClampTones;
        set {
            ConferenceDisableClampTonesSpecified = true;
            _conferenceDisableClampTones = value;
        }
    }

    [XmlIgnore]
    public bool ConferenceDisableClampTonesSpecified { get; set; }
}
}
