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
    /// Replaced by GroupRoutePointModifyInstanceRequest22.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupRoutePointModifyInstanceRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:3932""}]")]
    public class GroupRoutePointModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        private string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private BroadWorksConnector.Ocip.Models.ServiceInstanceModifyProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private BroadWorksConnector.Ocip.Models.AudioFileCodec _externalPreferredAudioCodec;

        [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec ExternalPreferredAudioCodec
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

        private BroadWorksConnector.Ocip.Models.AudioFileCodec _internalPreferredAudioCodec;

        [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
        public BroadWorksConnector.Ocip.Models.AudioFileCodec InternalPreferredAudioCodec
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

        private int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private int _noAnswerTimeoutRings;

        [XmlElement(ElementName = "noAnswerTimeoutRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private bool _playRingingWhenOfferingCall;

        [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private bool _overrideAgentWrapUpTime;

        [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private int? _wrapUpSeconds;

        [XmlElement(ElementName = "wrapUpSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private bool _enableAutomaticStateChangeForAgents;

        [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private BroadWorksConnector.Ocip.Models.AgentACDAutomaticState _agentStateAfterCall;

        [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private string _agentUnavailableCode;

        [XmlElement(ElementName = "agentUnavailableCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private bool _forceDeliveryOfCalls;

        [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

        private int? _forceDeliveryWaitTimeSeconds;

        [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:3932")]
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

    }
}
