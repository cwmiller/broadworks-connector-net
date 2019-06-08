using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class CallCenterReportCurrentInterval 
{
    private BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit _timeUnit;

    [XmlElement(ElementName = "timeUnit", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallCenterReportIntervalTimeUnit TimeUnit {
        get => _timeUnit;
        set {
            TimeUnitSpecified = true;
            _timeUnit = value;
        }
    }

    [XmlIgnore]
    public bool TimeUnitSpecified { get; set; }
}
}
