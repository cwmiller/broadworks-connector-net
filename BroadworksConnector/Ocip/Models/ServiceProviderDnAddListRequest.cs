using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderDnAddListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private List<string> _phoneNumber;

    [XmlElement(ElementName = "phoneNumber", IsNullable = false, Namespace = "")]
    public List<string> PhoneNumber {
        get => _phoneNumber;
        set {
            PhoneNumberSpecified = true;
            _phoneNumber = value;
        }
    }

    [XmlIgnore]
    public bool PhoneNumberSpecified { get; set; }
    private List<BroadworksConnector.Ocip.Models.DNRange> _dnRange;

    [XmlElement(ElementName = "dnRange", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DNRange> DnRange {
        get => _dnRange;
        set {
            DnRangeSpecified = true;
            _dnRange = value;
        }
    }

    [XmlIgnore]
    public bool DnRangeSpecified { get; set; }
}
}
