using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserCallMeNowGetCriteriaRequest.
    /// <see cref="UserCallMeNowGetCriteriaRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1f0f230fee2817fe00157925859dc28e:148""}]")]
    public class UserCallMeNowGetCriteriaResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:148")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:148")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }

        private bool _rejectCall;

        [XmlElement(ElementName = "rejectCall", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:148")]
        public bool RejectCall
        {
            get => _rejectCall;
            set
            {
                RejectCallSpecified = true;
                _rejectCall = value;
            }
        }

        [XmlIgnore]
        public bool RejectCallSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteria _toDnCriteria;

        [XmlElement(ElementName = "toDnCriteria", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:148")]
        public BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteria ToDnCriteria
        {
            get => _toDnCriteria;
            set
            {
                ToDnCriteriaSpecified = true;
                _toDnCriteria = value;
            }
        }

        [XmlIgnore]
        public bool ToDnCriteriaSpecified { get; set; }

    }
}
