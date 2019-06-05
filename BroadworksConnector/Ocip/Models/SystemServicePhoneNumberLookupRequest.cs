using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemServicePhoneNumberLookupRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private BroadworksConnector.Ocip.Models.NumberLookupServiceType _serviceType;

    [XmlElement(ElementName = "serviceType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.NumberLookupServiceType ServiceType {
        get => _serviceType;
        set {
            ServiceTypeSpecified = true;
            _serviceType = value;
        }
    }

    [XmlIgnore]
    public bool ServiceTypeSpecified { get; set; }
    private string _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public string PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
}
}
