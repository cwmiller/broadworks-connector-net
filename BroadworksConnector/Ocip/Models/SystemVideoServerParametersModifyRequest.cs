using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVideoServerParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private int _videoServerResponseTimerMilliseconds;

    [XmlElement(ElementName = "videoServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
    public int VideoServerResponseTimerMilliseconds {
        get => _videoServerResponseTimerMilliseconds;
        set {
            VideoServerResponseTimerMillisecondsSpecified = true;
            _videoServerResponseTimerMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool VideoServerResponseTimerMillisecondsSpecified { get; set; }
    private int _videoServerSelectionRouteTimerMilliseconds;

    [XmlElement(ElementName = "videoServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
    public int VideoServerSelectionRouteTimerMilliseconds {
        get => _videoServerSelectionRouteTimerMilliseconds;
        set {
            VideoServerSelectionRouteTimerMillisecondsSpecified = true;
            _videoServerSelectionRouteTimerMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool VideoServerSelectionRouteTimerMillisecondsSpecified { get; set; }
    private bool _useStaticVideoServerDevice;

    [XmlElement(ElementName = "useStaticVideoServerDevice", IsNullable = false, Namespace = "")]
    public bool UseStaticVideoServerDevice {
        get => _useStaticVideoServerDevice;
        set {
            UseStaticVideoServerDeviceSpecified = true;
            _useStaticVideoServerDevice = value;
        }
    }

    [XmlIgnore]
    public bool UseStaticVideoServerDeviceSpecified { get; set; }
}
}
