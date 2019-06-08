using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterModifyRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.AgentACDState _agentACDState;

    [XmlElement(ElementName = "agentACDState", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AgentACDState AgentACDState {
        get => _agentACDState;
        set {
            AgentACDStateSpecified = true;
            _agentACDState = value;
        }
    }

    [XmlIgnore]
    public bool AgentACDStateSpecified { get; set; }
    private string _agentThresholdProfileName;

    [XmlElement(ElementName = "agentThresholdProfileName", IsNullable = false, Namespace = "")]
    public string AgentThresholdProfileName {
        get => _agentThresholdProfileName;
        set {
            AgentThresholdProfileNameSpecified = true;
            _agentThresholdProfileName = value;
        }
    }

    [XmlIgnore]
    public bool AgentThresholdProfileNameSpecified { get; set; }
    private string _agentUnavailableCode;

    [XmlElement(ElementName = "agentUnavailableCode", IsNullable = true, Namespace = "")]
    public string AgentUnavailableCode {
        get => _agentUnavailableCode;
        set {
            AgentUnavailableCodeSpecified = true;
            _agentUnavailableCode = value;
        }
    }

    [XmlIgnore]
    public bool AgentUnavailableCodeSpecified { get; set; }
    private bool _useDefaultGuardTimer;

    [XmlElement(ElementName = "useDefaultGuardTimer", IsNullable = false, Namespace = "")]
    public bool UseDefaultGuardTimer {
        get => _useDefaultGuardTimer;
        set {
            UseDefaultGuardTimerSpecified = true;
            _useDefaultGuardTimer = value;
        }
    }

    [XmlIgnore]
    public bool UseDefaultGuardTimerSpecified { get; set; }
    private bool _enableGuardTimer;

    [XmlElement(ElementName = "enableGuardTimer", IsNullable = false, Namespace = "")]
    public bool EnableGuardTimer {
        get => _enableGuardTimer;
        set {
            EnableGuardTimerSpecified = true;
            _enableGuardTimer = value;
        }
    }

    [XmlIgnore]
    public bool EnableGuardTimerSpecified { get; set; }
    private int _guardTimerSeconds;

    [XmlElement(ElementName = "guardTimerSeconds", IsNullable = false, Namespace = "")]
    public int GuardTimerSeconds {
        get => _guardTimerSeconds;
        set {
            GuardTimerSecondsSpecified = true;
            _guardTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool GuardTimerSecondsSpecified { get; set; }
    private bool _useSystemDefaultUnavailableSettings;

    [XmlElement(ElementName = "useSystemDefaultUnavailableSettings", IsNullable = false, Namespace = "")]
    public bool UseSystemDefaultUnavailableSettings {
        get => _useSystemDefaultUnavailableSettings;
        set {
            UseSystemDefaultUnavailableSettingsSpecified = true;
            _useSystemDefaultUnavailableSettings = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemDefaultUnavailableSettingsSpecified { get; set; }
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
    private bool _makeOutgoingCallsAsCallCenter;

    [XmlElement(ElementName = "makeOutgoingCallsAsCallCenter", IsNullable = false, Namespace = "")]
    public bool MakeOutgoingCallsAsCallCenter {
        get => _makeOutgoingCallsAsCallCenter;
        set {
            MakeOutgoingCallsAsCallCenterSpecified = true;
            _makeOutgoingCallsAsCallCenter = value;
        }
    }

    [XmlIgnore]
    public bool MakeOutgoingCallsAsCallCenterSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.DNISKey _outgoingCallDNIS;

    [XmlElement(ElementName = "outgoingCallDNIS", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.DNISKey OutgoingCallDNIS {
        get => _outgoingCallDNIS;
        set {
            OutgoingCallDNISSpecified = true;
            _outgoingCallDNIS = value;
        }
    }

    [XmlIgnore]
    public bool OutgoingCallDNISSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability> _callCenterAvailability;

    [XmlElement(ElementName = "callCenterAvailability", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.CallCenterAgentAvailability> CallCenterAvailability {
        get => _callCenterAvailability;
        set {
            CallCenterAvailabilitySpecified = true;
            _callCenterAvailability = value;
        }
    }

    [XmlIgnore]
    public bool CallCenterAvailabilitySpecified { get; set; }
}
}