using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemThirdPartyIMPModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceNetAddress;

    [XmlElement(ElementName = "serviceNetAddress", IsNullable = true, Namespace = "")]
    public string ServiceNetAddress {
        get => _serviceNetAddress;
        set {
            ServiceNetAddressSpecified = true;
            _serviceNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool ServiceNetAddressSpecified { get; set; }
    private int? _servicePort;

    [XmlElement(ElementName = "servicePort", IsNullable = true, Namespace = "")]
    public int? ServicePort {
        get => _servicePort;
        set {
            ServicePortSpecified = true;
            _servicePort = value;
        }
    }

    [XmlIgnore]
    public bool ServicePortSpecified { get; set; }
    private string _boshURL;

    [XmlElement(ElementName = "boshURL", IsNullable = true, Namespace = "")]
    public string BoshURL {
        get => _boshURL;
        set {
            BoshURLSpecified = true;
            _boshURL = value;
        }
    }

    [XmlIgnore]
    public bool BoshURLSpecified { get; set; }
}
}