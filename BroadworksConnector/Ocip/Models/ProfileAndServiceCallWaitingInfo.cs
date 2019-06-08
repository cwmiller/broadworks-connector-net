using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCallWaitingInfo 
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
    private bool _disableCallingLineIdDelivery;

    [XmlElement(ElementName = "disableCallingLineIdDelivery", IsNullable = false, Namespace = "")]
    public bool DisableCallingLineIdDelivery {
        get => _disableCallingLineIdDelivery;
        set {
            DisableCallingLineIdDeliverySpecified = true;
            _disableCallingLineIdDelivery = value;
        }
    }

    [XmlIgnore]
    public bool DisableCallingLineIdDeliverySpecified { get; set; }
}
}
