using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingReorderChargingFunctionElementServerRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
