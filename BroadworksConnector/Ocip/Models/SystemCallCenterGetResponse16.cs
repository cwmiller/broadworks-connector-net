using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallCenterGetRequest16.
        /// <see cref="SystemCallCenterGetRequest16"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemCallCenterGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private string _defaultFromAddress;

        [XmlElement(ElementName = "defaultFromAddress", IsNullable = false, Namespace = "")]
        public string DefaultFromAddress {
            get => _defaultFromAddress;
            set {
                DefaultFromAddressSpecified = true;
                _defaultFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DefaultFromAddressSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes _statisticsSamplingPeriodMinutes;

        [XmlElement(ElementName = "statisticsSamplingPeriodMinutes", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CallCenterStatisticsSamplingPeriodMinutes StatisticsSamplingPeriodMinutes {
            get => _statisticsSamplingPeriodMinutes;
            set {
                StatisticsSamplingPeriodMinutesSpecified = true;
                _statisticsSamplingPeriodMinutes = value;
            }
        }

        [XmlIgnore]
        public bool StatisticsSamplingPeriodMinutesSpecified { get; set; }
        
        private bool _defaultEnableGuardTimer;

        [XmlElement(ElementName = "defaultEnableGuardTimer", IsNullable = false, Namespace = "")]
        public bool DefaultEnableGuardTimer {
            get => _defaultEnableGuardTimer;
            set {
                DefaultEnableGuardTimerSpecified = true;
                _defaultEnableGuardTimer = value;
            }
        }

        [XmlIgnore]
        public bool DefaultEnableGuardTimerSpecified { get; set; }
        
        private int _defaultGuardTimerSeconds;

        [XmlElement(ElementName = "defaultGuardTimerSeconds", IsNullable = false, Namespace = "")]
        public int DefaultGuardTimerSeconds {
            get => _defaultGuardTimerSeconds;
            set {
                DefaultGuardTimerSecondsSpecified = true;
                _defaultGuardTimerSeconds = value;
            }
        }

        [XmlIgnore]
        public bool DefaultGuardTimerSecondsSpecified { get; set; }
        
        private bool _forceAgentUnavailableOnDNDActivation;

        [XmlElement(ElementName = "forceAgentUnavailableOnDNDActivation", IsNullable = false, Namespace = "")]
        public bool ForceAgentUnavailableOnDNDActivation {
            get => _forceAgentUnavailableOnDNDActivation;
            set {
                ForceAgentUnavailableOnDNDActivationSpecified = true;
                _forceAgentUnavailableOnDNDActivation = value;
            }
        }

        [XmlIgnore]
        public bool ForceAgentUnavailableOnDNDActivationSpecified { get; set; }
        
        private bool _forceAgentUnavailableOnPersonalCalls;

        [XmlElement(ElementName = "forceAgentUnavailableOnPersonalCalls", IsNullable = false, Namespace = "")]
        public bool ForceAgentUnavailableOnPersonalCalls {
            get => _forceAgentUnavailableOnPersonalCalls;
            set {
                ForceAgentUnavailableOnPersonalCallsSpecified = true;
                _forceAgentUnavailableOnPersonalCalls = value;
            }
        }

        [XmlIgnore]
        public bool ForceAgentUnavailableOnPersonalCallsSpecified { get; set; }
        
        private bool _forceAgentUnavailableOnBouncedCallLimit;

        [XmlElement(ElementName = "forceAgentUnavailableOnBouncedCallLimit", IsNullable = false, Namespace = "")]
        public bool ForceAgentUnavailableOnBouncedCallLimit {
            get => _forceAgentUnavailableOnBouncedCallLimit;
            set {
                ForceAgentUnavailableOnBouncedCallLimitSpecified = true;
                _forceAgentUnavailableOnBouncedCallLimit = value;
            }
        }

        [XmlIgnore]
        public bool ForceAgentUnavailableOnBouncedCallLimitSpecified { get; set; }
        
        private int _numberConsecutiveBouncedCallsToForceAgentUnavailable;

        [XmlElement(ElementName = "numberConsecutiveBouncedCallsToForceAgentUnavailable", IsNullable = false, Namespace = "")]
        public int NumberConsecutiveBouncedCallsToForceAgentUnavailable {
            get => _numberConsecutiveBouncedCallsToForceAgentUnavailable;
            set {
                NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified = true;
                _numberConsecutiveBouncedCallsToForceAgentUnavailable = value;
            }
        }

        [XmlIgnore]
        public bool NumberConsecutiveBouncedCallsToForceAgentUnavailableSpecified { get; set; }
        
    }
}
