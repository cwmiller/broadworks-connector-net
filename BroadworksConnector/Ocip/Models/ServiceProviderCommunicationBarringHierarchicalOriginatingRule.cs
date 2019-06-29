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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3787"",""children"":[{""__type"":""Choice:#BroadWorksConnector.Ocip.Validation"",""id"":""c0d21ef9ba207c335d8347e5172fce1d:3788""}]}]")]
    public class ServiceProviderCommunicationBarringHierarchicalOriginatingRule
    {

        private string _criteria;

        [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3788")]
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

        private string _digitPatternCriteria;

        [XmlElement(ElementName = "digitPatternCriteria", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3788")]
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

        private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _action;

        [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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

        private string _treatmentId;

        [XmlElement(ElementName = "treatmentId", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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

        private string _transferNumber;

        [XmlElement(ElementName = "transferNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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

        private int _callTimeoutSeconds;

        [XmlElement(ElementName = "callTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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

        private string _timeSchedule;

        [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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

        private string _holidaySchedule;

        [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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

        private decimal _priority;

        [XmlElement(ElementName = "priority", IsNullable = false, Namespace = "")]
        [Group(@"c0d21ef9ba207c335d8347e5172fce1d:3787")]
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
