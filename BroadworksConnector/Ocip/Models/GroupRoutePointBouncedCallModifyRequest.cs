using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupRoutePointBouncedCallModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceUserId;

    [XmlElement(ElementName = "serviceUserId", IsNullable = false, Namespace = "")]
    public string ServiceUserId {
        get => _serviceUserId;
        set {
            ServiceUserIdSpecified = true;
            _serviceUserId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceUserIdSpecified { get; set; }
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
    private int _numberOfRingsBeforeBouncingCall;

    [XmlElement(ElementName = "numberOfRingsBeforeBouncingCall", IsNullable = false, Namespace = "")]
    public int NumberOfRingsBeforeBouncingCall {
        get => _numberOfRingsBeforeBouncingCall;
        set {
            NumberOfRingsBeforeBouncingCallSpecified = true;
            _numberOfRingsBeforeBouncingCall = value;
        }
    }

    [XmlIgnore]
    public bool NumberOfRingsBeforeBouncingCallSpecified { get; set; }
    private bool _enableTransfer;

    [XmlElement(ElementName = "enableTransfer", IsNullable = false, Namespace = "")]
    public bool EnableTransfer {
        get => _enableTransfer;
        set {
            EnableTransferSpecified = true;
            _enableTransfer = value;
        }
    }

    [XmlIgnore]
    public bool EnableTransferSpecified { get; set; }
    private string _transferPhoneNumber;

    [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
    public string TransferPhoneNumber {
        get => _transferPhoneNumber;
        set {
            TransferPhoneNumberSpecified = true;
            _transferPhoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool TransferPhoneNumberSpecified { get; set; }
    private bool _bounceCallWhenAgentUnavailable;

    [XmlElement(ElementName = "bounceCallWhenAgentUnavailable", IsNullable = false, Namespace = "")]
    public bool BounceCallWhenAgentUnavailable {
        get => _bounceCallWhenAgentUnavailable;
        set {
            BounceCallWhenAgentUnavailableSpecified = true;
            _bounceCallWhenAgentUnavailable = value;
        }
    }

    [XmlIgnore]
    public bool BounceCallWhenAgentUnavailableSpecified { get; set; }
}
}
