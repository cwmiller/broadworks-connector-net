using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingReorderChargingFunctionElementServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private List<string> _orderedAddressList;

    [XmlElement(ElementName = "orderedAddressList", IsNullable = false, Namespace = "")]
    public List<string> OrderedAddressList {
        get => _orderedAddressList;
        set {
            OrderedAddressListSpecified = true;
            _orderedAddressList = value;
        }
    }

    [XmlIgnore]
    public bool OrderedAddressListSpecified { get; set; }
}
}
