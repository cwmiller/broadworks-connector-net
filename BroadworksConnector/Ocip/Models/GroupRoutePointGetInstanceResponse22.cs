using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupRoutePointGetInstanceRequest22.
    /// <see cref="GroupRoutePointGetInstanceRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""a27224a048c30ff69eab9209dec841cc:673""}]")]
    public class GroupRoutePointGetInstanceResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile19sp1 ServiceInstanceProfile
        {
            get => _serviceInstanceProfile;
            set
            {
                ServiceInstanceProfileSpecified = true;
                _serviceInstanceProfile = value;
            }
        }

        [XmlIgnore]
        public bool ServiceInstanceProfileSpecified { get; set; }

        private string _networkClassOfService;

        [XmlElement(ElementName = "networkClassOfService", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool NetworkClassOfServiceSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AudioFileCodec22 _externalPreferredAudioCodec;

        [XmlElement(ElementName = "externalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool ExternalPreferredAudioCodecSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AudioFileCodec22 _internalPreferredAudioCodec;

        [XmlElement(ElementName = "internalPreferredAudioCodec", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool InternalPreferredAudioCodecSpecified { get; set; }

        private int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool QueueLengthSpecified { get; set; }

        private int _noAnswerTimeoutRings;

        [XmlElement(ElementName = "noAnswerTimeoutRings", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool NoAnswerTimeoutRingsSpecified { get; set; }

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool EnableVideoSpecified { get; set; }

        private bool _playRingingWhenOfferingCall;

        [XmlElement(ElementName = "playRingingWhenOfferingCall", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool PlayRingingWhenOfferingCallSpecified { get; set; }

        private bool _overrideAgentWrapUpTime;

        [XmlElement(ElementName = "overrideAgentWrapUpTime", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool OverrideAgentWrapUpTimeSpecified { get; set; }

        private int _wrapUpSeconds;

        [XmlElement(ElementName = "wrapUpSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
        [MinInclusive(1)]
        [MaxInclusive(3600)]
        public int WrapUpSeconds
        {
            get => _wrapUpSeconds;
            set
            {
                WrapUpSecondsSpecified = true;
                _wrapUpSeconds = value;
            }
        }

        [XmlIgnore]
        public bool WrapUpSecondsSpecified { get; set; }

        private bool _enableAutomaticStateChangeForAgents;

        [XmlElement(ElementName = "enableAutomaticStateChangeForAgents", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool EnableAutomaticStateChangeForAgentsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.AgentACDAutomaticState _agentStateAfterCall;

        [XmlElement(ElementName = "agentStateAfterCall", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool AgentStateAfterCallSpecified { get; set; }

        private string _agentUnavailableCode;

        [XmlElement(ElementName = "agentUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool AgentUnavailableCodeSpecified { get; set; }

        private bool _forceDeliveryOfCalls;

        [XmlElement(ElementName = "forceDeliveryOfCalls", IsNullable = false, Namespace = "")]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
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
        public bool ForceDeliveryOfCallsSpecified { get; set; }

        private int _forceDeliveryWaitTimeSeconds;

        [XmlElement(ElementName = "forceDeliveryWaitTimeSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"a27224a048c30ff69eab9209dec841cc:673")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int ForceDeliveryWaitTimeSeconds
        {
            get => _forceDeliveryWaitTimeSeconds;
            set
            {
                ForceDeliveryWaitTimeSecondsSpecified = true;
                _forceDeliveryWaitTimeSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ForceDeliveryWaitTimeSecondsSpecified { get; set; }

    }
}
