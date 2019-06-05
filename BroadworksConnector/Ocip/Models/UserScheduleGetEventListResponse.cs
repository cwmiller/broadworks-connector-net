using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserScheduleGetEventListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<string> _eventName;

    [XmlElement(ElementName = "eventName", IsNullable = false, Namespace = "")]
    public List<string> EventName {
        get => _eventName;
        set {
            EventNameSpecified = true;
            _eventName = value;
        }
    }

    [XmlIgnore]
    public bool EventNameSpecified { get; set; }
}
}
