using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Represents a specific time with hour and minute granularity
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class HourMinute 
    {

        
        private int _hour;

        [XmlElement(ElementName = "hour", IsNullable = false, Namespace = "")]
        public int Hour {
            get => _hour;
            set {
                HourSpecified = true;
                _hour = value;
            }
        }

        [XmlIgnore]
        public bool HourSpecified { get; set; }
        
        private int _minute;

        [XmlElement(ElementName = "minute", IsNullable = false, Namespace = "")]
        public int Minute {
            get => _minute;
            set {
                MinuteSpecified = true;
                _minute = value;
            }
        }

        [XmlIgnore]
        public bool MinuteSpecified { get; set; }
        
    }
}
