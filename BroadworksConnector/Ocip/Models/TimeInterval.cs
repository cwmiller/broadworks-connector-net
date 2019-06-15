using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Time Interval.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class TimeInterval 
    {

        
        private BroadWorksConnector.Ocip.Models.DayOfWeek _startDayOfWeek;

        [XmlElement(ElementName = "startDayOfWeek", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DayOfWeek StartDayOfWeek {
            get => _startDayOfWeek;
            set {
                StartDayOfWeekSpecified = true;
                _startDayOfWeek = value;
            }
        }

        [XmlIgnore]
        public bool StartDayOfWeekSpecified { get; set; }
        
        private int _startHour;

        [XmlElement(ElementName = "startHour", IsNullable = false, Namespace = "")]
        public int StartHour {
            get => _startHour;
            set {
                StartHourSpecified = true;
                _startHour = value;
            }
        }

        [XmlIgnore]
        public bool StartHourSpecified { get; set; }
        
        private int _startMinute;

        [XmlElement(ElementName = "startMinute", IsNullable = false, Namespace = "")]
        public int StartMinute {
            get => _startMinute;
            set {
                StartMinuteSpecified = true;
                _startMinute = value;
            }
        }

        [XmlIgnore]
        public bool StartMinuteSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.DayOfWeek _endDayOfWeek;

        [XmlElement(ElementName = "endDayOfWeek", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.DayOfWeek EndDayOfWeek {
            get => _endDayOfWeek;
            set {
                EndDayOfWeekSpecified = true;
                _endDayOfWeek = value;
            }
        }

        [XmlIgnore]
        public bool EndDayOfWeekSpecified { get; set; }
        
        private int _endHour;

        [XmlElement(ElementName = "endHour", IsNullable = false, Namespace = "")]
        public int EndHour {
            get => _endHour;
            set {
                EndHourSpecified = true;
                _endHour = value;
            }
        }

        [XmlIgnore]
        public bool EndHourSpecified { get; set; }
        
        private int _endMinute;

        [XmlElement(ElementName = "endMinute", IsNullable = false, Namespace = "")]
        public int EndMinute {
            get => _endMinute;
            set {
                EndMinuteSpecified = true;
                _endMinute = value;
            }
        }

        [XmlIgnore]
        public bool EndMinuteSpecified { get; set; }
        
    }
}
