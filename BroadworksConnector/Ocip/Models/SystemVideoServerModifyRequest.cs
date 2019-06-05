using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVideoServerModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _netAddress;

    [XmlElement(ElementName = "netAddress", IsNullable = false, Namespace = "")]
    public string NetAddress {
        get => _netAddress;
        set {
            NetAddressSpecified = true;
            _netAddress = value;
        }
    }

    [XmlIgnore]
    public bool NetAddressSpecified { get; set; }
    private int? _port;

    [XmlElement(ElementName = "port", IsNullable = true, Namespace = "")]
    public int? Port {
        get => _port;
        set {
            PortSpecified = true;
            _port = value;
        }
    }

    [XmlIgnore]
    public bool PortSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TransportProtocol _transportProtocol;

    [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TransportProtocol TransportProtocol {
        get => _transportProtocol;
        set {
            TransportProtocolSpecified = true;
            _transportProtocol = value;
        }
    }

    [XmlIgnore]
    public bool TransportProtocolSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = true, Namespace = "")]
    public string Description {
        get => _description;
        set {
            DescriptionSpecified = true;
            _description = value;
        }
    }

    [XmlIgnore]
    public bool DescriptionSpecified { get; set; }
}
}
