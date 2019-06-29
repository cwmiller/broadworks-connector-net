using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2058""}]")]
    public class SystemAuthenticationLockoutSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _counterResetIntervalDays;

        [XmlElement(ElementName = "counterResetIntervalDays", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2058")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int CounterResetIntervalDays
        {
            get => _counterResetIntervalDays;
            set
            {
                CounterResetIntervalDaysSpecified = true;
                _counterResetIntervalDays = value;
            }
        }

        [XmlIgnore]
        protected bool CounterResetIntervalDaysSpecified { get; set; }

        private int _counterResetHour;

        [XmlElement(ElementName = "counterResetHour", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2058")]
        [MinInclusive(0)]
        [MaxInclusive(23)]
        public int CounterResetHour
        {
            get => _counterResetHour;
            set
            {
                CounterResetHourSpecified = true;
                _counterResetHour = value;
            }
        }

        [XmlIgnore]
        protected bool CounterResetHourSpecified { get; set; }

        private int _counterResetMinute;

        [XmlElement(ElementName = "counterResetMinute", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2058")]
        [MinInclusive(0)]
        [MaxInclusive(59)]
        public int CounterResetMinute
        {
            get => _counterResetMinute;
            set
            {
                CounterResetMinuteSpecified = true;
                _counterResetMinute = value;
            }
        }

        [XmlIgnore]
        protected bool CounterResetMinuteSpecified { get; set; }

        private bool _emergencySIPBypassAllowed;

        [XmlElement(ElementName = "emergencySIPBypassAllowed", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2058")]
        public bool EmergencySIPBypassAllowed
        {
            get => _emergencySIPBypassAllowed;
            set
            {
                EmergencySIPBypassAllowedSpecified = true;
                _emergencySIPBypassAllowed = value;
            }
        }

        [XmlIgnore]
        protected bool EmergencySIPBypassAllowedSpecified { get; set; }

    }
}
