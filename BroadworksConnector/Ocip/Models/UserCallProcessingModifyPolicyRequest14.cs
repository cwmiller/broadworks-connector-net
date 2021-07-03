using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user level data associated with Call Processing Policy.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// Replaced By: UserCallProcessingModifyPolicyRequest14sp7
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="UserCallProcessingModifyPolicyRequest14sp7"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:41640""}]")]
    public class UserCallProcessingModifyPolicyRequest14 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        private bool _useUserSetting;

        [XmlElement(ElementName = "useUserSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
        public bool UseUserSetting
        {
            get => _useUserSetting;
            set
            {
                UseUserSettingSpecified = true;
                _useUserSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseUserSettingSpecified { get; set; }

        private bool _useMaxSimultaneousCalls;

        [XmlElement(ElementName = "useMaxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxSimultaneousCalls;

        [XmlElement(ElementName = "maxSimultaneousCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxSimultaneousCallsSpecified { get; set; }

        private bool _useMaxSimultaneousVideoCalls;

        [XmlElement(ElementName = "useMaxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxSimultaneousVideoCalls;

        [XmlElement(ElementName = "maxSimultaneousVideoCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxSimultaneousVideoCallsSpecified { get; set; }

        private bool _useMaxCallTimeForAnsweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForAnsweredCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxCallTimeForAnsweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForAnsweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
        [MinInclusive(5)]
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

        private bool _useMaxCallTimeForUnansweredCalls;

        [XmlElement(ElementName = "useMaxCallTimeForUnansweredCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxCallTimeForUnansweredCallsMinutes;

        [XmlElement(ElementName = "maxCallTimeForUnansweredCallsMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxCallTimeForUnansweredCallsMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MediaPolicySelection _mediaPolicySelection;

        [XmlElement(ElementName = "mediaPolicySelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private string _supportedMediaSetName;

        [XmlElement(ElementName = "supportedMediaSetName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private bool _useMaxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "useMaxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxConcurrentRedirectedCalls;

        [XmlElement(ElementName = "maxConcurrentRedirectedCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxConcurrentRedirectedCallsSpecified { get; set; }

        private bool _useMaxFindMeFollowMeDepth;

        [XmlElement(ElementName = "useMaxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxFindMeFollowMeDepth;

        [XmlElement(ElementName = "maxFindMeFollowMeDepth", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxFindMeFollowMeDepthSpecified { get; set; }

        private int _maxRedirectionDepth;

        [XmlElement(ElementName = "maxRedirectionDepth", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxRedirectionDepthSpecified { get; set; }

        private bool _useMaxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "useMaxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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

        private int _maxConcurrentFindMeFollowMeInvocations;

        [XmlElement(ElementName = "maxConcurrentFindMeFollowMeInvocations", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:41640")]
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
        protected bool MaxConcurrentFindMeFollowMeInvocationsSpecified { get; set; }

    }
}
