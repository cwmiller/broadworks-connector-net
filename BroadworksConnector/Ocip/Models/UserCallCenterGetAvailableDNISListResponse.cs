using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetAvailableDNISListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.DNISKey> _availableDNIS;

    [XmlElement(ElementName = "availableDNIS", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.DNISKey> AvailableDNIS {
        get => _availableDNIS;
        set {
            AvailableDNISSpecified = true;
            _availableDNIS = value;
        }
    }

    [XmlIgnore]
    public bool AvailableDNISSpecified { get; set; }
}
}
