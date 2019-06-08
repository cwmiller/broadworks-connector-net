using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBCCTAddOCIInterfaceAddressRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _interfaceNetAddress;

    [XmlElement(ElementName = "interfaceNetAddress", IsNullable = false, Namespace = "")]
    public string InterfaceNetAddress {
        get => _interfaceNetAddress;
        set {
            InterfaceNetAddressSpecified = true;
            _interfaceNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool InterfaceNetAddressSpecified { get; set; }
}
}
