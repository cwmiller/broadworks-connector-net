using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _scheduleName;

    [XmlElement(ElementName = "scheduleName", IsNullable = false, Namespace = "")]
    public List<string> ScheduleName {
        get => _scheduleName;
        set {
            ScheduleNameSpecified = true;
            _scheduleName = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleNameSpecified { get; set; }
    private List<BroadWorksConnector.Ocip.Models.ScheduleType> _scheduleType;

    [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ScheduleType> ScheduleType {
        get => _scheduleType;
        set {
            ScheduleTypeSpecified = true;
            _scheduleType = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleTypeSpecified { get; set; }
}
}
