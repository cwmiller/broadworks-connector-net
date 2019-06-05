using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallingNameDeliveryModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _isActiveForExternalCalls;

    [XmlElement(ElementName = "isActiveForExternalCalls", IsNullable = false, Namespace = "")]
    public bool IsActiveForExternalCalls {
        get => _isActiveForExternalCalls;
        set {
            IsActiveForExternalCallsSpecified = true;
            _isActiveForExternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveForExternalCallsSpecified { get; set; }
    private bool _isActiveForInternalCalls;

    [XmlElement(ElementName = "isActiveForInternalCalls", IsNullable = false, Namespace = "")]
    public bool IsActiveForInternalCalls {
        get => _isActiveForInternalCalls;
        set {
            IsActiveForInternalCallsSpecified = true;
            _isActiveForInternalCalls = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveForInternalCallsSpecified { get; set; }
}
}
