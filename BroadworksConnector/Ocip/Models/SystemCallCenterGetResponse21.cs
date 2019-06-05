using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallCenterGetResponse21 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _defaultFromAddress;

    [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultFromAddress {
        get => _defaultFromAddress;
        set {
            DefaultFromAddressSpecified = true;
            _defaultFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultFromAddressSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes _statisticsSamplingPeriodMinutes;

    [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes {
        get => _statisticsSamplingPeriodMinutes;
        set {
            StatisticsSamplingPeriodMinutesSpecified = true;
            _statisticsSamplingPeriodMinutes = value;
        }
    }

    [XmlIgnore]
    public bool StatisticsSamplingPeriodMinutesSpecified { get; set; }
    private bool _defaultEnableGuardTimer;

    [XmlElement(ElementName = "defaultEnableGuardTimer", IsNullable = false, Namespace = "")]
    public bool DefaultEnableGuardTimer {
        get => _defaultEnableGuardTimer;
        set {
            DefaultEnableGuardTimerSpecified = true;
            _defaultEnableGuardTimer = value;
        }
    }

    [XmlIgnore]
    public bool DefaultEnableGuardTimerSpecified { get; set; }
    private int _defaultGuardTimerSeconds;

    [XmlElement(ElementName = "defaultGuardTimerSeconds", IsNullable = false, Namespace = "")]
    public int DefaultGuardTimerSeconds {
        get => _defaultGuardTimerSeconds;
        set {
            DefaultGuardTimerSecondsSpecified = true;
            _defaultGuardTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool DefaultGuardTimerSecondsSpecified { get; set; }
    private bool _forceAgentUnavailableOnDNDActivation;

    [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false, Namespace = "")]
    public bool ForceAgentUnavailableOnDNDActivation {
        get => _forceAgentUnavailableOnDNDActivation;
        set {
            ForceAgentUnavailableOnDNDActivationSpecified = true;
            _forceAgentUnavailableOnDNDActivation = value;
        }
    }

    [XmlIgnore]
    public bool ForceAgentUnavailableOnDNDActivationSpecified { get; set; }
    private bool _forceAgentUnavailableOnPersonalCalls;

    [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false, Namespace = "")]
    public bool ForceAgentUnavailableOnPersonalCalls {
        get => _forceAgentUnavailableOnPersonalCalls;
        set {
            ForceAgentUnavailableOnPersonalCallsSpecified = true;
            _forceAgentUnavailableOnPersonalCalls = value;
        }
    }

    [XmlIgnore]
    public bool ForceAgentUnavailableOnPersonalCallsSpecified { get; set; }
    private bool _forceAgentUnavailableOnBouncedCallLimit;

    [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false, Namespace = "")]
    public bool ForceAgentUnavailableOnBouncedCallLimit {
        get => _forceAgentUnavailableOnBouncedCallLimit;
        set {
            ForceAgentUnavailableOnBouncedCallLimitSpecified = true;
            _forceAgentUnavailableOnBouncedCallLimit = value;
        }
    }

    [XmlIgnore]
    public bool ForceAgentUnavailableOnBouncedCallLimitSpecified { get; set; }
    private int _numberConsecutiveBouncedCallsToForceAgentUnavailable;

    [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false, Namespace = "")]
    public int NumberConsecutiveBouncedCallsToForceAgentUnavailable {
        get => _numberConsecutiveBouncedCallsToForceAgentUnavailable;
        set {
            NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified = true;
            _numberConsecutiveBouncedCallsToForceAgentUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified { get; set; }
    private bool _forceAgentUnavailableOnNotReachable;

    [XmlElement(ElementName = "forceAgentUnavailableOnNotReachable", IsNullable = false, Namespace = "")]
    public bool ForceAgentUnavailableOnNotReachable {
        get => _forceAgentUnavailableOnNotReachable;
        set {
            ForceAgentUnavailableOnNotReachableSpecified = true;
            _forceAgentUnavailableOnNotReachable = value;
        }
    }

    [XmlIgnore]
    public bool ForceAgentUnavailableOnNotReachableSpecified { get; set; }
    private bool _defaultPlayRingWhenOfferCall;

    [XmlElement(ElementName = "defaultPlayRingWhenOfferCall", IsNullable = false, Namespace = "")]
    public bool DefaultPlayRingWhenOfferCall {
        get => _defaultPlayRingWhenOfferCall;
        set {
            DefaultPlayRingWhenOfferCallSpecified = true;
            _defaultPlayRingWhenOfferCall = value;
        }
    }

    [XmlIgnore]
    public bool DefaultPlayRingWhenOfferCallSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope _uniformCallDistributionPolicyScope;

    [XmlElement(ElementName = "uniformCallDistributionPolicyScope", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterUniformCallDistributionPolicyScope UniformCallDistributionPolicyScope {
        get => _uniformCallDistributionPolicyScope;
        set {
            UniformCallDistributionPolicyScopeSpecified = true;
            _uniformCallDistributionPolicyScope = value;
        }
    }

    [XmlIgnore]
    public bool UniformCallDistributionPolicyScopeSpecified { get; set; }
    private int _callHandlingSamplingPeriodMinutes;

    [XmlElement(ElementName = "callHandlingSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
    public int CallHandlingSamplingPeriodMinutes {
        get => _callHandlingSamplingPeriodMinutes;
        set {
            CallHandlingSamplingPeriodMinutesSpecified = true;
            _callHandlingSamplingPeriodMinutes = value;
        }
    }

    [XmlIgnore]
    public bool CallHandlingSamplingPeriodMinutesSpecified { get; set; }
    private int _callHandlingMinimumSamplingSize;

    [XmlElement(ElementName = "callHandlingMinimumSamplingSize", IsNullable = false, Namespace = "")]
    public int CallHandlingMinimumSamplingSize {
        get => _callHandlingMinimumSamplingSize;
        set {
            CallHandlingMinimumSamplingSizeSpecified = true;
            _callHandlingMinimumSamplingSize = value;
        }
    }

    [XmlIgnore]
    public bool CallHandlingMinimumSamplingSizeSpecified { get; set; }
    private bool _playToneToAgentForEmergencyCall;

    [XmlElement(ElementName = "playToneToAgentForEmergencyCall", IsNullable = false, Namespace = "")]
    public bool PlayToneToAgentForEmergencyCall {
        get => _playToneToAgentForEmergencyCall;
        set {
            PlayToneToAgentForEmergencyCallSpecified = true;
            _playToneToAgentForEmergencyCall = value;
        }
    }

    [XmlIgnore]
    public bool PlayToneToAgentForEmergencyCallSpecified { get; set; }
    private string _emergencyCallCLIDPrefix;

    [XmlElement(ElementName = "emergencyCallCLIDPrefix", IsNullable = false, Namespace = "")]
    public string EmergencyCallCLIDPrefix {
        get => _emergencyCallCLIDPrefix;
        set {
            EmergencyCallCLIDPrefixSpecified = true;
            _emergencyCallCLIDPrefix = value;
        }
    }

    [XmlIgnore]
    public bool EmergencyCallCLIDPrefixSpecified { get; set; }
    private int _thresholdCrossingNotificationEmailGuardTimerSeconds;

    [XmlElement(ElementName = "thresholdCrossingNotificationEmailGuardTimerSeconds", IsNullable = false, Namespace = "")]
    public int ThresholdCrossingNotificationEmailGuardTimerSeconds {
        get => _thresholdCrossingNotificationEmailGuardTimerSeconds;
        set {
            ThresholdCrossingNotificationEmailGuardTimerSecondsSpecified = true;
            _thresholdCrossingNotificationEmailGuardTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ThresholdCrossingNotificationEmailGuardTimerSecondsSpecified { get; set; }
    private bool _allowAgentDeviceInitiatedForward;

    [XmlElement(ElementName = "allowAgentDeviceInitiatedForward", IsNullable = false, Namespace = "")]
    public bool AllowAgentDeviceInitiatedForward {
        get => _allowAgentDeviceInitiatedForward;
        set {
            AllowAgentDeviceInitiatedForwardSpecified = true;
            _allowAgentDeviceInitiatedForward = value;
        }
    }

    [XmlIgnore]
    public bool AllowAgentDeviceInitiatedForwardSpecified { get; set; }
}
}
