using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupScheduleGetListResponse17sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.ScheduleGlobalKey> _scheduleGlobalKey;

    [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ScheduleGlobalKey> ScheduleGlobalKey {
        get => _scheduleGlobalKey;
        set {
            ScheduleGlobalKeySpecified = true;
            _scheduleGlobalKey = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleGlobalKeySpecified { get; set; }
}
}
