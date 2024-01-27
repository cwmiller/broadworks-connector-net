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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:2521""}]")]
    public class SystemAuthenticationLockoutSettingsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected int _counterResetIntervalDays;

        [XmlElement(ElementName = "counterResetIntervalDays", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2521")]
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

        protected int _counterResetHour;

        [XmlElement(ElementName = "counterResetHour", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2521")]
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

        protected int _counterResetMinute;

        [XmlElement(ElementName = "counterResetMinute", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2521")]
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

        protected bool _emergencySIPBypassAllowed;

        [XmlElement(ElementName = "emergencySIPBypassAllowed", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:2521")]
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
