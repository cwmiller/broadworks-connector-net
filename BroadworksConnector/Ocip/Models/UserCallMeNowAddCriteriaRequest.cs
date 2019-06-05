using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallMeNowAddCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private string _criteriaName;

    [XmlElement(ElementName = "criteriaName", IsNullable = false, Namespace = "")]
    public string CriteriaName {
        get => _criteriaName;
        set {
            CriteriaNameSpecified = true;
            _criteriaName = value;
        }
    }

    [XmlIgnore]
    public bool CriteriaNameSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TimeSchedule _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TimeSchedule TimeSchedule {
        get => _timeSchedule;
        set {
            TimeScheduleSpecified = true;
            _timeSchedule = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.HolidaySchedule _holidaySchedule;

    [XmlElement(ElementName = "holidaySchedule", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.HolidaySchedule HolidaySchedule {
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
    private BroadworksConnector.Ocip.Models.CallMeNowToDnCriteria _toDnCriteria;

    [XmlElement(ElementName = "toDnCriteria", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallMeNowToDnCriteria ToDnCriteria {
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
