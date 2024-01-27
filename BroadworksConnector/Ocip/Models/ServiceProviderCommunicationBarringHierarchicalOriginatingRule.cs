using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Service Provider Communication Barring Hierarchical Originating Rule
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4933"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""6337d0cfba4de1c83587203c5b0bae54:4934""}]}]")]
    public class ServiceProviderCommunicationBarringHierarchicalOriginatingRule
    {

        protected string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4934")]
        [MinLength(1)]
        [MaxLength(40)]
        public string Criteria
        {
            get => _criteria;
            set
            {
                CriteriaSpecified = true;
                _criteria = value;
            }
        }

        [XmlIgnore]
        protected bool CriteriaSpecified { get; set; }

        protected string _digitPatternCriteria;

        [XmlElement(ElementName = "digitPatternCriteria", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4934")]
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

        protected BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
        public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction Action
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

        protected string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
        [MinLength(1)]
        [MaxLength(40)]
        public string TreatmentId
        {
            get => _treatmentId;
            set
            {
                TreatmentIdSpecified = true;
                _treatmentId = value;
            }
        }

        [XmlIgnore]
        protected bool TreatmentIdSpecified { get; set; }

        protected string _transferNumber;

        [XmlElement(ElementName = "transferNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferNumber
        {
            get => _transferNumber;
            set
            {
                TransferNumberSpecified = true;
                _transferNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferNumberSpecified { get; set; }

        protected int _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
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
        [Group(@"6337d0cfba4de1c83587203c5b0bae54:4933")]
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
