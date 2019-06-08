using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBwDiameterPeerAddRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance _instance;

    [XmlElement(ElementName = "instance", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.BwDiameterPeerInstance Instance {
        get => _instance;
        set {
            InstanceSpecified = true;
            _instance = value;
        }
    }

    [XmlIgnore]
    public bool InstanceSpecified { get; set; }
    private string _identity;

    [XmlElement(ElementName = "identity", IsNullable = false, Namespace = "")]
    public string Identity {
        get => _identity;
        set {
            IdentitySpecified = true;
            _identity = value;
        }
    }

    [XmlIgnore]
    public bool IdentitySpecified { get; set; }
    private string _ipAddress;

    [XmlElement(ElementName = "ipAddress", IsNullable = false, Namespace = "")]
    public string IpAddress {
        get => _ipAddress;
        set {
            IpAddressSpecified = true;
            _ipAddress = value;
        }
    }

    [XmlIgnore]
    public bool IpAddressSpecified { get; set; }
    private int _port;

    [XmlElement(ElementName = "port", IsNullable = false, Namespace = "")]
    public int Port {
        get => _port;
        set {
            PortSpecified = true;
            _port = value;
        }
    }

    [XmlIgnore]
    public bool PortSpecified { get; set; }
    private bool _enabled;

    [XmlElement(ElementName = "enabled", IsNullable = false, Namespace = "")]
    public bool Enabled {
        get => _enabled;
        set {
            EnabledSpecified = true;
            _enabled = value;
        }
    }

    [XmlIgnore]
    public bool EnabledSpecified { get; set; }
}
}