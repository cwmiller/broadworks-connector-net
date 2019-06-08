using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderScheduleGetEventResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _startDate;

    [XmlElement(ElementName = "startDate", IsNullable = false, Namespace = "")]
    public string StartDate {
        get => _startDate;
        set {
            StartDateSpecified = true;
            _startDate = value;
        }
    }

    [XmlIgnore]
    public bool StartDateSpecified { get; set; }
    private bool _allDayEvent;

    [XmlElement(ElementName = "allDayEvent", IsNullable = false, Namespace = "")]
    public bool AllDayEvent {
        get => _allDayEvent;
        set {
            AllDayEventSpecified = true;
            _allDayEvent = value;
        }
    }

    [XmlIgnore]
    public bool AllDayEventSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.HourMinute _startTime;

    [XmlElement(ElementName = "startTime", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.HourMinute StartTime {
        get => _startTime;
        set {
            StartTimeSpecified = true;
            _startTime = value;
        }
    }

    [XmlIgnore]
    public bool StartTimeSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.HourMinute _endTime;

    [XmlElement(ElementName = "endTime", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.HourMinute EndTime {
        get => _endTime;
        set {
            EndTimeSpecified = true;
            _endTime = value;
        }
    }

    [XmlIgnore]
    public bool EndTimeSpecified { get; set; }
    private string _endDate;

    [XmlElement(ElementName = "endDate", IsNullable = false, Namespace = "")]
    public string EndDate {
        get => _endDate;
        set {
            EndDateSpecified = true;
            _endDate = value;
        }
    }

    [XmlIgnore]
    public bool EndDateSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.Recurrence _recurrence;

    [XmlElement(ElementName = "recurrence", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.Recurrence Recurrence {
        get => _recurrence;
        set {
            RecurrenceSpecified = true;
            _recurrence = value;
        }
    }

    [XmlIgnore]
    public bool RecurrenceSpecified { get; set; }
}
}
