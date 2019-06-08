using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemSMDIParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _enableSMDI;

    [XmlElement(ElementName = "enableSMDI", IsNullable = false, Namespace = "")]
    public bool EnableSMDI {
        get => _enableSMDI;
        set {
            EnableSMDISpecified = true;
            _enableSMDI = value;
        }
    }

    [XmlIgnore]
    public bool EnableSMDISpecified { get; set; }
    private int _listeningPort;

    [XmlElement(ElementName = "listeningPort", IsNullable = false, Namespace = "")]
    public int ListeningPort {
        get => _listeningPort;
        set {
            ListeningPortSpecified = true;
            _listeningPort = value;
        }
    }

    [XmlIgnore]
    public bool ListeningPortSpecified { get; set; }
    private int _maxConnections;

    [XmlElement(ElementName = "maxConnections", IsNullable = false, Namespace = "")]
    public int MaxConnections {
        get => _maxConnections;
        set {
            MaxConnectionsSpecified = true;
            _maxConnections = value;
        }
    }

    [XmlIgnore]
    public bool MaxConnectionsSpecified { get; set; }
}
}
