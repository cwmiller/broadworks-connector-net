using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallForwardingNotReachableGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
}
}
