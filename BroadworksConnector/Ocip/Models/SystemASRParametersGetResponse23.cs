using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemASRParametersGetResponse23 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
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
    private bool _enableCustomMessageControl;

    [XmlElement(ElementName = "enableCustomMessageControl", IsNullable = false, Namespace = "")]
    public bool EnableCustomMessageControl {
        get => _enableCustomMessageControl;
        set {
            EnableCustomMessageControlSpecified = true;
            _enableCustomMessageControl = value;
        }
    }

    [XmlIgnore]
    public bool EnableCustomMessageControlSpecified { get; set; }
    private int _customNumberOfUsersPerMessage;

    [XmlElement(ElementName = "customNumberOfUsersPerMessage", IsNullable = false, Namespace = "")]
    public int CustomNumberOfUsersPerMessage {
        get => _customNumberOfUsersPerMessage;
        set {
            CustomNumberOfUsersPerMessageSpecified = true;
            _customNumberOfUsersPerMessage = value;
        }
    }

    [XmlIgnore]
    public bool CustomNumberOfUsersPerMessageSpecified { get; set; }
    private int _customMessageIntervalMilliseconds;

    [XmlElement(ElementName = "customMessageIntervalMilliseconds", IsNullable = false, Namespace = "")]
    public int CustomMessageIntervalMilliseconds {
        get => _customMessageIntervalMilliseconds;
        set {
            CustomMessageIntervalMillisecondsSpecified = true;
            _customMessageIntervalMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool CustomMessageIntervalMillisecondsSpecified { get; set; }
}
}
