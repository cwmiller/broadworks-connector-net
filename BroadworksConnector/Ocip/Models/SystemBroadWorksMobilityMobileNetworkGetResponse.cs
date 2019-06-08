using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileNetworkGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _scfSignalingNetAddress;

    [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = false, Namespace = "")]
    public string ScfSignalingNetAddress {
        get => _scfSignalingNetAddress;
        set {
            ScfSignalingNetAddressSpecified = true;
            _scfSignalingNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool ScfSignalingNetAddressSpecified { get; set; }
    private int _scfSignalingPort;

    [XmlElement(ElementName = "scfSignalingPort", IsNullable = false, Namespace = "")]
    public int ScfSignalingPort {
        get => _scfSignalingPort;
        set {
            ScfSignalingPortSpecified = true;
            _scfSignalingPort = value;
        }
    }

    [XmlIgnore]
    public bool ScfSignalingPortSpecified { get; set; }
    private int _refreshPeriodSeconds;

    [XmlElement(ElementName = "refreshPeriodSeconds", IsNullable = false, Namespace = "")]
    public int RefreshPeriodSeconds {
        get => _refreshPeriodSeconds;
        set {
            RefreshPeriodSecondsSpecified = true;
            _refreshPeriodSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RefreshPeriodSecondsSpecified { get; set; }
    private int _maxConsecutiveFailures;

    [XmlElement(ElementName = "maxConsecutiveFailures", IsNullable = false, Namespace = "")]
    public int MaxConsecutiveFailures {
        get => _maxConsecutiveFailures;
        set {
            MaxConsecutiveFailuresSpecified = true;
            _maxConsecutiveFailures = value;
        }
    }

    [XmlIgnore]
    public bool MaxConsecutiveFailuresSpecified { get; set; }
    private int _maxResponseWaitTimeMilliseconds;

    [XmlElement(ElementName = "maxResponseWaitTimeMilliseconds", IsNullable = false, Namespace = "")]
    public int MaxResponseWaitTimeMilliseconds {
        get => _maxResponseWaitTimeMilliseconds;
        set {
            MaxResponseWaitTimeMillisecondsSpecified = true;
            _maxResponseWaitTimeMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool MaxResponseWaitTimeMillisecondsSpecified { get; set; }
    private bool _enableAnnouncementSuppression;

    [XmlElement(ElementName = "enableAnnouncementSuppression", IsNullable = false, Namespace = "")]
    public bool EnableAnnouncementSuppression {
        get => _enableAnnouncementSuppression;
        set {
            EnableAnnouncementSuppressionSpecified = true;
            _enableAnnouncementSuppression = value;
        }
    }

    [XmlIgnore]
    public bool EnableAnnouncementSuppressionSpecified { get; set; }
    private string _serviceAccessCodeListName;

    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = false, Namespace = "")]
    public string ServiceAccessCodeListName {
        get => _serviceAccessCodeListName;
        set {
            ServiceAccessCodeListNameSpecified = true;
            _serviceAccessCodeListName = value;
        }
    }

    [XmlIgnore]
    public bool ServiceAccessCodeListNameSpecified { get; set; }
}
}
