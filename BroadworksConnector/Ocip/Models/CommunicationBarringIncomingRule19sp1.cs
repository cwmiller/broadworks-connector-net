using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Incoming Rule
        /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
     
    public class CommunicationBarringIncomingRule19sp1 
    {

        
        private string _digitPatternCriteria;

        [XmlElement(ElementName = "digitPatternCriteria", IsNullable = false, Namespace = "")]
        public string DigitPatternCriteria {
            get => _digitPatternCriteria;
            set {
                DigitPatternCriteriaSpecified = true;
                _digitPatternCriteria = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternCriteriaSpecified { get; set; }
        
        private string _incomingCriteria;

        [XmlElement(ElementName = "incomingCriteria", IsNullable = false, Namespace = "")]
        public string IncomingCriteria {
            get => _incomingCriteria;
            set {
                IncomingCriteriaSpecified = true;
                _incomingCriteria = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCriteriaSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction Action {
            get => _action;
            set {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }
        
        private int _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = false, Namespace = "")]
        public int CallTimeoutSeconds {
            get => _callTimeoutSeconds;
            set {
                CallTimeoutSecondsSpecified = true;
                _callTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool CallTimeoutSecondsSpecified { get; set; }
        
        private string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        public string TimeSchedule {
            get => _timeSchedule;
            set {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }
        
        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        public string HolidaySchedule {
            get => _holidaySchedule;
            set {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }
        
        private decimal _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        public decimal Priority {
            get => _priority;
            set {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }
        
    }
}
