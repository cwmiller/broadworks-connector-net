using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _useSystemDefaultGuardTimer;

    [XmlElement(ElementName = "useSystemDefaultGuardTimer", IsNullable = false, Namespace = "")]
    public bool UseSystemDefaultGuardTimer {
        get => _useSystemDefaultGuardTimer;
        set {
            UseSystemDefaultGuardTimerSpecified = true;
            _useSystemDefaultGuardTimer = value;
        }
    }

    [XmlIgnore]
    public bool UseSystemDefaultGuardTimerSpecified { get; set; }
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
}
}
