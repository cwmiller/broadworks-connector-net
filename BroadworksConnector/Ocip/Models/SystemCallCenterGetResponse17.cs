using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterGetRequest17.
    /// 
    /// Replaced by SystemCallCenterGetResponse17sp4.
    /// <see cref="SystemCallCenterGetRequest17"/>
    /// <see cref="SystemCallCenterGetResponse17sp4"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21654""}]")]
    public class SystemCallCenterGetResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultFromAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes _statisticsSamplingPeriodMinutes;

        [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes
        {
            get => _statisticsSamplingPeriodMinutes;
            set
            {
                StatisticsSamplingPeriodMinutesSpecified = true;
                _statisticsSamplingPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsSamplingPeriodMinutesSpecified { get; set; }

        protected bool _defaultEnableGuardTimer;

        [XmlElement(ElementName = "defaultEnableGuardTimer", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public bool DefaultEnableGuardTimer
        {
            get => _defaultEnableGuardTimer;
            set
            {
                DefaultEnableGuardTimerSpecified = true;
                _defaultEnableGuardTimer = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultEnableGuardTimerSpecified { get; set; }

        protected int _defaultGuardTimerSeconds;

        [XmlElement(ElementName = "defaultGuardTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        [MinInclusive(1)]
        [MaxInclusive(25)]
        public int DefaultGuardTimerSeconds
        {
            get => _defaultGuardTimerSeconds;
            set
            {
                DefaultGuardTimerSecondsSpecified = true;
                _defaultGuardTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultGuardTimerSecondsSpecified { get; set; }

        protected bool _forceAgentUnavailableOnDNDActivation;

        [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public bool ForceAgentUnavailableOnDNDActivation
        {
            get => _forceAgentUnavailableOnDNDActivation;
            set
            {
                ForceAgentUnavailableOnDNDActivationSpecified = true;
                _forceAgentUnavailableOnDNDActivation = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnDNDActivationSpecified { get; set; }

        protected bool _forceAgentUnavailableOnPersonalCalls;

        [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public bool ForceAgentUnavailableOnPersonalCalls
        {
            get => _forceAgentUnavailableOnPersonalCalls;
            set
            {
                ForceAgentUnavailableOnPersonalCallsSpecified = true;
                _forceAgentUnavailableOnPersonalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnPersonalCallsSpecified { get; set; }

        protected bool _forceAgentUnavailableOnBouncedCallLimit;

        [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public bool ForceAgentUnavailableOnBouncedCallLimit
        {
            get => _forceAgentUnavailableOnBouncedCallLimit;
            set
            {
                ForceAgentUnavailableOnBouncedCallLimitSpecified = true;
                _forceAgentUnavailableOnBouncedCallLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnBouncedCallLimitSpecified { get; set; }

        protected int _numberConsecutiveBouncedCallsToForceAgentUnavailable;

        [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int NumberConsecutiveBouncedCallsToForceAgentUnavailable
        {
            get => _numberConsecutiveBouncedCallsToForceAgentUnavailable;
            set
            {
                NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified = true;
                _numberConsecutiveBouncedCallsToForceAgentUnavailable = value;
            }
        }

        [XmlIgnore]
        protected bool NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified { get; set; }

        protected bool _defaultPlayRingWhenOfferCall;

        [XmlElement(ElementName = "defaultPlayRingWhenOfferCall", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public bool DefaultPlayRingWhenOfferCall
        {
            get => _defaultPlayRingWhenOfferCall;
            set
            {
                DefaultPlayRingWhenOfferCallSpecified = true;
                _defaultPlayRingWhenOfferCall = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultPlayRingWhenOfferCallSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope _uniformCallDistributionPolicyScope;

        [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public BroadWorksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope
        {
            get => _uniformCallDistributionPolicyScope;
            set
            {
                UniformCallDistributionPolicyScopeSpecified = true;
                _uniformCallDistributionPolicyScope = value;
            }
        }

        [XmlIgnore]
        protected bool UniformCallDistributionPolicyScopeSpecified { get; set; }

        protected int _callHandlingSamplingPeriodMinutes;

        [XmlElement(ElementName = "callHandlingSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        [MinInclusive(5)]
        [MaxInclusive(30)]
        public int CallHandlingSamplingPeriodMinutes
        {
            get => _callHandlingSamplingPeriodMinutes;
            set
            {
                CallHandlingSamplingPeriodMinutesSpecified = true;
                _callHandlingSamplingPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool CallHandlingSamplingPeriodMinutesSpecified { get; set; }

        protected int _callHandlingMinimumSamplingSize;

        [XmlElement(ElementName = "callHandlingMinimumSamplingSize", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int CallHandlingMinimumSamplingSize
        {
            get => _callHandlingMinimumSamplingSize;
            set
            {
                CallHandlingMinimumSamplingSizeSpecified = true;
                _callHandlingMinimumSamplingSize = value;
            }
        }

        [XmlIgnore]
        protected bool CallHandlingMinimumSamplingSizeSpecified { get; set; }

        protected bool _playToneToAgentForEmergencyCall;

        [XmlElement(ElementName = "playToneToAgentForEmergencyCall", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        public bool PlayToneToAgentForEmergencyCall
        {
            get => _playToneToAgentForEmergencyCall;
            set
            {
                PlayToneToAgentForEmergencyCallSpecified = true;
                _playToneToAgentForEmergencyCall = value;
            }
        }

        [XmlIgnore]
        protected bool PlayToneToAgentForEmergencyCallSpecified { get; set; }

        protected string _emergencyCallCLIDPrefix;

        [XmlElement(ElementName = "emergencyCallCLIDPrefix", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21654")]
        [MinLength(1)]
        [MaxLength(10)]
        public string EmergencyCallCLIDPrefix
        {
            get => _emergencyCallCLIDPrefix;
            set
            {
                EmergencyCallCLIDPrefixSpecified = true;
                _emergencyCallCLIDPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyCallCLIDPrefixSpecified { get; set; }

    }
}
