using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCLIDDeliveryPrefixGetListResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private List<BroadworksConnector.Ocip.Models.CLIDDeliveryPrefix> _prefix;

    [XmlElement(ElementName = "prefix", IsNullable = false, Namespace = "")]
    public List<BroadworksConnector.Ocip.Models.CLIDDeliveryPrefix> Prefix {
        get => _prefix;
        set {
            PrefixSpecified = true;
            _prefix = value;
        }
    }

    [XmlIgnore]
    public bool PrefixSpecified { get; set; }
}
}
