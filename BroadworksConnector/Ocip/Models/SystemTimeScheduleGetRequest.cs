using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemTimeScheduleGetRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _timeScheduleName;

    [XmlElement(ElementName = "timeScheduleName", IsNullable = false, Namespace = "")]
    public string TimeScheduleName {
        get => _timeScheduleName;
        set {
            TimeScheduleNameSpecified = true;
            _timeScheduleName = value;
        }
    }

    [XmlIgnore]
    public bool TimeScheduleNameSpecified { get; set; }
}
}
