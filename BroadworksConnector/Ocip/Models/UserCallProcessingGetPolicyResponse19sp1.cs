using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallProcessingGetPolicyRequest19sp1.
    /// The useUserCLIDSetting attribute controls the CLID settings
    /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName, allowConfigurableCLIDForRedirectingIdentity, allowDepartmentCLIDNameOverride)
    /// 
    /// The useUserMediaSetting attribute controls the Media settings
    /// (medisPolicySelection, supportedMediaSetName)
    /// 
    /// The useUserCallLimitsSetting attribute controls the Call Limits setting
    /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls, useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls, maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth, maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
    /// The following elements are only used in AS data mode :
    /// useUserDCLIDSetting
    /// enableDialableCallerID
    /// allowConfigurableCLIDForRedirectingIdentity
    /// allowDepartmentCLIDNameOverride
    /// 
    /// Replaced by: UserCallProcessingGetPolicyResponse21sp1
    /// <see cref="UserCallProcessingGetPolicyRequest19sp1"/>
    /// <see cref="UserCallProcessingGetPolicyResponse21sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:42237""}]")]
    public class UserCallProcessingGetPolicyResponse19sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _useUserCLIDSetting;

        [XmlElement(ElementName = "useUserCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseUserCLIDSetting
        {
            get => _useUserCLIDSetting;
            set
            {
                UseUserCLIDSettingSpecified = true;
                _useUserCLIDSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseUserCLIDSettingSpecified { get; set; }

        protected bool _useUserMediaSetting;

        [XmlElement(ElementName = "useUserMediaSetting", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseUserMediaSetting
        {
            get => _useUserMediaSetting;
            set
            {
                UseUserMediaSettingSpecified = true;
                _useUserMediaSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseUserMediaSettingSpecified { get; set; }

        protected bool _useUserCallLimitsSetting;

        [XmlElement(ElementName = "useUserCallLimitsSetting", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseUserCallLimitsSetting
        {
            get => _useUserCallLimitsSetting;
            set
            {
                UseUserCallLimitsSettingSpecified = true;
                _useUserCallLimitsSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseUserCallLimitsSettingSpecified { get; set; }

        protected bool _useUserDCLIDSetting;

        [XmlElement(ElementName = "useUserDCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseUserDCLIDSetting
        {
            get => _useUserDCLIDSetting;
            set
            {
                UseUserDCLIDSettingSpecified = true;
                _useUserDCLIDSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseUserDCLIDSettingSpecified { get; set; }

        protected bool _useMaxSimultaneousCalls;

        [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxSimultaneousCalls
        {
            get => _useMaxSimultaneousCalls;
            set
            {
                UseMaxSimultaneousCallsSpecified = true;
                _useMaxSimultaneousCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxSimultaneousCallsSpecified { get; set; }

        protected int _maxSimultaneousCalls;

        [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxSimultaneousCalls
        {
            get => _maxSimultaneousCalls;
            set
            {
                MaxSimultaneousCallsSpecified = true;
                _maxSimultaneousCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxSimultaneousCallsSpecified { get; set; }

        protected bool _useMaxSimultaneousVideoCalls;

        [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxSimultaneousVideoCalls
        {
            get => _useMaxSimultaneousVideoCalls;
            set
            {
                UseMaxSimultaneousVideoCallsSpecified = true;
                _useMaxSimultaneousVideoCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxSimultaneousVideoCallsSpecified { get; set; }

        protected int _maxSimultaneousVideoCalls;

        [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxSimultaneousVideoCalls
        {
            get => _maxSimultaneousVideoCalls;
            set
            {
                MaxSimultaneousVideoCallsSpecified = true;
                _maxSimultaneousVideoCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxSimultaneousVideoCallsSpecified { get; set; }

        protected bool _useMaxCallTimeForAnsweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxCallTimeForAnsweredCalls
        {
            get => _useMaxCallTimeForAnsweredCalls;
            set
            {
                UseMaxCallTimeForAnsweredCallsSpecified = true;
                _useMaxCallTimeForAnsweredCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxCallTimeForAnsweredCallsSpecified { get; set; }

        protected int _maxCallTimeForAnsweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(3)]
        [MaxInclusive(2880)]
        public int MaxCallTimeForAnsweredCallsMinutes
        {
            get => _maxCallTimeForAnsweredCallsMinutes;
            set
            {
                MaxCallTimeForAnsweredCallsMinutesSpecified = true;
                _maxCallTimeForAnsweredCallsMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCallTimeForAnsweredCallsMinutesSpecified { get; set; }

        protected bool _useMaxCallTimeForUnansweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxCallTimeForUnansweredCalls
        {
            get => _useMaxCallTimeForUnansweredCalls;
            set
            {
                UseMaxCallTimeForUnansweredCallsSpecified = true;
                _useMaxCallTimeForUnansweredCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxCallTimeForUnansweredCallsSpecified { get; set; }

        protected int _maxCallTimeForUnansweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(2880)]
        public int MaxCallTimeForUnansweredCallsMinutes
        {
            get => _maxCallTimeForUnansweredCallsMinutes;
            set
            {
                MaxCallTimeForUnansweredCallsMinutesSpecified = true;
                _maxCallTimeForUnansweredCallsMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxCallTimeForUnansweredCallsMinutesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

        [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public BroadWorksConnector.Ocip.Models.MediaPolicySelection MediaPolicySelection
        {
            get => _mediaPolicySelection;
            set
            {
                MediaPolicySelectionSpecified = true;
                _mediaPolicySelection = value;
            }
        }

        [XmlIgnore]
        protected bool MediaPolicySelectionSpecified { get; set; }

        protected string _supportedMediaSetName;

        [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SupportedMediaSetName
        {
            get => _supportedMediaSetName;
            set
            {
                SupportedMediaSetNameSpecified = true;
                _supportedMediaSetName = value;
            }
        }

        [XmlIgnore]
        protected bool SupportedMediaSetNameSpecified { get; set; }

        protected bool _useMaxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxConcurrentRedirectedCalls
        {
            get => _useMaxConcurrentRedirectedCalls;
            set
            {
                UseMaxConcurrentRedirectedCallsSpecified = true;
                _useMaxConcurrentRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxConcurrentRedirectedCallsSpecified { get; set; }

        protected int _maxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxConcurrentRedirectedCalls
        {
            get => _maxConcurrentRedirectedCalls;
            set
            {
                MaxConcurrentRedirectedCallsSpecified = true;
                _maxConcurrentRedirectedCalls = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConcurrentRedirectedCallsSpecified { get; set; }

        protected bool _useMaxFindMeFollowMeDepth;

        [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxFindMeFollowMeDepth
        {
            get => _useMaxFindMeFollowMeDepth;
            set
            {
                UseMaxFindMeFollowMeDepthSpecified = true;
                _useMaxFindMeFollowMeDepth = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxFindMeFollowMeDepthSpecified { get; set; }

        protected int _maxFindMeFollowMeDepth;

        [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaxFindMeFollowMeDepth
        {
            get => _maxFindMeFollowMeDepth;
            set
            {
                MaxFindMeFollowMeDepthSpecified = true;
                _maxFindMeFollowMeDepth = value;
            }
        }

        [XmlIgnore]
        protected bool MaxFindMeFollowMeDepthSpecified { get; set; }

        protected int _maxRedirectionDepth;

        [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int MaxRedirectionDepth
        {
            get => _maxRedirectionDepth;
            set
            {
                MaxRedirectionDepthSpecified = true;
                _maxRedirectionDepth = value;
            }
        }

        [XmlIgnore]
        protected bool MaxRedirectionDepthSpecified { get; set; }

        protected bool _useMaxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseMaxConcurrentFindMeFollowMeInvocations
        {
            get => _useMaxConcurrentFindMeFollowMeInvocations;
            set
            {
                UseMaxConcurrentFindMeFollowMeInvocationsSpecified = true;
                _useMaxConcurrentFindMeFollowMeInvocations = value;
            }
        }

        [XmlIgnore]
        protected bool UseMaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

        protected int _maxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        [MinInclusive(1)]
        [MaxInclusive(999999)]
        public int MaxConcurrentFindMeFollowMeInvocations
        {
            get => _maxConcurrentFindMeFollowMeInvocations;
            set
            {
                MaxConcurrentFindMeFollowMeInvocationsSpecified = true;
                _maxConcurrentFindMeFollowMeInvocations = value;
            }
        }

        [XmlIgnore]
        protected bool MaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _clidPolicy;

        [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public BroadWorksConnector.Ocip.Models.GroupCLIDPolicy ClidPolicy
        {
            get => _clidPolicy;
            set
            {
                ClidPolicySpecified = true;
                _clidPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool ClidPolicySpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _emergencyClidPolicy;

        [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public BroadWorksConnector.Ocip.Models.GroupCLIDPolicy EmergencyClidPolicy
        {
            get => _emergencyClidPolicy;
            set
            {
                EmergencyClidPolicySpecified = true;
                _emergencyClidPolicy = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyClidPolicySpecified { get; set; }

        protected bool _allowAlternateNumbersForRedirectingIdentity;

        [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool AllowAlternateNumbersForRedirectingIdentity
        {
            get => _allowAlternateNumbersForRedirectingIdentity;
            set
            {
                AllowAlternateNumbersForRedirectingIdentitySpecified = true;
                _allowAlternateNumbersForRedirectingIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAlternateNumbersForRedirectingIdentitySpecified { get; set; }

        protected bool _useGroupName;

        [XmlElement(ElementName = "useGroupName", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool UseGroupName
        {
            get => _useGroupName;
            set
            {
                UseGroupNameSpecified = true;
                _useGroupName = value;
            }
        }

        [XmlIgnore]
        protected bool UseGroupNameSpecified { get; set; }

        protected bool _blockCallingNameForExternalCalls;

        [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool BlockCallingNameForExternalCalls
        {
            get => _blockCallingNameForExternalCalls;
            set
            {
                BlockCallingNameForExternalCallsSpecified = true;
                _blockCallingNameForExternalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool BlockCallingNameForExternalCallsSpecified { get; set; }

        protected bool _enableDialableCallerID;

        [XmlElement(ElementName = "enableDialableCallerID", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool EnableDialableCallerID
        {
            get => _enableDialableCallerID;
            set
            {
                EnableDialableCallerIDSpecified = true;
                _enableDialableCallerID = value;
            }
        }

        [XmlIgnore]
        protected bool EnableDialableCallerIDSpecified { get; set; }

        protected bool _allowConfigurableCLIDForRedirectingIdentity;

        [XmlElement(ElementName = "allowConfigurableCLIDForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool AllowConfigurableCLIDForRedirectingIdentity
        {
            get => _allowConfigurableCLIDForRedirectingIdentity;
            set
            {
                AllowConfigurableCLIDForRedirectingIdentitySpecified = true;
                _allowConfigurableCLIDForRedirectingIdentity = value;
            }
        }

        [XmlIgnore]
        protected bool AllowConfigurableCLIDForRedirectingIdentitySpecified { get; set; }

        protected bool _allowDepartmentCLIDNameOverride;

        [XmlElement(ElementName = "allowDepartmentCLIDNameOverride", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:42237")]
        public bool AllowDepartmentCLIDNameOverride
        {
            get => _allowDepartmentCLIDNameOverride;
            set
            {
                AllowDepartmentCLIDNameOverrideSpecified = true;
                _allowDepartmentCLIDNameOverride = value;
            }
        }

        [XmlIgnore]
        protected bool AllowDepartmentCLIDNameOverrideSpecified { get; set; }

    }
}
