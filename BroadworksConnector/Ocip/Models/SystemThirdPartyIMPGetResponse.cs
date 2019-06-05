using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyIMPGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _serviceNetAddress;

    [XmlElement(ElementName = "serviceNetAddress", IsNullable = false, Namespace = "")]
    public string ServiceNetAddress {
        get => _serviceNetAddress;
        set {
            ServiceNetAddressSpecified = true;
            _serviceNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNetAddressSpecified { get; set; }
    private int _servicePort;

    [XmlElement(ElementName = "servicePort", IsNullable = false, Namespace = "")]
    public int ServicePort {
        get => _servicePort;
        set {
            ServicePortSpecified = true;
            _servicePort = value;
        }
    }

    [XmlIgnore]
    public bool ServicePortSpecified { get; set; }
}
}
