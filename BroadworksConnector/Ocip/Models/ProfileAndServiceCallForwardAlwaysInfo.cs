using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCallForwardAlwaysInfo 
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
    private string _forwardToPhoneNumber;

    [XmlElement(ElementName = "forwardToPhoneNumber", IsNullable = false, Namespace = "")]
    public string ForwardToPhoneNumber {
        get => _forwardToPhoneNumber;
        set {
            ForwardToPhoneNumberSpecified = true;
            _forwardToPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool ForwardToPhoneNumberSpecified { get; set; }
    private bool _isRingSplashActive;

    [XmlElement(ElementName = "isRingSplashActive", IsNullable = false, Namespace = "")]
    public bool IsRingSplashActive {
        get => _isRingSplashActive;
        set {
            IsRingSplashActiveSpecified = true;
            _isRingSplashActive = value;
        }
    }

    [XmlIgnore]
    public bool IsRingSplashActiveSpecified { get; set; }
}
}
