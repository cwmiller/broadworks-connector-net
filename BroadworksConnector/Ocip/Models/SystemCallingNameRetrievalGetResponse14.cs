using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalGetResponse14 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _queryTimerMilliSeconds;

    [XmlElement(ElementName = "queryTimerMilliSeconds", IsNullable = false, Namespace = "")]
    public int QueryTimerMilliSeconds {
        get => _queryTimerMilliSeconds;
        set {
            QueryTimerMilliSecondsSpecified = true;
            _queryTimerMilliSeconds = value;
        }
    }

    [XmlIgnore]
    public bool QueryTimerMilliSecondsSpecified { get; set; }
    private string _serverNetAddress;

    [XmlElement(ElementName = "serverNetAddress", IsNullable = false, Namespace = "")]
    public string ServerNetAddress {
        get => _serverNetAddress;
        set {
            ServerNetAddressSpecified = true;
            _serverNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool ServerNetAddressSpecified { get; set; }
    private int _serverPort;

    [XmlElement(ElementName = "serverPort", IsNullable = false, Namespace = "")]
    public int ServerPort {
        get => _serverPort;
        set {
            ServerPortSpecified = true;
            _serverPort = value;
        }
    }

    [XmlIgnore]
    public bool ServerPortSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.TransportProtocol _serverTransportProtocol;

    [XmlElement(ElementName = "serverTransportProtocol", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.TransportProtocol ServerTransportProtocol {
        get => _serverTransportProtocol;
        set {
            ServerTransportProtocolSpecified = true;
            _serverTransportProtocol = value;
        }
    }

    [XmlIgnore]
    public bool ServerTransportProtocolSpecified { get; set; }
}
}
