using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserTwoStageDialingGetResponse13Mp20 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
