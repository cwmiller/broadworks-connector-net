using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPreferredCarrierNameModify 
{
    private bool _useGroupPreferredCarrier;

    [XmlElement(ElementName = "useGroupPreferredCarrier", IsNullable = false, Namespace = "")]
    public bool UseGroupPreferredCarrier {
        get => _useGroupPreferredCarrier;
        set {
            UseGroupPreferredCarrierSpecified = true;
            _useGroupPreferredCarrier = value;
        }
    }

    [XmlIgnore]
    public bool UseGroupPreferredCarrierSpecified { get; set; }
    private string _carrier;

    [XmlElement(ElementName = "carrier", IsNullable = true, Namespace = "")]
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
