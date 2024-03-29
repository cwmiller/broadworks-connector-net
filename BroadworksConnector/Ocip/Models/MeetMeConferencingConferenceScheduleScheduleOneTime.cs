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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""adf25df72505d1c476ebb480b6cce18d:984""}]")]
    public class MeetMeConferencingConferenceScheduleScheduleOneTime
    {

        protected string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:984")]
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

        protected BroadWorksConnector.Ocip.Models.MeetMeConferencingConferenceDuration _duration;

        [XmlElement(ElementName = "duration", IsNullable = false, Namespace = "")]
        [Group(@"adf25df72505d1c476ebb480b6cce18d:984")]
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
