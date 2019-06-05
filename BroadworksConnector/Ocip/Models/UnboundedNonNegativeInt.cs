using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UnboundedNonNegativeInt 
{
    private bool _unlimited;

    [XmlElement(ElementName = "unlimited", IsNullable = false, Namespace = "")]
    public bool Unlimited {
        get => _unlimited;
        set {
            UnlimitedSpecified = true;
            _unlimited = value;
        }
    }

    [XmlIgnore]
    public bool UnlimitedSpecified { get; set; }
    private int _quantity;

    [XmlElement(ElementName = "quantity", IsNullable = false, Namespace = "")]
    public int Quantity {
        get => _quantity;
        set {
            QuantitySpecified = true;
            _quantity = value;
        }
    }

    [XmlIgnore]
    public bool QuantitySpecified { get; set; }
}
}
