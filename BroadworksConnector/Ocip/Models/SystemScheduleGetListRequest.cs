using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemScheduleGetListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.ScheduleType _scheduleType;

    [XmlElement(ElementName = "scheduleType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ScheduleType ScheduleType {
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
