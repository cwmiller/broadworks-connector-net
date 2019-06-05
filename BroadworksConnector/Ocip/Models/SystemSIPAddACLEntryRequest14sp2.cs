using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSIPAddACLEntryRequest14sp2 : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.SIPACLTransportProtocol _transportProtocol;

    [XmlElement(ElementName = "transportProtocol", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.SIPACLTransportProtocol TransportProtocol {
        get => _transportProtocol;
        set {
            TransportProtocolSpecified = true;
            _transportProtocol = value;
        }
    }

    [XmlIgnore]
    public bool TransportProtocolSpecified { get; set; }
    private string _description;

    [XmlElement(ElementName = "description", IsNullable = false, Namespace = "")]
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
