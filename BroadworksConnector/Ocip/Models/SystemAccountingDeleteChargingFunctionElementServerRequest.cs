using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAccountingDeleteChargingFunctionElementServerRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _address;

    [XmlElement(ElementName = "address", IsNullable = false, Namespace = "")]
    public string Address {
        get => _address;
        set {
            AddressSpecified = true;
            _address = value;
        }
    }

    [XmlIgnore]
    public bool AddressSpecified { get; set; }
}
}
