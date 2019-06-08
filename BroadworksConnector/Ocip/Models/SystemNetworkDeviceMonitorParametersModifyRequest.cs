using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemNetworkDeviceMonitorParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _pollingIntervalMinutes;

    [XmlElement(ElementName = "pollingIntervalMinutes", IsNullable = false, Namespace = "")]
    public int PollingIntervalMinutes {
        get => _pollingIntervalMinutes;
        set {
            PollingIntervalMinutesSpecified = true;
            _pollingIntervalMinutes = value;
        }
    }

    [XmlIgnore]
    public bool PollingIntervalMinutesSpecified { get; set; }
    private int _failedPollingIntervalMinutes;

    [XmlElement(ElementName = "failedPollingIntervalMinutes", IsNullable = false, Namespace = "")]
    public int FailedPollingIntervalMinutes {
        get => _failedPollingIntervalMinutes;
        set {
            FailedPollingIntervalMinutesSpecified = true;
            _failedPollingIntervalMinutes = value;
        }
    }

    [XmlIgnore]
    public bool FailedPollingIntervalMinutesSpecified { get; set; }
}
}
