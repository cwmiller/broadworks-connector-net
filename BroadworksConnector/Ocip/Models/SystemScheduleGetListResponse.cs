using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private List<BroadworksConnector.Ocip.Models.ScheduleType> _scheduleType;

    [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ScheduleType> ScheduleType {
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
