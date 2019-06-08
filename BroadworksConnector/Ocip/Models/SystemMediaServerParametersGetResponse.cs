using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemMediaServerParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _mediaServerResponseTimerMilliseconds;

    [XmlElement(ElementName = "mediaServerResponseTimerMilliseconds", IsNullable = false, Namespace = "")]
    public int MediaServerResponseTimerMilliseconds {
        get => _mediaServerResponseTimerMilliseconds;
        set {
            MediaServerResponseTimerMillisecondsSpecified = true;
            _mediaServerResponseTimerMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool MediaServerResponseTimerMillisecondsSpecified { get; set; }
    private int _mediaServerSelectionRouteTimerMilliseconds;

    [XmlElement(ElementName = "mediaServerSelectionRouteTimerMilliseconds", IsNullable = false, Namespace = "")]
    public int MediaServerSelectionRouteTimerMilliseconds {
        get => _mediaServerSelectionRouteTimerMilliseconds;
        set {
            MediaServerSelectionRouteTimerMillisecondsSpecified = true;
            _mediaServerSelectionRouteTimerMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool MediaServerSelectionRouteTimerMillisecondsSpecified { get; set; }
    private bool _useStaticMediaServerDevice;

    [XmlElement(ElementName = "useStaticMediaServerDevice", IsNullable = false, Namespace = "")]
    public bool UseStaticMediaServerDevice {
        get => _useStaticMediaServerDevice;
        set {
            UseStaticMediaServerDeviceSpecified = true;
            _useStaticMediaServerDevice = value;
        }
    }

    [XmlIgnore]
    public bool UseStaticMediaServerDeviceSpecified { get; set; }
}
}
