using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserSimultaneousRingFamilyModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SimultaneousRingSelection _incomingCalls;

    [XmlElement(ElementName = "incomingCalls", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SimultaneousRingSelection IncomingCalls {
        get => _incomingCalls;
        set {
            IncomingCallsSpecified = true;
            _incomingCalls = value;
        }
    }

    [XmlIgnore]
    public bool IncomingCallsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList _simRingPhoneNumberList;

    [XmlElement(ElementName = "simRingPhoneNumberList", IsNullable = true, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ReplacementOutgoingDNorSIPURIList SimRingPhoneNumberList {
        get => _simRingPhoneNumberList;
        set {
            SimRingPhoneNumberListSpecified = true;
            _simRingPhoneNumberList = value;
        }
    }

    [XmlIgnore]
    public bool SimRingPhoneNumberListSpecified { get; set; }
}
}
