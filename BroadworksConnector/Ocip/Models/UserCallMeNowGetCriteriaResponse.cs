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

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

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
        protected bool TimeScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

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
        protected bool HolidayScheduleSpecified { get; set; }

        protected bool _rejectCall;

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
        protected bool RejectCallSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteria _toDnCriteria;

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
        protected bool ToDnCriteriaSpecified { get; set; }

    }
}
