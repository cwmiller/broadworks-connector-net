using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupFindMeFollowMeAddAlertingGroupSelectiveCriteriaRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
    private string _alertingGroupName;

    [XmlElement(ElementName = "alertingGroupName", IsNullable = false, Namespace = "")]
    public string AlertingGroupName {
        get => _alertingGroupName;
        set {
            AlertingGroupNameSpecified = true;
            _alertingGroupName = value;
        }
    }

    [XmlIgnore]
    public bool AlertingGroupNameSpecified { get; set; }
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
    private bool _blacklisted;

    [XmlElement(ElementName = "blacklisted", IsNullable = false, Namespace = "")]
    public bool Blacklisted {
        get => _blacklisted;
        set {
            BlacklistedSpecified = true;
            _blacklisted = value;
        }
    }

    [XmlIgnore]
    public bool BlacklistedSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.CriteriaFromDn _fromDnCriteria;

    [XmlElement(ElementName = "fromDnCriteria", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CriteriaFromDn FromDnCriteria {
        get => _fromDnCriteria;
        set {
            FromDnCriteriaSpecified = true;
            _fromDnCriteria = value;
        }
    }

    [XmlIgnore]
    public bool FromDnCriteriaSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.CallToNumber> _callToNumber;

    [XmlElement(ElementName = "callToNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CallToNumber> CallToNumber {
        get => _callToNumber;
        set {
            CallToNumberSpecified = true;
            _callToNumber = value;
        }
    }

    [XmlIgnore]
    public bool CallToNumberSpecified { get; set; }
}
}
