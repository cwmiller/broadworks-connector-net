using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVideoAddOnModifyRequest14 : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
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
    private BroadworksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds _maxOriginatingCallDelaySeconds;

    [XmlElement(ElementName = "maxOriginatingCallDelaySeconds", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.VideoAddOnMaxOriginatingCallDelaySeconds MaxOriginatingCallDelaySeconds {
        get => _maxOriginatingCallDelaySeconds;
        set {
            MaxOriginatingCallDelaySecondsSpecified = true;
            _maxOriginatingCallDelaySeconds = value;
        }
    }

    [XmlIgnore]
    public bool MaxOriginatingCallDelaySecondsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointModify AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
}
}
