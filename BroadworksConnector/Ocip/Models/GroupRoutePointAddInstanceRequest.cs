using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointAddInstanceRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter _serviceInstanceProfile;

    [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ServiceInstanceAddProfileCallCenter ServiceInstanceProfile {
        get => _serviceInstanceProfile;
        set {
            ServiceInstanceProfileSpecified = true;
            _serviceInstanceProfile = value;
        }
    }

    [XmlIgnore]
    public bool ServiceInstanceProfileSpecified { get; set; }
    private string _networkClassOfService;

    [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
    public string NetworkClassOfService {
        get => _networkClassOfService;
        set {
            NetworkClassOfServiceSpecified = true;
            _networkClassOfService = value;
        }
    }

    [XmlIgnore]
    public bool NetworkClassOfServiceSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AudioFileCodec _externalPreferredAudioCodec;

    [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AudioFileCodec ExternalPreferredAudioCodec {
        get => _externalPreferredAudioCodec;
        set {
            ExternalPreferredAudioCodecSpecified = true;
            _externalPreferredAudioCodec = value;
        }
    }

    [XmlIgnore]
    public bool ExternalPreferredAudioCodecSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AudioFileCodec _internalPreferredAudioCodec;

    [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AudioFileCodec InternalPreferredAudioCodec {
        get => _internalPreferredAudioCodec;
        set {
            InternalPreferredAudioCodecSpecified = true;
            _internalPreferredAudioCodec = value;
        }
    }

    [XmlIgnore]
    public bool InternalPreferredAudioCodecSpecified { get; set; }
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
    private int _noAnswerTimeoutRings;

    [XmlElement(ElementName = "noAnswerTimeoutRings", IsNullable = false, Namespace = "")]
    public int NoAnswerTimeoutRings {
        get => _noAnswerTimeoutRings;
        set {
            NoAnswerTimeoutRingsSpecified = true;
            _noAnswerTimeoutRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerTimeoutRingsSpecified { get; set; }
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
    private bool _playRingingWhenOfferingCall;

    [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false, Namespace = "")]
    public bool PlayRingingWhenOfferingCall {
        get => _playRingingWhenOfferingCall;
        set {
            PlayRingingWhenOfferingCallSpecified = true;
            _playRingingWhenOfferingCall = value;
        }
    }

    [XmlIgnore]
    public bool PlayRingingWhenOfferingCallSpecified { get; set; }
    private bool _overrideAgentWrapUpTime;

    [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
    public bool OverrideAgentWrapUpTime {
        get => _overrideAgentWrapUpTime;
        set {
            OverrideAgentWrapUpTimeSpecified = true;
            _overrideAgentWrapUpTime = value;
        }
    }

    [XmlIgnore]
    public bool OverrideAgentWrapUpTimeSpecified { get; set; }
    private int _wrapUpSeconds;

    [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false, Namespace = "")]
    public int WrapUpSeconds {
        get => _wrapUpSeconds;
        set {
            WrapUpSecondsSpecified = true;
            _wrapUpSeconds = value;
        }
    }

    [XmlIgnore]
    public bool WrapUpSecondsSpecified { get; set; }
    private bool _enableAutomaticStateChangeForAgents;

    [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false, Namespace = "")]
    public bool EnableAutomaticStateChangeForAgents {
        get => _enableAutomaticStateChangeForAgents;
        set {
            EnableAutomaticStateChangeForAgentsSpecified = true;
            _enableAutomaticStateChangeForAgents = value;
        }
    }

    [XmlIgnore]
    public bool EnableAutomaticStateChangeForAgentsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AgentACDAutomaticState _agentStateAfterCall;

    [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AgentACDAutomaticState AgentStateAfterCall {
        get => _agentStateAfterCall;
        set {
            AgentStateAfterCallSpecified = true;
            _agentStateAfterCall = value;
        }
    }

    [XmlIgnore]
    public bool AgentStateAfterCallSpecified { get; set; }
    private string _agentUnavailableCode;

    [XmlElement(ElementName = "agentUnavailableCode", IsNullable = false, Namespace = "")]
    public string AgentUnavailableCode {
        get => _agentUnavailableCode;
        set {
            AgentUnavailableCodeSpecified = true;
            _agentUnavailableCode = value;
        }
    }

    [XmlIgnore]
    public bool AgentUnavailableCodeSpecified { get; set; }
    private bool _forceDeliveryOfCalls;

    [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false, Namespace = "")]
    public bool ForceDeliveryOfCalls {
        get => _forceDeliveryOfCalls;
        set {
            ForceDeliveryOfCallsSpecified = true;
            _forceDeliveryOfCalls = value;
        }
    }

    [XmlIgnore]
    public bool ForceDeliveryOfCallsSpecified { get; set; }
    private int _forceDeliveryWaitTimeSeconds;

    [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = false, Namespace = "")]
    public int ForceDeliveryWaitTimeSeconds {
        get => _forceDeliveryWaitTimeSeconds;
        set {
            ForceDeliveryWaitTimeSecondsSpecified = true;
            _forceDeliveryWaitTimeSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ForceDeliveryWaitTimeSecondsSpecified { get; set; }
}
}
