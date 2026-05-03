using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserSequentialRingGetCriteriaRequest23.
    /// <see cref="UserSequentialRingGetCriteriaRequest23"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""15725c7b98a01f80f88e9d5af56d48a5:102""}]")]
    public class UserSequentialRingGetCriteriaResponse23 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"15725c7b98a01f80f88e9d5af56d48a5:102")]
        public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = (value != null);
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        protected bool TimeScheduleSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"15725c7b98a01f80f88e9d5af56d48a5:102")]
        public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = (value != null);
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        protected bool HolidayScheduleSpecified { get; set; }

        protected bool _blacklisted;

        [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
        [Group(@"15725c7b98a01f80f88e9d5af56d48a5:102")]
        public bool Blacklisted
        {
            get => _blacklisted;
            set
            {
                BlacklistedSpecified = true;
                _blacklisted = value;
            }
        }

        [XmlIgnore]
        protected bool BlacklistedSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CriteriaFromDn23 _fromDnCriteria23;

        [XmlElement(ElementName = "fromDnCriteria23", IsNullable = false, Namespace = "")]
        [Group(@"15725c7b98a01f80f88e9d5af56d48a5:102")]
        public BroadWorksConnector.Ocip.Models.CriteriaFromDn23 FromDnCriteria23
        {
            get => _fromDnCriteria23;
            set
            {
                FromDnCriteria23Specified = true;
                _fromDnCriteria23 = value;
            }
        }

        [XmlIgnore]
        protected bool FromDnCriteria23Specified { get; set; }

    }
}
