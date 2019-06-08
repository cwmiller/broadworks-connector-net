using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceDoNotDisturbInfo 
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
    private bool _ringSplash;

    [XmlElement(ElementName = "ringSplash", IsNullable = false, Namespace = "")]
    public bool RingSplash {
        get => _ringSplash;
        set {
            RingSplashSpecified = true;
            _ringSplash = value;
        }
    }

    [XmlIgnore]
    public bool RingSplashSpecified { get; set; }
}
}
