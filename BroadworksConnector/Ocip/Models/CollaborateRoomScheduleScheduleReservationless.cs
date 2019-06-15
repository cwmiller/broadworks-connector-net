using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// 
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CollaborateRoomScheduleScheduleReservationless 
    {

        
        private string _startTime;

        [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
        public string StartTime {
            get => _startTime;
            set {
                StartTimeSpecified = true;
                _startTime = value;
            }
        }

        [XmlIgnore]
        public bool StartTimeSpecified { get; set; }
        
        private string _endTime;

        [XmlElement(ElementName = "endTime", IsNullable = true, Namespace = "")]
        public string EndTime {
            get => _endTime;
            set {
                EndTimeSpecified = true;
                _endTime = value;
            }
        }

        [XmlIgnore]
        public bool EndTimeSpecified { get; set; }
        
    }
}
