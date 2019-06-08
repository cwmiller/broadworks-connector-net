using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserCallCenterGetAvailableDNISListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadWorksConnector.Ocip.Models.DNISKey> _availableDNIS;

    [XmlElement(ElementName = "availableDNIS", IsNullable = false, Namespace = "")]
    public List<BroadWorksConnector.Ocip.Models.DNISKey> AvailableDNIS {
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
