using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemProvisioningValidationGetResponse14sp2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _isNetworkServerQueryActive;

    [XmlElement(ElementName = "isNetworkServerQueryActive", IsNullable = false, Namespace = "")]
    public bool IsNetworkServerQueryActive {
        get => _isNetworkServerQueryActive;
        set {
            IsNetworkServerQueryActiveSpecified = true;
            _isNetworkServerQueryActive = value;
        }
    }

    [XmlIgnore]
    public bool IsNetworkServerQueryActiveSpecified { get; set; }
    private int _timeoutSeconds;

    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
    public int TimeoutSeconds {
        get => _timeoutSeconds;
        set {
            TimeoutSecondsSpecified = true;
            _timeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeoutSecondsSpecified { get; set; }
}
}
