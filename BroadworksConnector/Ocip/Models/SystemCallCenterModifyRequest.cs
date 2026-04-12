using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Call Center.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""4d65d3449061c568639c8cc1e2492285:6571""}]")]
    public class SystemCallCenterModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultFromAddress
        {
            get => _defaultFromAddress;
            set
            {
                DefaultFromAddressSpecified = (value != null);
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultFromAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes? _statisticsSamplingPeriodMinutes;

        [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes? StatisticsSamplingPeriodMinutes
        {
            get => _statisticsSamplingPeriodMinutes;
            set
            {
                StatisticsSamplingPeriodMinutesSpecified = (value != null);
                _statisticsSamplingPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsSamplingPeriodMinutesSpecified { get; set; }

        protected bool? _defaultEnableGuardTimer;

        [XmlElement(ElementName = "defaultEnableGuardTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? DefaultEnableGuardTimer
        {
            get => _defaultEnableGuardTimer;
            set
            {
                DefaultEnableGuardTimerSpecified = (value != null);
                _defaultEnableGuardTimer = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultEnableGuardTimerSpecified { get; set; }

        protected int? _defaultGuardTimerSeconds;

        [XmlElement(ElementName = "defaultGuardTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinInclusive(1)]
        [MaxInclusive(25)]
        public int? DefaultGuardTimerSeconds
        {
            get => _defaultGuardTimerSeconds;
            set
            {
                DefaultGuardTimerSecondsSpecified = (value != null);
                _defaultGuardTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultGuardTimerSecondsSpecified { get; set; }

        protected bool? _forceAgentUnavailableOnDNDActivation;

        [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? ForceAgentUnavailableOnDNDActivation
        {
            get => _forceAgentUnavailableOnDNDActivation;
            set
            {
                ForceAgentUnavailableOnDNDActivationSpecified = (value != null);
                _forceAgentUnavailableOnDNDActivation = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnDNDActivationSpecified { get; set; }

        protected bool? _forceAgentUnavailableOnPersonalCalls;

        [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? ForceAgentUnavailableOnPersonalCalls
        {
            get => _forceAgentUnavailableOnPersonalCalls;
            set
            {
                ForceAgentUnavailableOnPersonalCallsSpecified = (value != null);
                _forceAgentUnavailableOnPersonalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnPersonalCallsSpecified { get; set; }

        protected bool? _forceAgentUnavailableOnBouncedCallLimit;

        [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? ForceAgentUnavailableOnBouncedCallLimit
        {
            get => _forceAgentUnavailableOnBouncedCallLimit;
            set
            {
                ForceAgentUnavailableOnBouncedCallLimitSpecified = (value != null);
                _forceAgentUnavailableOnBouncedCallLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnBouncedCallLimitSpecified { get; set; }

        protected int? _numberConsecutiveBouncedCallsToForceAgentUnavailable;

        [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int? NumberConsecutiveBouncedCallsToForceAgentUnavailable
        {
            get => _numberConsecutiveBouncedCallsToForceAgentUnavailable;
            set
            {
                NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified = (value != null);
                _numberConsecutiveBouncedCallsToForceAgentUnavailable = value;
            }
        }

        [XmlIgnore]
        protected bool NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified { get; set; }

        protected bool? _forceAgentUnavailableOnNotReachable;

        [XmlElement(ElementName = "forceAgentUnavailableOnNotReachable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? ForceAgentUnavailableOnNotReachable
        {
            get => _forceAgentUnavailableOnNotReachable;
            set
            {
                ForceAgentUnavailableOnNotReachableSpecified = (value != null);
                _forceAgentUnavailableOnNotReachable = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnNotReachableSpecified { get; set; }

        protected bool? _defaultPlayRingWhenOfferCall;

        [XmlElement(ElementName = "defaultPlayRingWhenOfferCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? DefaultPlayRingWhenOfferCall
        {
            get => _defaultPlayRingWhenOfferCall;
            set
            {
                DefaultPlayRingWhenOfferCallSpecified = (value != null);
                _defaultPlayRingWhenOfferCall = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultPlayRingWhenOfferCallSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope? _uniformCallDistributionPolicyScope;

        [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public BroadWorksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope? UniformCallDistributionPolicyScope
        {
            get => _uniformCallDistributionPolicyScope;
            set
            {
                UniformCallDistributionPolicyScopeSpecified = (value != null);
                _uniformCallDistributionPolicyScope = value;
            }
        }

        [XmlIgnore]
        protected bool UniformCallDistributionPolicyScopeSpecified { get; set; }

        protected int? _callHandlingSamplingPeriodMinutes;

        [XmlElement(ElementName = "callHandlingSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinInclusive(5)]
        [MaxInclusive(30)]
        public int? CallHandlingSamplingPeriodMinutes
        {
            get => _callHandlingSamplingPeriodMinutes;
            set
            {
                CallHandlingSamplingPeriodMinutesSpecified = (value != null);
                _callHandlingSamplingPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool CallHandlingSamplingPeriodMinutesSpecified { get; set; }

        protected int? _callHandlingMinimumSamplingSize;

        [XmlElement(ElementName = "callHandlingMinimumSamplingSize", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinInclusive(1)]
        [MaxInclusive(100)]
        public int? CallHandlingMinimumSamplingSize
        {
            get => _callHandlingMinimumSamplingSize;
            set
            {
                CallHandlingMinimumSamplingSizeSpecified = (value != null);
                _callHandlingMinimumSamplingSize = value;
            }
        }

        [XmlIgnore]
        protected bool CallHandlingMinimumSamplingSizeSpecified { get; set; }

        protected bool? _playToneToAgentForEmergencyCall;

        [XmlElement(ElementName = "playToneToAgentForEmergencyCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? PlayToneToAgentForEmergencyCall
        {
            get => _playToneToAgentForEmergencyCall;
            set
            {
                PlayToneToAgentForEmergencyCallSpecified = (value != null);
                _playToneToAgentForEmergencyCall = value;
            }
        }

        [XmlIgnore]
        protected bool PlayToneToAgentForEmergencyCallSpecified { get; set; }

        protected string _emergencyCallCLIDPrefix;

        [XmlElement(ElementName = "emergencyCallCLIDPrefix", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinLength(1)]
        [MaxLength(10)]
        public string EmergencyCallCLIDPrefix
        {
            get => _emergencyCallCLIDPrefix;
            set
            {
                EmergencyCallCLIDPrefixSpecified = (value != null);
                _emergencyCallCLIDPrefix = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencyCallCLIDPrefixSpecified { get; set; }

        protected int? _thresholdCrossingNotificationEmailGuardTimerSeconds;

        [XmlElement(ElementName = "thresholdCrossingNotificationEmailGuardTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        [MinInclusive(3)]
        [MaxInclusive(60)]
        public int? ThresholdCrossingNotificationEmailGuardTimerSeconds
        {
            get => _thresholdCrossingNotificationEmailGuardTimerSeconds;
            set
            {
                ThresholdCrossingNotificationEmailGuardTimerSecondsSpecified = (value != null);
                _thresholdCrossingNotificationEmailGuardTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ThresholdCrossingNotificationEmailGuardTimerSecondsSpecified { get; set; }

        protected bool? _allowAgentDeviceInitiatedForward;

        [XmlElement(ElementName = "allowAgentDeviceInitiatedForward", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"4d65d3449061c568639c8cc1e2492285:6571")]
        public bool? AllowAgentDeviceInitiatedForward
        {
            get => _allowAgentDeviceInitiatedForward;
            set
            {
                AllowAgentDeviceInitiatedForwardSpecified = (value != null);
                _allowAgentDeviceInitiatedForward = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAgentDeviceInitiatedForwardSpecified { get; set; }

    }
}
