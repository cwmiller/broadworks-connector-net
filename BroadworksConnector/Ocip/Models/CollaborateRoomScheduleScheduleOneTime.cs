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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1062""}]")]
    public class CollaborateRoomScheduleScheduleOneTime
    {

        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1062")]
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

        private BroadWorksConnector.Ocip.Models.CollaborateRoomScheduleDuration _duration;

        [XmlElement(ElementName = "duration", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1062")]
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
        protected bool DurationSpecified { get; set; }

    }
}
