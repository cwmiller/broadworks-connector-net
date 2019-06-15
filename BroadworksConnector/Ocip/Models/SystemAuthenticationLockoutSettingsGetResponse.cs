using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAuthenticationLockoutSettingsGetRequest.
    /// Contains the authentication lockout settings in the system.
        /// <see cref="SystemAuthenticationLockoutSettingsGetRequest"/>
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class SystemAuthenticationLockoutSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private int _counterResetIntervalDays;

        [XmlElement(ElementName = "counterResetIntervalDays", IsNullable = false, Namespace = "")]
        public int CounterResetIntervalDays {
            get => _counterResetIntervalDays;
            set {
                CounterResetIntervalDaysSpecified = true;
                _counterResetIntervalDays = value;
            }
        }

        [XmlIgnore]
        public bool CounterResetIntervalDaysSpecified { get; set; }
        
        private int _counterResetHour;

        [XmlElement(ElementName = "counterResetHour", IsNullable = false, Namespace = "")]
        public int CounterResetHour {
            get => _counterResetHour;
            set {
                CounterResetHourSpecified = true;
                _counterResetHour = value;
            }
        }

        [XmlIgnore]
        public bool CounterResetHourSpecified { get; set; }
        
        private int _counterResetMinute;

        [XmlElement(ElementName = "counterResetMinute", IsNullable = false, Namespace = "")]
        public int CounterResetMinute {
            get => _counterResetMinute;
            set {
                CounterResetMinuteSpecified = true;
                _counterResetMinute = value;
            }
        }

        [XmlIgnore]
        public bool CounterResetMinuteSpecified { get; set; }
        
        private bool _emergencySIPBypassAllowed;

        [XmlElement(ElementName = "emergencySIPBypassAllowed", IsNullable = false, Namespace = "")]
        public bool EmergencySIPBypassAllowed {
            get => _emergencySIPBypassAllowed;
            set {
                EmergencySIPBypassAllowedSpecified = true;
                _emergencySIPBypassAllowed = value;
            }
        }

        [XmlIgnore]
        public bool EmergencySIPBypassAllowedSpecified { get; set; }
        
    }
}
