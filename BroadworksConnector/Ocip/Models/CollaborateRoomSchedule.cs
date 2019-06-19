using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Collaborate room schedule.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1048"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1049""}]}]")]
    public class CollaborateRoomSchedule
    {

        private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleReservationless _scheduleReservationless;

        [XmlElement(ElementName = "scheduleReservationless", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1049")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleReservationless ScheduleReservationless
        {
            get => _scheduleReservationless;
            set
            {
                ScheduleReservationlessSpecified = true;
                _scheduleReservationless = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleReservationlessSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleOneTime _scheduleOneTime;

        [XmlElement(ElementName = "scheduleOneTime", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1049")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleOneTime ScheduleOneTime
        {
            get => _scheduleOneTime;
            set
            {
                ScheduleOneTimeSpecified = true;
                _scheduleOneTime = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleOneTimeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleRecurring _scheduleRecurring;

        [XmlElement(ElementName = "scheduleRecurring", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1049")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleScheduleRecurring ScheduleRecurring
        {
            get => _scheduleRecurring;
            set
            {
                ScheduleRecurringSpecified = true;
                _scheduleRecurring = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleRecurringSpecified { get; set; }

    }
}
