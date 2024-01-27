using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Route Point instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// The Following elements are only used in AS data mode and ignored in XS data mode:
    /// - sendCallAdmissionNotification, use value ‘false’ in XS data mode.
    /// - callAdmissionTimerSeconds, use value ‘3’ in XS data mode.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e474d11df9a1d1d1041e589793e40de8:855""}]")]
    public class GroupRoutePointModifyInstanceRequest22 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinLength(1)]
        [MaxLength(161)]
        public string ServiceUserId
        {
            get => _serviceUserId;
            set
            {
                ServiceUserIdSpecified = true;
                _serviceUserId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceUserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceInstanceProfileSpecified { get; set; }

        protected string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinLength(1)]
        [MaxLength(40)]
        public string NetworkClassOfService
        {
            get => _networkClassOfService;
            set
            {
                NetworkClassOfServiceSpecified = true;
                _networkClassOfService = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkClassOfServiceSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AudioFileCodec22 _externalPreferredAudioCodec;

        [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec22 ExternalPreferredAudioCodec
        {
            get => _externalPreferredAudioCodec;
            set
            {
                ExternalPreferredAudioCodecSpecified = true;
                _externalPreferredAudioCodec = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalPreferredAudioCodecSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AudioFileCodec22 _internalPreferredAudioCodec;

        [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec22 InternalPreferredAudioCodec
        {
            get => _internalPreferredAudioCodec;
            set
            {
                InternalPreferredAudioCodecSpecified = true;
                _internalPreferredAudioCodec = value;
            }
        }

        [XmlIgnore]
        protected bool InternalPreferredAudioCodecSpecified { get; set; }

        protected int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinInclusive(0)]
        [MaxInclusive(525)]
        public int QueueLength
        {
            get => _queueLength;
            set
            {
                QueueLengthSpecified = true;
                _queueLength = value;
            }
        }

        [XmlIgnore]
        protected bool QueueLengthSpecified { get; set; }

        protected int _noAnswerTimeoutRings;

        [XmlElement(ElementName = "noAnswerTimeoutRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinInclusive(2)]
        [MaxInclusive(20)]
        public int NoAnswerTimeoutRings
        {
            get => _noAnswerTimeoutRings;
            set
            {
                NoAnswerTimeoutRingsSpecified = true;
                _noAnswerTimeoutRings = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerTimeoutRingsSpecified { get; set; }

        protected bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool EnableVideo
        {
            get => _enableVideo;
            set
            {
                EnableVideoSpecified = true;
                _enableVideo = value;
            }
        }

        [XmlIgnore]
        protected bool EnableVideoSpecified { get; set; }

        protected bool _playRingingWhenOfferingCall;

        [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool PlayRingingWhenOfferingCall
        {
            get => _playRingingWhenOfferingCall;
            set
            {
                PlayRingingWhenOfferingCallSpecified = true;
                _playRingingWhenOfferingCall = value;
            }
        }

        [XmlIgnore]
        protected bool PlayRingingWhenOfferingCallSpecified { get; set; }

        protected bool _overrideAgentWrapUpTime;

        [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool OverrideAgentWrapUpTime
        {
            get => _overrideAgentWrapUpTime;
            set
            {
                OverrideAgentWrapUpTimeSpecified = true;
                _overrideAgentWrapUpTime = value;
            }
        }

        [XmlIgnore]
        protected bool OverrideAgentWrapUpTimeSpecified { get; set; }

        protected int? _wrapUpSeconds;

        [XmlElement(ElementName = "wrapUpSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinInclusive(1)]
        [MaxInclusive(3600)]
        public int? WrapUpSeconds
        {
            get => _wrapUpSeconds;
            set
            {
                WrapUpSecondsSpecified = true;
                _wrapUpSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool WrapUpSecondsSpecified { get; set; }

        protected bool _enableAutomaticStateChangeForAgents;

        [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool EnableAutomaticStateChangeForAgents
        {
            get => _enableAutomaticStateChangeForAgents;
            set
            {
                EnableAutomaticStateChangeForAgentsSpecified = true;
                _enableAutomaticStateChangeForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool EnableAutomaticStateChangeForAgentsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AgentACDAutomaticState _agentStateAfterCall;

        [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public BroadWorksConnector.Ocip.Models.AgentACDAutomaticState AgentStateAfterCall
        {
            get => _agentStateAfterCall;
            set
            {
                AgentStateAfterCallSpecified = true;
                _agentStateAfterCall = value;
            }
        }

        [XmlIgnore]
        protected bool AgentStateAfterCallSpecified { get; set; }

        protected string _agentUnavailableCode;

        [XmlElement(ElementName = "agentUnavailableCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinLength(1)]
        [MaxLength(10)]
        public string AgentUnavailableCode
        {
            get => _agentUnavailableCode;
            set
            {
                AgentUnavailableCodeSpecified = true;
                _agentUnavailableCode = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUnavailableCodeSpecified { get; set; }

        protected bool _forceDeliveryOfCalls;

        [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool ForceDeliveryOfCalls
        {
            get => _forceDeliveryOfCalls;
            set
            {
                ForceDeliveryOfCallsSpecified = true;
                _forceDeliveryOfCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ForceDeliveryOfCallsSpecified { get; set; }

        protected int? _forceDeliveryWaitTimeSeconds;

        [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? ForceDeliveryWaitTimeSeconds
        {
            get => _forceDeliveryWaitTimeSeconds;
            set
            {
                ForceDeliveryWaitTimeSecondsSpecified = true;
                _forceDeliveryWaitTimeSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ForceDeliveryWaitTimeSecondsSpecified { get; set; }

        protected bool _sendCallAdmissionNotification;

        [XmlElement(ElementName = "sendCallAdmissionNotification", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool SendCallAdmissionNotification
        {
            get => _sendCallAdmissionNotification;
            set
            {
                SendCallAdmissionNotificationSpecified = true;
                _sendCallAdmissionNotification = value;
            }
        }

        [XmlIgnore]
        protected bool SendCallAdmissionNotificationSpecified { get; set; }

        protected int _callAdmissionTimerSeconds;

        [XmlElement(ElementName = "callAdmissionTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        [MinInclusive(1)]
        [MaxInclusive(60)]
        public int CallAdmissionTimerSeconds
        {
            get => _callAdmissionTimerSeconds;
            set
            {
                CallAdmissionTimerSecondsSpecified = true;
                _callAdmissionTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool CallAdmissionTimerSecondsSpecified { get; set; }

        protected bool _enableUnlimitedQueueLength;

        [XmlElement(ElementName = "enableUnlimitedQueueLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e474d11df9a1d1d1041e589793e40de8:855")]
        public bool EnableUnlimitedQueueLength
        {
            get => _enableUnlimitedQueueLength;
            set
            {
                EnableUnlimitedQueueLengthSpecified = true;
                _enableUnlimitedQueueLength = value;
            }
        }

        [XmlIgnore]
        protected bool EnableUnlimitedQueueLengthSpecified { get; set; }

    }
}
