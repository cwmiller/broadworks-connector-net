using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the agents call center settings and the availability for an agent in one or more Call Centers.
    /// Contains a list specifying the desired availability status of one or more call centers.
    /// A default unavailable code will be used if the parameter agentUnavailableCode is not active, included or is invalid.
    /// Changing the agentACDState from unavailable to any other state will automatically clear the unavailable code.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// agentACDState
    /// agentThresholdProfileName
    /// agentUnavailableCode
    /// useSystemDefaultUnavailableSettings
    /// forceAgentUnavailableOnDNDActivation
    /// forceAgentUnavailableOnPersonalCalls
    /// forceAgentUnavailableOnBouncedCallLimit
    /// numberConsecutiveBouncedCallsToForceAgentUnavailable
    /// forceAgentUnavailableOnNotReachable
    /// makeOutgoingCallsAsCallCenter
    /// outgoingCallDNIS
    /// useSystemDefaultWrapUpDestination
    /// wrapUpDestination
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7259""}]")]
    public class UserCallCenterModifyRequest19 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.AgentACDState _agentACDState;

        [XmlElement(ElementName = "agentACDState", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public BroadWorksConnector.Ocip.Models.AgentACDState AgentACDState
        {
            get => _agentACDState;
            set
            {
                AgentACDStateSpecified = true;
                _agentACDState = value;
            }
        }

        [XmlIgnore]
        protected bool AgentACDStateSpecified { get; set; }

        protected string _agentThresholdProfileName;

        [XmlElement(ElementName = "agentThresholdProfileName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        [MinLength(1)]
        [MaxLength(40)]
        public string AgentThresholdProfileName
        {
            get => _agentThresholdProfileName;
            set
            {
                AgentThresholdProfileNameSpecified = true;
                _agentThresholdProfileName = value;
            }
        }

        [XmlIgnore]
        protected bool AgentThresholdProfileNameSpecified { get; set; }

        protected string _agentUnavailableCode;

        [XmlElement(ElementName = "agentUnavailableCode", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
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

        protected bool _useDefaultGuardTimer;

        [XmlElement(ElementName = "useDefaultGuardTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool UseDefaultGuardTimer
        {
            get => _useDefaultGuardTimer;
            set
            {
                UseDefaultGuardTimerSpecified = true;
                _useDefaultGuardTimer = value;
            }
        }

        [XmlIgnore]
        protected bool UseDefaultGuardTimerSpecified { get; set; }

        protected bool _enableGuardTimer;

        [XmlElement(ElementName = "enableGuardTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
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

        protected bool _useSystemDefaultUnavailableSettings;

        [XmlElement(ElementName = "useSystemDefaultUnavailableSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool UseSystemDefaultUnavailableSettings
        {
            get => _useSystemDefaultUnavailableSettings;
            set
            {
                UseSystemDefaultUnavailableSettingsSpecified = true;
                _useSystemDefaultUnavailableSettings = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemDefaultUnavailableSettingsSpecified { get; set; }

        protected bool _forceAgentUnavailableOnDNDActivation;

        [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool ForceAgentUnavailableOnDNDActivation
        {
            get => _forceAgentUnavailableOnDNDActivation;
            set
            {
                ForceAgentUnavailableOnDNDActivationSpecified = true;
                _forceAgentUnavailableOnDNDActivation = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnDNDActivationSpecified { get; set; }

        protected bool _forceAgentUnavailableOnPersonalCalls;

        [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool ForceAgentUnavailableOnPersonalCalls
        {
            get => _forceAgentUnavailableOnPersonalCalls;
            set
            {
                ForceAgentUnavailableOnPersonalCallsSpecified = true;
                _forceAgentUnavailableOnPersonalCalls = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnPersonalCallsSpecified { get; set; }

        protected bool _forceAgentUnavailableOnBouncedCallLimit;

        [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool ForceAgentUnavailableOnBouncedCallLimit
        {
            get => _forceAgentUnavailableOnBouncedCallLimit;
            set
            {
                ForceAgentUnavailableOnBouncedCallLimitSpecified = true;
                _forceAgentUnavailableOnBouncedCallLimit = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnBouncedCallLimitSpecified { get; set; }

        protected int _numberConsecutiveBouncedCallsToForceAgentUnavailable;

        [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int NumberConsecutiveBouncedCallsToForceAgentUnavailable
        {
            get => _numberConsecutiveBouncedCallsToForceAgentUnavailable;
            set
            {
                NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified = true;
                _numberConsecutiveBouncedCallsToForceAgentUnavailable = value;
            }
        }

        [XmlIgnore]
        protected bool NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified { get; set; }

        protected bool _forceAgentUnavailableOnNotReachable;

        [XmlElement(ElementName = "forceAgentUnavailableOnNotReachable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool ForceAgentUnavailableOnNotReachable
        {
            get => _forceAgentUnavailableOnNotReachable;
            set
            {
                ForceAgentUnavailableOnNotReachableSpecified = true;
                _forceAgentUnavailableOnNotReachable = value;
            }
        }

        [XmlIgnore]
        protected bool ForceAgentUnavailableOnNotReachableSpecified { get; set; }

        protected bool _makeOutgoingCallsAsCallCenter;

        [XmlElement(ElementName = "makeOutgoingCallsAsCallCenter", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool MakeOutgoingCallsAsCallCenter
        {
            get => _makeOutgoingCallsAsCallCenter;
            set
            {
                MakeOutgoingCallsAsCallCenterSpecified = true;
                _makeOutgoingCallsAsCallCenter = value;
            }
        }

        [XmlIgnore]
        protected bool MakeOutgoingCallsAsCallCenterSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.DNISKey _outgoingCallDNIS;

        [XmlElement(ElementName = "outgoingCallDNIS", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public BroadWorksConnector.Ocip.Models.DNISKey OutgoingCallDNIS
        {
            get => _outgoingCallDNIS;
            set
            {
                OutgoingCallDNISSpecified = true;
                _outgoingCallDNIS = value;
            }
        }

        [XmlIgnore]
        protected bool OutgoingCallDNISSpecified { get; set; }

        protected List<BroadWorksConnector.Ocip.Models.CallCenterAgentSettings> _callCenterAgentSettings = new List<BroadWorksConnector.Ocip.Models.CallCenterAgentSettings>();

        [XmlElement(ElementName = "callCenterAgentSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public List<BroadWorksConnector.Ocip.Models.CallCenterAgentSettings> CallCenterAgentSettings
        {
            get => _callCenterAgentSettings;
            set
            {
                CallCenterAgentSettingsSpecified = true;
                _callCenterAgentSettings = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterAgentSettingsSpecified { get; set; }

        protected bool _useSystemDefaultWrapUpDestination;

        [XmlElement(ElementName = "useSystemDefaultWrapUpDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        public bool UseSystemDefaultWrapUpDestination
        {
            get => _useSystemDefaultWrapUpDestination;
            set
            {
                UseSystemDefaultWrapUpDestinationSpecified = true;
                _useSystemDefaultWrapUpDestination = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemDefaultWrapUpDestinationSpecified { get; set; }

        protected string _wrapUpDestination;

        [XmlElement(ElementName = "wrapUpDestination", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7259")]
        [MinLength(1)]
        [MaxLength(161)]
        public string WrapUpDestination
        {
            get => _wrapUpDestination;
            set
            {
                WrapUpDestinationSpecified = true;
                _wrapUpDestination = value;
            }
        }

        [XmlIgnore]
        protected bool WrapUpDestinationSpecified { get; set; }

    }
}
