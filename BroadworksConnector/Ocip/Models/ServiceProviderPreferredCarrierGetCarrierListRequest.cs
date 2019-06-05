using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderPreferredCarrierGetCarrierListRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private string _countryCode;

    [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
    public string CountryCode {
        get => _countryCode;
        set {
            CountryCodeSpecified = true;
            _countryCode = value;
        }
    }

    [XmlIgnore]
    public bool CountryCodeSpecified { get; set; }
}
}
