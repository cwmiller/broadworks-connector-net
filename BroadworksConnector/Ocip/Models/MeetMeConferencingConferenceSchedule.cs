using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Conference schedule.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:970"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:971""}]}]")]
    public class MeetMeConferencingConferenceSchedule
    {

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless _scheduleReservationless;

        [XmlElement(ElementName = "scheduleReservationless", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:971")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless ScheduleReservationless
        {
            get => _scheduleReservationless;
            set
            {
                ScheduleReservationlessSpecified = true;
                _scheduleReservationless = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleReservationlessSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime _scheduleOneTime;

        [XmlElement(ElementName = "scheduleOneTime", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:971")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime ScheduleOneTime
        {
            get => _scheduleOneTime;
            set
            {
                ScheduleOneTimeSpecified = true;
                _scheduleOneTime = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleOneTimeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring _scheduleRecurring;

        [XmlElement(ElementName = "scheduleRecurring", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:971")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring ScheduleRecurring
        {
            get => _scheduleRecurring;
            set
            {
                ScheduleRecurringSpecified = true;
                _scheduleRecurring = value;
            }
        }

        [XmlIgnore]
        protected bool ScheduleRecurringSpecified { get; set; }

    }
}
