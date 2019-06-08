using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class GroupPreferredCarrierName 
{
    private bool _useServiceProviderPreferredCarrier;

    [XmlElement(ElementName = "useServiceProviderPreferredCarrier", IsNullable = false, Namespace = "")]
    public bool UseServiceProviderPreferredCarrier {
        get => _useServiceProviderPreferredCarrier;
        set {
            UseServiceProviderPreferredCarrierSpecified = true;
            _useServiceProviderPreferredCarrier = value;
        }
    }

    [XmlIgnore]
    public bool UseServiceProviderPreferredCarrierSpecified { get; set; }
    private string _carrier;

    [XmlElement(ElementName = "carrier", IsNullable = false, Namespace = "")]
    public string Carrier {
        get => _carrier;
        set {
            CarrierSpecified = true;
            _carrier = value;
        }
    }

    [XmlIgnore]
    public bool CarrierSpecified { get; set; }
}
}
