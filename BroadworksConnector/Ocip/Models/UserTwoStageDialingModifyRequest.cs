using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTwoStageDialingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _allowActivationWithUserAddresses;

    [XmlElement(ElementName = "allowActivationWithUserAddresses", IsNullable = false, Namespace = "")]
    public bool AllowActivationWithUserAddresses {
        get => _allowActivationWithUserAddresses;
        set {
            AllowActivationWithUserAddressesSpecified = true;
            _allowActivationWithUserAddresses = value;
        }
    }

    [XmlIgnore]
    public bool AllowActivationWithUserAddressesSpecified { get; set; }
}
}