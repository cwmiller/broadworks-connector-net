using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Communication Barring Incoming Rule
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1380"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:1381""}]}]")]
    public class CommunicationBarringIncomingRule19sp1
    {

        private string _digitPatternCriteria;

        [XmlElement(ElementName = "digitPatternCriteria", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1381")]
        [MinLength(1)]
        [MaxLength(40)]
        public string DigitPatternCriteria
        {
            get => _digitPatternCriteria;
            set
            {
                DigitPatternCriteriaSpecified = true;
                _digitPatternCriteria = value;
            }
        }

        [XmlIgnore]
        public bool DigitPatternCriteriaSpecified { get; set; }

        private string _incomingCriteria;

        [XmlElement(ElementName = "incomingCriteria", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1381")]
        [MinLength(1)]
        [MaxLength(40)]
        public string IncomingCriteria
        {
            get => _incomingCriteria;
            set
            {
                IncomingCriteriaSpecified = true;
                _incomingCriteria = value;
            }
        }

        [XmlIgnore]
        public bool IncomingCriteriaSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1380")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction Action
        {
            get => _action;
            set
            {
                ActionSpecified = true;
                _action = value;
            }
        }

        [XmlIgnore]
        public bool ActionSpecified { get; set; }

        private int _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1380")]
        [MinInclusive(60)]
        [MaxInclusive(86400)]
        public int CallTimeoutSeconds
        {
            get => _callTimeoutSeconds;
            set
            {
                CallTimeoutSecondsSpecified = true;
                _callTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool CallTimeoutSecondsSpecified { get; set; }

        private string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1380")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TimeSchedule
        {
            get => _timeSchedule;
            set
            {
                TimeScheduleSpecified = true;
                _timeSchedule = value;
            }
        }

        [XmlIgnore]
        public bool TimeScheduleSpecified { get; set; }

        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1380")]
        [MinLength(1)]
        [MaxLength(40)]
        public string HolidaySchedule
        {
            get => _holidaySchedule;
            set
            {
                HolidayScheduleSpecified = true;
                _holidaySchedule = value;
            }
        }

        [XmlIgnore]
        public bool HolidayScheduleSpecified { get; set; }

        private decimal _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:1380")]
        [MinInclusive(0)]
        [MaxInclusive(1000000)]
        public decimal Priority
        {
            get => _priority;
            set
            {
                PrioritySpecified = true;
                _priority = value;
            }
        }

        [XmlIgnore]
        public bool PrioritySpecified { get; set; }

    }
}
