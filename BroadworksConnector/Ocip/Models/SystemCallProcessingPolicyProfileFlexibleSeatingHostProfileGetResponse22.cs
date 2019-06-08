using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallProcessingPolicyProfileFlexibleSeatingHostProfileGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _useCLIDPolicy;

    [XmlElement(ElementName = "useCLIDPolicy", IsNullable = false, Namespace = "")]
    public bool UseCLIDPolicy {
        get => _useCLIDPolicy;
        set {
            UseCLIDPolicySpecified = true;
            _useCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseCLIDPolicySpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseCallsCLIDPolicy;

    [XmlElement(ElementName = "enterpriseCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseCallsCLIDPolicy {
        get => _enterpriseCallsCLIDPolicy;
        set {
            EnterpriseCallsCLIDPolicySpecified = true;
            _enterpriseCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseCallsCLIDPolicySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy _enterpriseGroupCallsCLIDPolicy;

    [XmlElement(ElementName = "enterpriseGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.EnterpriseInternalCallsCLIDPolicy EnterpriseGroupCallsCLIDPolicy {
        get => _enterpriseGroupCallsCLIDPolicy;
        set {
            EnterpriseGroupCallsCLIDPolicySpecified = true;
            _enterpriseGroupCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseGroupCallsCLIDPolicySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy _serviceProviderGroupCallsCLIDPolicy;

    [XmlElement(ElementName = "serviceProviderGroupCallsCLIDPolicy", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ServiceProviderInternalCallsCLIDPolicy ServiceProviderGroupCallsCLIDPolicy {
        get => _serviceProviderGroupCallsCLIDPolicy;
        set {
            ServiceProviderGroupCallsCLIDPolicySpecified = true;
            _serviceProviderGroupCallsCLIDPolicy = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderGroupCallsCLIDPolicySpecified { get; set; }
    private bool _useCallLimitsPolicy;

    [XmlElement(ElementName = "useCallLimitsPolicy", IsNullable = false, Namespace = "")]
    public bool UseCallLimitsPolicy {
        get => _useCallLimitsPolicy;
        set {
            UseCallLimitsPolicySpecified = true;
            _useCallLimitsPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseCallLimitsPolicySpecified { get; set; }
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
    private bool _useTranslationRoutingPolicy;

    [XmlElement(ElementName = "useTranslationRoutingPolicy", IsNullable = false, Namespace = "")]
    public bool UseTranslationRoutingPolicy {
        get => _useTranslationRoutingPolicy;
        set {
            UseTranslationRoutingPolicySpecified = true;
            _useTranslationRoutingPolicy = value;
        }
    }

    [XmlIgnore]
    public bool UseTranslationRoutingPolicySpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.NetworkUsageSelection _networkUsageSelection;

    [XmlElement(ElementName = "networkUsageSelection", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.NetworkUsageSelection NetworkUsageSelection {
        get => _networkUsageSelection;
        set {
            NetworkUsageSelectionSpecified = true;
            _networkUsageSelection = value;
        }
    }

    [XmlIgnore]
    public bool NetworkUsageSelectionSpecified { get; set; }
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
}
}
