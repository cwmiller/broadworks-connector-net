using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderCommunicationBarringHierarchicalOriginatingRule 
{
    private string _criteria;

    [XmlElement(ElementName = "criteria", IsNullable = false, Namespace = "")]
    public string Criteria {
        get => _criteria;
        set {
            CriteriaSpecified = true;
            _criteria = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaSpecified { get; set; }
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
    private BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction _action;

    [XmlElement(ElementName = "action", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CommunicationBarringOriginatingAction Action {
        get => _action;
        set {
            ActionSpecified = true;
            _action = value;
        }
    }

    [XmlIgnore]
    public bool ActionSpecified { get; set; }
    private string _treatmentId;

    [XmlElement(ElementName = "treatmentId", IsNullable = true, Namespace = "")]
    public string TreatmentId {
        get => _treatmentId;
        set {
            TreatmentIdSpecified = true;
            _treatmentId = value;
        }
    }

    [XmlIgnore]
    public bool TreatmentIdSpecified { get; set; }
    private string _transferNumber;

    [XmlElement(ElementName = "transferNumber", IsNullable = true, Namespace = "")]
    public string TransferNumber {
        get => _transferNumber;
        set {
            TransferNumberSpecified = true;
            _transferNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferNumberSpecified { get; set; }
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
