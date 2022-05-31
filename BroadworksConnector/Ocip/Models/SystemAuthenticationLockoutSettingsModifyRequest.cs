using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the system level device password lockout settings
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:2493""}]")]
    public class SystemAuthenticationLockoutSettingsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _counterResetIntervalDays;

        [XmlElement(ElementName = "counterResetIntervalDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2493")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2493")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2493")]
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
        [Optional]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:2493")]
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
