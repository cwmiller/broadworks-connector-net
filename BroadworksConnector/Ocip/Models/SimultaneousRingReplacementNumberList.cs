using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SimultaneousRingReplacementNumberList 
{
    private List<BroadworksConnector.Ocip.Models.SimultaneousRingNumber> _simultaneousRingNumber;

    [XmlElement(ElementName = "simultaneousRingNumber", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.SimultaneousRingNumber> SimultaneousRingNumber {
        get => _simultaneousRingNumber;
        set {
            SimultaneousRingNumberSpecified = true;
            _simultaneousRingNumber = value;
        }
    }

    [XmlIgnore]
    public bool SimultaneousRingNumberSpecified { get; set; }
}
}
