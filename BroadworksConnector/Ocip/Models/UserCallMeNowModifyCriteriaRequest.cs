using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify a criteria for the user's call me now service.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1f0f230fee2817fe00157925859dc28e:201""}]")]
    public class UserCallMeNowModifyCriteriaRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
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

        private string _criteriaName;

        [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
        [MinLength(1)]
        [MaxLength(50)]
        public string CriteriaName
        {
            get => _criteriaName;
            set
            {
                CriteriaNameSpecified = true;
                _criteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaNameSpecified { get; set; }

        private string _newCriteriaName;

        [XmlElement(ElementName = "newCriteriaName", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
        [MinLength(1)]
        [MaxLength(50)]
        public string NewCriteriaName
        {
            get => _newCriteriaName;
            set
            {
                NewCriteriaNameSpecified = true;
                _newCriteriaName = value;
            }
        }

        [XmlIgnore]
        protected bool NewCriteriaNameSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
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

        private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
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

        private bool _rejectCall;

        [XmlElement(ElementName = "rejectCall", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
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

        private BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteriaModify _toDnCriteria;

        [XmlElement(ElementName = "toDnCriteria", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1f0f230fee2817fe00157925859dc28e:201")]
        public BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteriaModify ToDnCriteria
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
