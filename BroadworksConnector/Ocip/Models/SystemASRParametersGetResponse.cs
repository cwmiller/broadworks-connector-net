using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemASRParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _maxTransmissions;

    [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
    public int MaxTransmissions {
        get => _maxTransmissions;
        set {
            MaxTransmissionsSpecified = true;
            _maxTransmissions = value;
        }
    }

    [XmlIgnore]
    public bool MaxTransmissionsSpecified { get; set; }
    private int _retransmissionDelayMilliSeconds;

    [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
    public int RetransmissionDelayMilliSeconds {
        get => _retransmissionDelayMilliSeconds;
        set {
            RetransmissionDelayMilliSecondsSpecified = true;
            _retransmissionDelayMilliSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RetransmissionDelayMilliSecondsSpecified { get; set; }
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
}
}
