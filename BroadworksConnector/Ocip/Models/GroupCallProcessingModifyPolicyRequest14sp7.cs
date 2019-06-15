using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the group level data associated with Call Processing Policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The useGroupCLIDSetting attribute controls the CLID settings
    /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
    /// The useGroupMediaSetting attribute controls the Media settings
    /// (medisPolicySelection, supportedMediaSetName)
    /// The useGroupCallLimitsSetting attribute controls the Call Limits settings
    /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls,
    /// useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
    /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
    /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
    /// The useGroupTranslationRoutingSetting attribute controls the routing and
    /// translation settings (networkUsageSelection, enforceGroupCallingLineIdentityRestriction,
    /// allowEnterpriseGroupCallTypingForPrivateDialingPlan, allowEnterpriseGroupCallTypingForPublicDialingPlan,
    /// overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan, enableEnterpriseExtensionDialing)
    /// Replaced By: GroupCallProcessingModifyPolicyRequest15sp2
        /// <see cref="SuccessResponse"/>
        /// <see cref="ErrorResponse"/>
        /// <see cref="GroupCallProcessingModifyPolicyRequest15sp2"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class GroupCallProcessingModifyPolicyRequest14sp7 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        
        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        public string ServiceProviderId {
            get => _serviceProviderId;
            set {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        public bool ServiceProviderIdSpecified { get; set; }
        
        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        public string GroupId {
            get => _groupId;
            set {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        public bool GroupIdSpecified { get; set; }
        
        private bool _useGroupCLIDSetting;

        [XmlElement(ElementName = "useGroupCLIDSetting", IsNullable = false, Namespace = "")]
        public bool UseGroupCLIDSetting {
            get => _useGroupCLIDSetting;
            set {
                UseGroupCLIDSettingSpecified = true;
                _useGroupCLIDSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupCLIDSettingSpecified { get; set; }
        
        private bool _useGroupMediaSetting;

        [XmlElement(ElementName = "useGroupMediaSetting", IsNullable = false, Namespace = "")]
        public bool UseGroupMediaSetting {
            get => _useGroupMediaSetting;
            set {
                UseGroupMediaSettingSpecified = true;
                _useGroupMediaSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupMediaSettingSpecified { get; set; }
        
        private bool _useGroupCallLimitsSetting;

        [XmlElement(ElementName = "useGroupCallLimitsSetting", IsNullable = false, Namespace = "")]
        public bool UseGroupCallLimitsSetting {
            get => _useGroupCallLimitsSetting;
            set {
                UseGroupCallLimitsSettingSpecified = true;
                _useGroupCallLimitsSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupCallLimitsSettingSpecified { get; set; }
        
        private bool _useGroupTranslationRoutingSetting;

        [XmlElement(ElementName = "useGroupTranslationRoutingSetting", IsNullable = false, Namespace = "")]
        public bool UseGroupTranslationRoutingSetting {
            get => _useGroupTranslationRoutingSetting;
            set {
                UseGroupTranslationRoutingSettingSpecified = true;
                _useGroupTranslationRoutingSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseGroupTranslationRoutingSettingSpecified { get; set; }
        
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

        [XmlElement(ElementName = "supportedMediaSetName", IsNullable = true, Namespace = "")]
        public string SupportedMediaSetName {
            get => _supportedMediaSetName;
            set {
                SupportedMediaSetNameSpecified = true;
                _supportedMediaSetName = value;
            }
        }

        [XmlIgnore]
        public bool SupportedMediaSetNameSpecified { get; set; }
        
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
        
        private bool _overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan;

        [XmlElement(ElementName = "overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan", IsNullable = false, Namespace = "")]
        public bool OverrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan {
            get => _overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan;
            set {
                OverrideCLIDRestrictionForExternalCallsViaPrivateDialingPlanSpecified = true;
                _overrideCLIDRestrictionForExternalCallsViaPrivateDialingPlan = value;
            }
        }

        [XmlIgnore]
        public bool OverrideCLIDRestrictionForExternalCallsViaPrivateDialingPlanSpecified { get; set; }
        
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
        
    }
}
