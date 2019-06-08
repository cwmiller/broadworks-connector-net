using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetListResponse17sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> _scheduleGlobalKey;

    [XmlElement(ElementName = "scheduleGlobalKey", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.ScheduleGlobalKey> ScheduleGlobalKey {
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
