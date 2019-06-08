using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSharedCallAppearanceAddEndpointRequest14sp2 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.AccessDeviceEndpointAdd _accessDeviceEndpoint;

    [XmlElement(ElementName = "accessDeviceEndpoint", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.AccessDeviceEndpointAdd AccessDeviceEndpoint {
        get => _accessDeviceEndpoint;
        set {
            AccessDeviceEndpointSpecified = true;
            _accessDeviceEndpoint = value;
        }
    }

    [XmlIgnore]
    public bool AccessDeviceEndpointSpecified { get; set; }
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
    private bool _allowOrigination;

    [XmlElement(ElementName = "allowOrigination", IsNullable = false, Namespace = "")]
    public bool AllowOrigination {
        get => _allowOrigination;
        set {
            AllowOriginationSpecified = true;
            _allowOrigination = value;
        }
    }

    [XmlIgnore]
    public bool AllowOriginationSpecified { get; set; }
    private bool _allowTermination;

    [XmlElement(ElementName = "allowTermination", IsNullable = false, Namespace = "")]
    public bool AllowTermination {
        get => _allowTermination;
        set {
            AllowTerminationSpecified = true;
            _allowTermination = value;
        }
    }

    [XmlIgnore]
    public bool AllowTerminationSpecified { get; set; }
}
}
