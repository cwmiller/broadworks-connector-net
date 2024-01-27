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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:1517"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:1518""}]}]")]
    public class CommunicationBarringIncomingRule19sp1
    {

        protected string _digitPatternCriteria;

        [XmlElement(ElementName = "digitPatternCriteria", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1518")]
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
        protected bool DigitPatternCriteriaSpecified { get; set; }

        protected string _incomingCriteria;

        [XmlElement(ElementName = "incomingCriteria", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1518")]
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
        protected bool IncomingCriteriaSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CommunicationBarringIncomingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1517")]
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
        protected bool ActionSpecified { get; set; }

        protected int _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1517")]
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
        protected bool CallTimeoutSecondsSpecified { get; set; }

        protected string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1517")]
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
        protected bool TimeScheduleSpecified { get; set; }

        protected string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1517")]
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
        protected bool HolidayScheduleSpecified { get; set; }

        protected decimal _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:1517")]
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
        protected bool PrioritySpecified { get; set; }

    }
}
