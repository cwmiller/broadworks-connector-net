using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityModifyRequest17sp4 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _enableLocationServices;

    [XmlElement(ElementName = "enableLocationServices", IsNullable = false, Namespace = "")]
    public bool EnableLocationServices {
        get => _enableLocationServices;
        set {
            EnableLocationServicesSpecified = true;
            _enableLocationServices = value;
        }
    }

    [XmlIgnore]
    public bool EnableLocationServicesSpecified { get; set; }
    private bool _enableMSRNLookup;

    [XmlElement(ElementName = "enableMSRNLookup", IsNullable = false, Namespace = "")]
    public bool EnableMSRNLookup {
        get => _enableMSRNLookup;
        set {
            EnableMSRNLookupSpecified = true;
            _enableMSRNLookup = value;
        }
    }

    [XmlIgnore]
    public bool EnableMSRNLookupSpecified { get; set; }
    private bool _enableMobileStateChecking;

    [XmlElement(ElementName = "enableMobileStateChecking", IsNullable = false, Namespace = "")]
    public bool EnableMobileStateChecking {
        get => _enableMobileStateChecking;
        set {
            EnableMobileStateCheckingSpecified = true;
            _enableMobileStateChecking = value;
        }
    }

    [XmlIgnore]
    public bool EnableMobileStateCheckingSpecified { get; set; }
    private bool _denyCallOriginations;

    [XmlElement(ElementName = "denyCallOriginations", IsNullable = false, Namespace = "")]
    public bool DenyCallOriginations {
        get => _denyCallOriginations;
        set {
            DenyCallOriginationsSpecified = true;
            _denyCallOriginations = value;
        }
    }

    [XmlIgnore]
    public bool DenyCallOriginationsSpecified { get; set; }
    private bool _denyCallTerminations;

    [XmlElement(ElementName = "denyCallTerminations", IsNullable = false, Namespace = "")]
    public bool DenyCallTerminations {
        get => _denyCallTerminations;
        set {
            DenyCallTerminationsSpecified = true;
            _denyCallTerminations = value;
        }
    }

    [XmlIgnore]
    public bool DenyCallTerminationsSpecified { get; set; }
    private int _imrnTimeoutMilliseconds;

    [XmlElement(ElementName = "imrnTimeoutMilliseconds", IsNullable = false, Namespace = "")]
    public int ImrnTimeoutMilliseconds {
        get => _imrnTimeoutMilliseconds;
        set {
            ImrnTimeoutMillisecondsSpecified = true;
            _imrnTimeoutMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool ImrnTimeoutMillisecondsSpecified { get; set; }
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
}
}
