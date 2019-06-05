using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderScheduleGetEventDetailListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.ScheduleEvents> _scheduleEventsList;

    [XmlElement(ElementName = "scheduleEventsList", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.ScheduleEvents> ScheduleEventsList {
        get => _scheduleEventsList;
        set {
            ScheduleEventsListSpecified = true;
            _scheduleEventsList = value;
        }
    }

    [XmlIgnore]
    public bool ScheduleEventsListSpecified { get; set; }
}
}
