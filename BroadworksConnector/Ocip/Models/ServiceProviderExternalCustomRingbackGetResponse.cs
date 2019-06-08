using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderExternalCustomRingbackGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _prefixDigits;

    [XmlElement(ElementName = "prefixDigits", IsNullable = false, Namespace = "")]
    public string PrefixDigits {
        get => _prefixDigits;
        set {
            PrefixDigitsSpecified = true;
            _prefixDigits = value;
        }
    }

    [XmlIgnore]
    public bool PrefixDigitsSpecified { get; set; }
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
    private int _timeoutSeconds;

    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
    public int TimeoutSeconds {
        get => _timeoutSeconds;
        set {
            TimeoutSecondsSpecified = true;
            _timeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeoutSecondsSpecified { get; set; }
}
}
