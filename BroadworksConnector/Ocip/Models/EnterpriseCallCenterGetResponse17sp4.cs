using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to EnterpriseCallCenterGetRequest17sp4.
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// useSystemDefaultUnavailableSettings
    /// forceAgentUnavailableOnDNDActivation
    /// forceAgentUnavailableOnPersonalCalls
    /// forceAgentUnavailableOnBouncedCallLimit
    /// numberConsecutiveBouncedCallsToForceAgentUnavailable
    /// forceAgentUnavailableOnNotReachable
    /// 
    /// Replaced by: EnterpriseCallCenterGetResponse23 in AS data mode
    /// <see cref="EnterpriseCallCenterGetRequest17sp4"/>
    /// <see cref="EnterpriseCallCenterGetResponse23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:384""}]")]
    public class EnterpriseCallCenterGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _useSystemDefaultGuardTimer;

        [XmlElement(ElementName = "useSystemDefaultGuardTimer", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
        public bool UseSystemDefaultGuardTimer
        {
            get => _useSystemDefaultGuardTimer;
            set
            {
                UseSystemDefaultGuardTimerSpecified = true;
                _useSystemDefaultGuardTimer = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemDefaultGuardTimerSpecified { get; set; }

        private bool _enableGuardTimer;

        [XmlElement(ElementName = "enableGuardTimer", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

        private bool _useSystemDefaultUnavailableSettings;

        [XmlElement(ElementName = "useSystemDefaultUnavailableSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

        private bool _forceAgentUnavailableOnDNDActivation;

        [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

        private bool _forceAgentUnavailableOnPersonalCalls;

        [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

        private bool _forceAgentUnavailableOnBouncedCallLimit;

        [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

        private int _numberConsecutiveBouncedCallsToForceAgentUnavailable;

        [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

        private bool _forceAgentUnavailableOnNotReachable;

        [XmlElement(ElementName = "forceAgentUnavailableOnNotReachable", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:384")]
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

    }
}
