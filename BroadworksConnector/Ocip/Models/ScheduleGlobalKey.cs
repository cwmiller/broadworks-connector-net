using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Uniquely identifies Holiday and Time Schedules throughout all System, Service Provider, Group and User level.
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class ScheduleGlobalKey 
    {

        
        private BroadWorksConnector.Ocip.Models.ScheduleKey _scheduleKey;

        [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleKey ScheduleKey {
            get => _scheduleKey;
            set {
                ScheduleKeySpecified = true;
                _scheduleKey = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleKeySpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.ScheduleLevel _scheduleLevel;

        [XmlElement(ElementName = "scheduleLevel", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.ScheduleLevel ScheduleLevel {
            get => _scheduleLevel;
            set {
                ScheduleLevelSpecified = true;
                _scheduleLevel = value;
            }
        }

        [XmlIgnore]
        public bool ScheduleLevelSpecified { get; set; }
        
    }
}
