using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupCallCenterModifyInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HuntPolicy _policy;

    [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HuntPolicy Policy {
        get => _policy;
        set {
            PolicySpecified = true;
            _policy = value;
        }
    }

    [XmlIgnore]
    public bool PolicySpecified { get; set; }
    private bool _huntAfterNoAnswer;

    [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
    public bool HuntAfterNoAnswer {
        get => _huntAfterNoAnswer;
        set {
            HuntAfterNoAnswerSpecified = true;
            _huntAfterNoAnswer = value;
        }
    }

    [XmlIgnore]
    public bool HuntAfterNoAnswerSpecified { get; set; }
    private int _noAnswerNumberOfRings;

    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public int NoAnswerNumberOfRings {
        get => _noAnswerNumberOfRings;
        set {
            NoAnswerNumberOfRingsSpecified = true;
            _noAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerNumberOfRingsSpecified { get; set; }
    private bool _forwardAfterTimeout;

    [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
    public bool ForwardAfterTimeout {
        get => _forwardAfterTimeout;
        set {
            ForwardAfterTimeoutSpecified = true;
            _forwardAfterTimeout = value;
        }
    }

    [XmlIgnore]
    public bool ForwardAfterTimeoutSpecified { get; set; }
    private int _forwardTimeoutSeconds;

    [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int ForwardTimeoutSeconds {
        get => _forwardTimeoutSeconds;
        set {
            ForwardTimeoutSecondsSpecified = true;
            _forwardTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ForwardTimeoutSecondsSpecified { get; set; }
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
    private bool _enableVideo;

    [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
    public bool EnableVideo {
        get => _enableVideo;
        set {
            EnableVideoSpecified = true;
            _enableVideo = value;
        }
    }

    [XmlIgnore]
    public bool EnableVideoSpecified { get; set; }
    private int _queueLength;

    [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
    public int QueueLength {
        get => _queueLength;
        set {
            QueueLengthSpecified = true;
            _queueLength = value;
        }
    }

    [XmlIgnore]
    public bool QueueLengthSpecified { get; set; }
    private bool _allowAgentLogoff;

    [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false, Namespace = "")]
    public bool AllowAgentLogoff {
        get => _allowAgentLogoff;
        set {
            AllowAgentLogoffSpecified = true;
            _allowAgentLogoff = value;
        }
    }

    [XmlIgnore]
    public bool AllowAgentLogoffSpecified { get; set; }
    private bool _playMusicOnHold;

    [XmlElement(ElementName = "playMusicOnHold", IsNullable = false, Namespace = "")]
    public bool PlayMusicOnHold {
        get => _playMusicOnHold;
        set {
            PlayMusicOnHoldSpecified = true;
            _playMusicOnHold = value;
        }
    }

    [XmlIgnore]
    public bool PlayMusicOnHoldSpecified { get; set; }
    private bool _playComfortMessage;

    [XmlElement(ElementName = "playComfortMessage", IsNullable = false, Namespace = "")]
    public bool PlayComfortMessage {
        get => _playComfortMessage;
        set {
            PlayComfortMessageSpecified = true;
            _playComfortMessage = value;
        }
    }

    [XmlIgnore]
    public bool PlayComfortMessageSpecified { get; set; }
    private int _timeBetweenComfortMessagesSeconds;

    [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
    public int TimeBetweenComfortMessagesSeconds {
        get => _timeBetweenComfortMessagesSeconds;
        set {
            TimeBetweenComfortMessagesSecondsSpecified = true;
            _timeBetweenComfortMessagesSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

    [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList {
        get => _agentUserIdList;
        set {
            AgentUserIdListSpecified = true;
            _agentUserIdList = value;
        }
    }

    [XmlIgnore]
    public bool AgentUserIdListSpecified { get; set; }
    private bool _allowCallWaitingForAgents;

    [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
    public bool AllowCallWaitingForAgents {
        get => _allowCallWaitingForAgents;
        set {
            AllowCallWaitingForAgentsSpecified = true;
            _allowCallWaitingForAgents = value;
        }
    }

    [XmlIgnore]
    public bool AllowCallWaitingForAgentsSpecified { get; set; }
    private bool _allowCallsToAgentsInWrapUp;

    [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false, Namespace = "")]
    public bool AllowCallsToAgentsInWrapUp {
        get => _allowCallsToAgentsInWrapUp;
        set {
            AllowCallsToAgentsInWrapUpSpecified = true;
            _allowCallsToAgentsInWrapUp = value;
        }
    }

    [XmlIgnore]
    public bool AllowCallsToAgentsInWrapUpSpecified { get; set; }
    private bool _enableCallQueueWhenNoAgentsAvailable;

    [XmlElement(ElementName = "enableCallQueueWhenNoAgentsAvailable", IsNullable = false, Namespace = "")]
    public bool EnableCallQueueWhenNoAgentsAvailable {
        get => _enableCallQueueWhenNoAgentsAvailable;
        set {
            EnableCallQueueWhenNoAgentsAvailableSpecified = true;
            _enableCallQueueWhenNoAgentsAvailable = value;
        }
    }

    [XmlIgnore]
    public bool EnableCallQueueWhenNoAgentsAvailableSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CallCenterStatisticsSource _statisticsSource;

    [XmlElement(ElementName = "statisticsSource", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallCenterStatisticsSource StatisticsSource {
        get => _statisticsSource;
        set {
            StatisticsSourceSpecified = true;
            _statisticsSource = value;
        }
    }

    [XmlIgnore]
    public bool StatisticsSourceSpecified { get; set; }
}
}
