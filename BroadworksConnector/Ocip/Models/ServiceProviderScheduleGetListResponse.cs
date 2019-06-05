using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderScheduleGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.ScheduleKey> _scheduleKey;

    [XmlElement(ElementName = "scheduleKey", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ScheduleKey> ScheduleKey {
        get => _scheduleKey;
        set {
            ScheduleKeySpecified = true;
            _scheduleKey = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleKeySpecified { get; set; }
}
}
