using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCommunicationBarringIncomingCriteriaModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
    private string _timeSchedule;

    [XmlElement(ElementName = "timeSchedule", IsNullable = true, Namespace = "")]
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

    [XmlElement(ElementName = "holidaySchedule", IsNullable = true, Namespace = "")]
    public string HolidaySchedule {
        get => _holidaySchedule;
        set {
            HolidayScheduleSpecified = true;
            _holidaySchedule = value;
        }
    }

    [XmlIgnore]
    public bool HolidayScheduleSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList _matchNumberPortabilityStatus;

    [XmlElement(ElementName = "matchNumberPortabilityStatus", IsNullable = true, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.ReplacementNumberPortabilityStatusList MatchNumberPortabilityStatus {
        get => _matchNumberPortabilityStatus;
        set {
            MatchNumberPortabilityStatusSpecified = true;
            _matchNumberPortabilityStatus = value;
        }
    }

    [XmlIgnore]
    public bool MatchNumberPortabilityStatusSpecified { get; set; }
}
}
