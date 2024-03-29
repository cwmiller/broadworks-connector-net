using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a Call Center instance.
    /// The response is either SuccessResponse or ErrorResponse.
    /// 
    /// Replaced By: GroupCallCenterModifyInstanceRequest16
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="GroupCallCenterModifyInstanceRequest16"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:6746""}]")]
    public class GroupCallCenterModifyInstanceRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceUserId;

        [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
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

        protected BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public BroadWorksConnector.Ocip.Models.HuntPolicy Policy
        {
            get => _policy;
            set
            {
                PolicySpecified = true;
                _policy = value;
            }
        }

        [XmlIgnore]
        protected bool PolicySpecified { get; set; }

        protected bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool HuntAfterNoAnswer
        {
            get => _huntAfterNoAnswer;
            set
            {
                HuntAfterNoAnswerSpecified = true;
                _huntAfterNoAnswer = value;
            }
        }

        [XmlIgnore]
        protected bool HuntAfterNoAnswerSpecified { get; set; }

        protected int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        [MinInclusive(1)]
        [MaxInclusive(20)]
        public int NoAnswerNumberOfRings
        {
            get => _noAnswerNumberOfRings;
            set
            {
                NoAnswerNumberOfRingsSpecified = true;
                _noAnswerNumberOfRings = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerNumberOfRingsSpecified { get; set; }

        protected bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool ForwardAfterTimeout
        {
            get => _forwardAfterTimeout;
            set
            {
                ForwardAfterTimeoutSpecified = true;
                _forwardAfterTimeout = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardAfterTimeoutSpecified { get; set; }

        protected int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        [MinInclusive(0)]
        [MaxInclusive(7200)]
        public int ForwardTimeoutSeconds
        {
            get => _forwardTimeoutSeconds;
            set
            {
                ForwardTimeoutSecondsSpecified = true;
                _forwardTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardTimeoutSecondsSpecified { get; set; }

        protected string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ForwardToPhoneNumber
        {
            get => _forwardToPhoneNumber;
            set
            {
                ForwardToPhoneNumberSpecified = true;
                _forwardToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool ForwardToPhoneNumberSpecified { get; set; }

        protected bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
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

        protected int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        [MinInclusive(0)]
        [MaxInclusive(50)]
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

        protected bool _allowAgentLogoff;

        [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool AllowAgentLogoff
        {
            get => _allowAgentLogoff;
            set
            {
                AllowAgentLogoffSpecified = true;
                _allowAgentLogoff = value;
            }
        }

        [XmlIgnore]
        protected bool AllowAgentLogoffSpecified { get; set; }

        protected bool _playMusicOnHold;

        [XmlElement(ElementName = "playMusicOnHold", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool PlayMusicOnHold
        {
            get => _playMusicOnHold;
            set
            {
                PlayMusicOnHoldSpecified = true;
                _playMusicOnHold = value;
            }
        }

        [XmlIgnore]
        protected bool PlayMusicOnHoldSpecified { get; set; }

        protected bool _playComfortMessage;

        [XmlElement(ElementName = "playComfortMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool PlayComfortMessage
        {
            get => _playComfortMessage;
            set
            {
                PlayComfortMessageSpecified = true;
                _playComfortMessage = value;
            }
        }

        [XmlIgnore]
        protected bool PlayComfortMessageSpecified { get; set; }

        protected int _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        [MinInclusive(10)]
        [MaxInclusive(600)]
        public int TimeBetweenComfortMessagesSeconds
        {
            get => _timeBetweenComfortMessagesSeconds;
            set
            {
                TimeBetweenComfortMessagesSecondsSpecified = true;
                _timeBetweenComfortMessagesSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool TimeBetweenComfortMessagesSecondsSpecified { get; set; }

        protected bool _enableGuardTimer;

        [XmlElement(ElementName = "enableGuardTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool EnableGuardTimer
        {
            get => _enableGuardTimer;
            set
            {
                EnableGuardTimerSpecified = true;
                _enableGuardTimer = value;
            }
        }

        [XmlIgnore]
        protected bool EnableGuardTimerSpecified { get; set; }

        protected int _guardTimerSeconds;

        [XmlElement(ElementName = "guardTimerSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        [MinInclusive(1)]
        [MaxInclusive(25)]
        public int GuardTimerSeconds
        {
            get => _guardTimerSeconds;
            set
            {
                GuardTimerSecondsSpecified = true;
                _guardTimerSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool GuardTimerSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ReplacementUserIdList _agentUserIdList;

        [XmlElement(ElementName = "agentUserIdList", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public BroadWorksConnector.Ocip.Models.ReplacementUserIdList AgentUserIdList
        {
            get => _agentUserIdList;
            set
            {
                AgentUserIdListSpecified = true;
                _agentUserIdList = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserIdListSpecified { get; set; }

        protected bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool AllowCallWaitingForAgents
        {
            get => _allowCallWaitingForAgents;
            set
            {
                AllowCallWaitingForAgentsSpecified = true;
                _allowCallWaitingForAgents = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallWaitingForAgentsSpecified { get; set; }

        protected bool _allowCallsToAgentsInWrapUp;

        [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool AllowCallsToAgentsInWrapUp
        {
            get => _allowCallsToAgentsInWrapUp;
            set
            {
                AllowCallsToAgentsInWrapUpSpecified = true;
                _allowCallsToAgentsInWrapUp = value;
            }
        }

        [XmlIgnore]
        protected bool AllowCallsToAgentsInWrapUpSpecified { get; set; }

        protected bool _enableCallQueueWhenNoAgentsAvailable;

        [XmlElement(ElementName = "enableCallQueueWhenNoAgentsAvailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public bool EnableCallQueueWhenNoAgentsAvailable
        {
            get => _enableCallQueueWhenNoAgentsAvailable;
            set
            {
                EnableCallQueueWhenNoAgentsAvailableSpecified = true;
                _enableCallQueueWhenNoAgentsAvailable = value;
            }
        }

        [XmlIgnore]
        protected bool EnableCallQueueWhenNoAgentsAvailableSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource _statisticsSource;

        [XmlElement(ElementName = "statisticsSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:6746")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource StatisticsSource
        {
            get => _statisticsSource;
            set
            {
                StatisticsSourceSpecified = true;
                _statisticsSource = value;
            }
        }

        [XmlIgnore]
        protected bool StatisticsSourceSpecified { get; set; }

    }
}
