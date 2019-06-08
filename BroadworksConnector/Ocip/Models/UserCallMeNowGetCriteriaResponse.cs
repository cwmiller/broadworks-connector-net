using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallMeNowGetCriteriaResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.TimeSchedule _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TimeSchedule TimeSchedule {
        get => _timeSchedule;
        set {
            TimeScheduleSpecified = true;
            _timeSchedule = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

    [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
    private bool _rejectCall;

    [XmlElement(ElementName = "rejectCall", IsNullable = false, Namespace = "")]
    public bool RejectCall {
        get => _rejectCall;
        set {
            RejectCallSpecified = true;
            _rejectCall = value;
        }
    }

    [XmlIgnore]
    public bool RejectCallSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteria _toDnCriteria;

    [XmlElement(ElementName = "toDnCriteria", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallMeNowToDnCriteria ToDnCriteria {
        get => _toDnCriteria;
        set {
            ToDnCriteriaSpecified = true;
            _toDnCriteria = value;
        }
    }

    [XmlIgnore]
    public bool ToDnCriteriaSpecified { get; set; }
}
}
