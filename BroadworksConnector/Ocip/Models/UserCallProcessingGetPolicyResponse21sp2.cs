using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallProcessingGetPolicyResponse21sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useUserCLIDSetting;

    [XmlElement(ElementName = "useUserCLIDSetting", IsNullable = false, Namespace = "")]
    public bool UseUserCLIDSetting {
        get => _useUserCLIDSetting;
        set {
            UseUserCLIDSettingSpecified = true;
            _useUserCLIDSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserCLIDSettingSpecified { get; set; }
    private bool _useUserMediaSetting;

    [XmlElement(ElementName = "useUserMediaSetting", IsNullable = false, Namespace = "")]
    public bool UseUserMediaSetting {
        get => _useUserMediaSetting;
        set {
            UseUserMediaSettingSpecified = true;
            _useUserMediaSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserMediaSettingSpecified { get; set; }
    private bool _useUserCallLimitsSetting;

    [XmlElement(ElementName = "useUserCallLimitsSetting", IsNullable = false, Namespace = "")]
    public bool UseUserCallLimitsSetting {
        get => _useUserCallLimitsSetting;
        set {
            UseUserCallLimitsSettingSpecified = true;
            _useUserCallLimitsSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserCallLimitsSettingSpecified { get; set; }
    private bool _useUserDCLIDSetting;

    [XmlElement(ElementName = "useUserDCLIDSetting", IsNullable = false, Namespace = "")]
    public bool UseUserDCLIDSetting {
        get => _useUserDCLIDSetting;
        set {
            UseUserDCLIDSettingSpecified = true;
            _useUserDCLIDSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserDCLIDSettingSpecified { get; set; }
    private bool _useUserTranslationRoutingSetting;

    [XmlElement(ElementName = "useUserTranslationRoutingSetting", IsNullable = false, Namespace = "")]
    public bool UseUserTranslationRoutingSetting {
        get => _useUserTranslationRoutingSetting;
        set {
            UseUserTranslationRoutingSettingSpecified = true;
            _useUserTranslationRoutingSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserTranslationRoutingSettingSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

    [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection {
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
    private BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _clidPolicy;

    [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupCLIDPolicy ClidPolicy {
        get => _clidPolicy;
        set {
            ClidPolicySpecified = true;
            _clidPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ClidPolicySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _emergencyClidPolicy;

    [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupCLIDPolicy EmergencyClidPolicy {
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
    private bool _useGroupName;

    [XmlElement(ElementName = "useGroupName", IsNullable = false, Namespace = "")]
    public bool UseGroupName {
        get => _useGroupName;
        set {
            UseGroupNameSpecified = true;
            _useGroupName = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupNameSpecified { get; set; }
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
    private bool _allowDepartmentCLIDNameOverride;

    [XmlElement(ElementName = "allowDepartmentCLIDNameOverride", IsNullable = false, Namespace = "")]
    public bool AllowDepartmentCLIDNameOverride {
        get => _allowDepartmentCLIDNameOverride;
        set {
            AllowDepartmentCLIDNameOverrideSpecified = true;
            _allowDepartmentCLIDNameOverride = value;
        }
    }

    [XmlIgnore]
    public bool AllowDepartmentCLIDNameOverrideSpecified { get; set; }
    private bool _useUserPhoneListLookupSetting;

    [XmlElement(ElementName = "useUserPhoneListLookupSetting", IsNullable = false, Namespace = "")]
    public bool UseUserPhoneListLookupSetting {
        get => _useUserPhoneListLookupSetting;
        set {
            UseUserPhoneListLookupSettingSpecified = true;
            _useUserPhoneListLookupSetting = value;
        }
    }

    [XmlIgnore]
    public bool UseUserPhoneListLookupSettingSpecified { get; set; }
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
}
}
