using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallCenterGetRequest23.
    /// Contains the user's call center settings.
    /// Indicates whether the agent is current available (logged in) to each call center in the list.
    /// Contains a table with column headings: "Service User Id", "Phone Number", "Extension", "Available", "Logoff Allowed", "Type",
    /// "Priority","Routing Policy" and "Skill Level".
    /// The valid "Routing Type" values are "Priority Based" and "Skill Based". This column is only populated for Premium Call Centers.
    /// The valid "Skill Level" values are of from 1-20. This column is only populated for Premium Skill Based Call Centers.
    /// 
    /// The following elements are only used in AS data mode and not returned in XS data mode:
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
    /// 
    /// The following columns are only used in AS data mode and not returned in XS data mode:
    /// "Routing Policy"
    /// "Skill Level"
    /// <see cref="UserCallCenterGetRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e2c537e3e39483b96620673a7012ffdd:7105""}]")]
    public class UserCallCenterGetResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.AgentACDState _agentACDState;

        [XmlElement(ElementName = "agentACDState", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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

        [XmlElement(ElementName = "agentUnavailableCode", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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

        [XmlElement(ElementName = "outgoingCallDNIS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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

        protected bool _useSystemDefaultWrapUpDestination;

        [XmlElement(ElementName = "useSystemDefaultWrapUpDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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

        [XmlElement(ElementName = "wrapUpDestination", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
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

        protected BroadWorksConnector.Ocip.Models.C.OCITable _callCenterTable;

        [XmlElement(ElementName = "callCenterTable", IsNullable = false, Namespace = "")]
        [Group(@"e2c537e3e39483b96620673a7012ffdd:7105")]
        public BroadWorksConnector.Ocip.Models.C.OCITable CallCenterTable
        {
            get => _callCenterTable;
            set
            {
                CallCenterTableSpecified = true;
                _callCenterTable = value;
            }
        }

        [XmlIgnore]
        protected bool CallCenterTableSpecified { get; set; }

    }
}
