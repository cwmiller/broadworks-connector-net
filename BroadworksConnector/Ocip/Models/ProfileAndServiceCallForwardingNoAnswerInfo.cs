using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ProfileAndServiceCallForwardingNoAnswerInfo 
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
    private BroadworksConnector.Ocip.Models.CallForwardingNoAnswerNumberOfRings _numberOfRings;

    [XmlElement(ElementName = "numberOfRings", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.CallForwardingNoAnswerNumberOfRings NumberOfRings {
        get => _numberOfRings;
        set {
            NumberOfRingsSpecified = true;
            _numberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfRingsSpecified { get; set; }
}
}
