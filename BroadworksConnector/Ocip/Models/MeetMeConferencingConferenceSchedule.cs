using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Conference schedule.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class MeetMeConferencingConferenceSchedule 
    {

        
        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless _scheduleReservationless;

        [XmlElement(ElementName = "scheduleReservationless", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleReservationless ScheduleReservationless {
            get => _scheduleReservationless;
            set {
                ScheduleReservationlessSpecified = true;
                _scheduleReservationless = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleReservationlessSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime _scheduleOneTime;

        [XmlElement(ElementName = "scheduleOneTime", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleOneTime ScheduleOneTime {
            get => _scheduleOneTime;
            set {
                ScheduleOneTimeSpecified = true;
                _scheduleOneTime = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleOneTimeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring _scheduleRecurring;

        [XmlElement(ElementName = "scheduleRecurring", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceScheduleScheduleRecurring ScheduleRecurring {
            get => _scheduleRecurring;
            set {
                ScheduleRecurringSpecified = true;
                _scheduleRecurring = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleRecurringSpecified { get; set; }
        
    }
}
