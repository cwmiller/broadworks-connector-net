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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:1080""}]")]
    public class MeetMeConferencingConferenceScheduleScheduleReservationless
    {

        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:1080")]
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

        private string _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = true, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:1080")]
        public string EndTime
        {
            get => _endTime;
            set
            {
                EndTimeSpecified = true;
                _endTime = value;
            }
        }

        [XmlIgnore]
        public bool EndTimeSpecified { get; set; }

    }
}
