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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""0fd24121d16995c994d40bc408dbcfa5:984""}]")]
    public class MeetMeConferencingConferenceScheduleScheduleOneTime
    {

        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:984")]
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
        protected bool StartTimeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _duration;

        [XmlElement(ElementName = "duration", IsNullable = false, Namespace = "")]
        [Group(@"0fd24121d16995c994d40bc408dbcfa5:984")]
        public BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration Duration
        {
            get => _duration;
            set
            {
                DurationSpecified = true;
                _duration = value;
            }
        }

        [XmlIgnore]
        protected bool DurationSpecified { get; set; }

    }
}
