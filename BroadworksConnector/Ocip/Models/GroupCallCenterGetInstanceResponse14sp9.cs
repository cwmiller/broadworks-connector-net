using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupCallCenterGetInstanceRequest14sp9.
    /// Contains the service profile information and a table of assigned users.
    /// The table has column headings: "User Id", "Last Name", "First Name",
    /// "Hiragana Last Name", "Hiragana First Name", "Weight".
    /// <see cref="GroupCallCenterGetInstanceRequest14sp9"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:8451""}]")]
    public class GroupCallCenterGetInstanceResponse14sp9 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile _serviceInstanceProfile;

        [XmlElement(ElementName = "serviceInstanceProfile", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
        public BroadWorksConnector.Ocip.Models.ServiceInstanceReadProfile ServiceInstanceProfile
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

        private BroadWorksConnector.Ocip.Models.HuntPolicy _policy;

        [XmlElement(ElementName = "policy", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _huntAfterNoAnswer;

        [XmlElement(ElementName = "huntAfterNoAnswer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private int _noAnswerNumberOfRings;

        [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _forwardAfterTimeout;

        [XmlElement(ElementName = "forwardAfterTimeout", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private int _forwardTimeoutSeconds;

        [XmlElement(ElementName = "forwardTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private string _forwardToPhoneNumber;

        [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _enableVideo;

        [XmlElement(ElementName = "enableVideo", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private int _queueLength;

        [XmlElement(ElementName = "queueLength", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _allowAgentLogoff;

        [XmlElement(ElementName = "allowAgentLogoff", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _playMusicOnHold;

        [XmlElement(ElementName = "playMusicOnHold", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _playComfortMessage;

        [XmlElement(ElementName = "playComfortMessage", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private int _timeBetweenComfortMessagesSeconds;

        [XmlElement(ElementName = "timeBetweenComfortMessagesSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _enableGuardTimer;

        [XmlElement(ElementName = "enableGuardTimer", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private int _guardTimerSeconds;

        [XmlElement(ElementName = "guardTimerSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private BroadWorksConnector.Ocip.Models.C.OCITable _agentUserTable;

        [XmlElement(ElementName = "agentUserTable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AgentUserTable
        {
            get => _agentUserTable;
            set
            {
                AgentUserTableSpecified = true;
                _agentUserTable = value;
            }
        }

        [XmlIgnore]
        protected bool AgentUserTableSpecified { get; set; }

        private bool _allowCallWaitingForAgents;

        [XmlElement(ElementName = "allowCallWaitingForAgents", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _allowCallsToAgentsInWrapUp;

        [XmlElement(ElementName = "allowCallsToAgentsInWrapUp", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private bool _enableCallQueueWhenNoAgentsAvailable;

        [XmlElement(ElementName = "enableCallQueueWhenNoAgentsAvailable", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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

        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsSource _statisticsSource;

        [XmlElement(ElementName = "statisticsSource", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:8451")]
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
