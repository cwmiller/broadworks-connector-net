using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityMobileNetworkModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _name;

    [XmlElement(ElementName = "name", IsNullable = false, Namespace = "")]
    public string Name {
        get => _name;
        set {
            NameSpecified = true;
            _name = value;
        }
    }

    [XmlIgnore]
    public bool NameSpecified { get; set; }
    private string _newName;

    [XmlElement(ElementName = "newName", IsNullable = false, Namespace = "")]
    public string NewName {
        get => _newName;
        set {
            NewNameSpecified = true;
            _newName = value;
        }
    }

    [XmlIgnore]
    public bool NewNameSpecified { get; set; }
    private string _scfSignalingNetAddress;

    [XmlElement(ElementName = "scfSignalingNetAddress", IsNullable = true, Namespace = "")]
    public string ScfSignalingNetAddress {
        get => _scfSignalingNetAddress;
        set {
            ScfSignalingNetAddressSpecified = true;
            _scfSignalingNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool ScfSignalingNetAddressSpecified { get; set; }
    private int? _scfSignalingPort;

    [XmlElement(ElementName = "scfSignalingPort", IsNullable = true, Namespace = "")]
    public int? ScfSignalingPort {
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

    [XmlElement(ElementName = "serviceAccessCodeListName", IsNullable = true, Namespace = "")]
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
