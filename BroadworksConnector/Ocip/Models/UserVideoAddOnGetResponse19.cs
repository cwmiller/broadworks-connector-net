using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserVideoAddOnGetResponse19 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private BroadworksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AccessDeviceEndpointWithPortNumberRead AccessDeviceEndpoint {
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
