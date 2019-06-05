using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
    [Serializable]
    [XmlRoot(Namespace = "")]
    public class CollaborateRoomScheduleScheduleOneTime
    {
        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
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
        private BroadworksConnector.Ocip.Models.CollaborateRoomScheduleDuration _duration;

        [XmlElement(ElementName = "duration", IsNullable = false, Namespace = "")]
        public BroadworksConnector.Ocip.Models.CollaborateRoomScheduleDuration Duration
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
    }
}
