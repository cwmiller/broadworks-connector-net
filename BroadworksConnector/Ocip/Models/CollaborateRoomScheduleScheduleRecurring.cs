using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1071""}]")]
    public class CollaborateRoomScheduleScheduleRecurring
    {

        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1071")]
        public string StartTime
        {
            get => _startTime;
            set
            {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleDuration _duration;

        [XmlElement(ElementName = "duration", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1071")]
        public BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleDuration Duration
        {
            get => _duration;
            set
            {
                DurationSpecified = true;
                _duration = value;
            }
        }

        [XmlIgnore]
        public bool DurationSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

        [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1071")]
        public BroadWorksConnector.Ocip.Models.Recurrence Recurrence
        {
            get => _recurrence;
            set
            {
                RecurrenceSpecified = true;
                _recurrence = value;
            }
        }

        [XmlIgnore]
        public bool RecurrenceSpecified { get; set; }

    }
}
