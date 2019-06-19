using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to UserCallProcessingGetPolicyRequest17.
    /// The useUserCLIDSetting attribute controls the CLID settings
    /// (clidPolicy, emergencyClidPolicy, allowAlternateNumbersForRedirectingIdentity, useGroupName)
    /// 
    /// The useUserMediaSetting attribute controls the Media settings
    /// (medisPolicySelection, supportedMediaSetName)
    /// 
    /// The useUserCallLimitsSetting attribute controls the Call Limits setting
    /// (useMaxSimultaneousCalls, maxSimultaneousCalls, useMaxSimultaneousVideoCalls, maxSimultaneousVideoCalls,
    /// useMaxCallTimeForAnsweredCalls, maxCallTimeForAnsweredCallsMinutes, useMaxCallTimeForUnansweredCalls,
    /// maxCallTimeForUnansweredCallsMinutes, useMaxConcurrentRedirectedCalls, useMaxFindMeFollowMeDepth,
    /// maxRedirectionDepth, useMaxConcurrentFindMeFollowMeInvocations, maxConcurrentFindMeFollowMeInvocations)
    /// <see cref="UserCallProcessingGetPolicyRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:23182""}]")]
    public class UserCallProcessingGetPolicyResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useUserCLIDSetting;

        [XmlElement(ElementName = "useUserCLIDSetting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseUserCLIDSettingSpecified { get; set; }

        private bool _useUserMediaSetting;

        [XmlElement(ElementName = "useUserMediaSetting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseUserMediaSettingSpecified { get; set; }

        private bool _useUserCallLimitsSetting;

        [XmlElement(ElementName = "useUserCallLimitsSetting", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseUserCallLimitsSettingSpecified { get; set; }

        private bool _useMaxSimultaneousCalls;

        [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxSimultaneousCallsSpecified { get; set; }

        private int _maxSimultaneousCalls;

        [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(500)]
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
        public bool MaxSimultaneousCallsSpecified { get; set; }

        private bool _useMaxSimultaneousVideoCalls;

        [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxSimultaneousVideoCallsSpecified { get; set; }

        private int _maxSimultaneousVideoCalls;

        [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(500)]
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
        public bool MaxSimultaneousVideoCallsSpecified { get; set; }

        private bool _useMaxCallTimeForAnsweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxCallTimeForAnsweredCallsSpecified { get; set; }

        private int _maxCallTimeForAnsweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool MaxCallTimeForAnsweredCallsMinutesSpecified { get; set; }

        private bool _useMaxCallTimeForUnansweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxCallTimeForUnansweredCallsSpecified { get; set; }

        private int _maxCallTimeForUnansweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
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
        public bool MaxCallTimeForUnansweredCallsMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

        [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool MediaPolicySelectionSpecified { get; set; }

        private string _supportedMediaSetName;

        [XmlElement(ElementName = "supportedMediaSetName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool SupportedMediaSetNameSpecified { get; set; }

        private bool _useMaxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxConcurrentRedirectedCallsSpecified { get; set; }

        private int _maxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(32)]
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
        public bool MaxConcurrentRedirectedCallsSpecified { get; set; }

        private bool _useMaxFindMeFollowMeDepth;

        [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxFindMeFollowMeDepthSpecified { get; set; }

        private int _maxFindMeFollowMeDepth;

        [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
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
        public bool MaxFindMeFollowMeDepthSpecified { get; set; }

        private int _maxRedirectionDepth;

        [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(15)]
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
        public bool MaxRedirectionDepthSpecified { get; set; }

        private bool _useMaxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseMaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

        private int _maxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
        [MinInclusive(1)]
        [MaxInclusive(32)]
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
        public bool MaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _clidPolicy;

        [XmlElement(ElementName = "clidPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool ClidPolicySpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.GroupCLIDPolicy _emergencyClidPolicy;

        [XmlElement(ElementName = "emergencyClidPolicy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool EmergencyClidPolicySpecified { get; set; }

        private bool _allowAlternateNumbersForRedirectingIdentity;

        [XmlElement(ElementName = "allowAlternateNumbersForRedirectingIdentity", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool AllowAlternateNumbersForRedirectingIdentitySpecified { get; set; }

        private bool _useGroupName;

        [XmlElement(ElementName = "useGroupName", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool UseGroupNameSpecified { get; set; }

        private bool _blockCallingNameForExternalCalls;

        [XmlElement(ElementName = "blockCallingNameForExternalCalls", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:23182")]
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
        public bool BlockCallingNameForExternalCallsSpecified { get; set; }

    }
}
