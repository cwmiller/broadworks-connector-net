using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCountryCodeAddRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _countryCode;

    [XmlElement(ElementName = "countryCode", IsNullable = false, Namespace = "")]
    public string CountryCode {
        get => _countryCode;
        set {
            CountryCodeSpecified = true;
            _countryCode = value;
        }
    }

    [XmlIgnore]
    public bool CountryCodeSpecified { get; set; }
    private string _countryName;

    [XmlElement(ElementName = "countryName", IsNullable = false, Namespace = "")]
    public string CountryName {
        get => _countryName;
        set {
            CountryNameSpecified = true;
            _countryName = value;
        }
    }

    [XmlIgnore]
    public bool CountryNameSpecified { get; set; }
    private int _ringPeriodMilliseconds;

    [XmlElement(ElementName = "ringPeriodMilliseconds", IsNullable = false, Namespace = "")]
    public int RingPeriodMilliseconds {
        get => _ringPeriodMilliseconds;
        set {
            RingPeriodMillisecondsSpecified = true;
            _ringPeriodMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool RingPeriodMillisecondsSpecified { get; set; }
    private int _offHookWarningTimerSeconds;

    [XmlElement(ElementName = "offHookWarningTimerSeconds", IsNullable = false, Namespace = "")]
    public int OffHookWarningTimerSeconds {
        get => _offHookWarningTimerSeconds;
        set {
            OffHookWarningTimerSecondsSpecified = true;
            _offHookWarningTimerSeconds = value;
        }
    }

    [XmlIgnore]
    public bool OffHookWarningTimerSecondsSpecified { get; set; }
    private bool _enableNationalPrefix;

    [XmlElement(ElementName = "enableNationalPrefix", IsNullable = false, Namespace = "")]
    public bool EnableNationalPrefix {
        get => _enableNationalPrefix;
        set {
            EnableNationalPrefixSpecified = true;
            _enableNationalPrefix = value;
        }
    }

    [XmlIgnore]
    public bool EnableNationalPrefixSpecified { get; set; }
    private string _nationalPrefix;

    [XmlElement(ElementName = "nationalPrefix", IsNullable = false, Namespace = "")]
    public string NationalPrefix {
        get => _nationalPrefix;
        set {
            NationalPrefixSpecified = true;
            _nationalPrefix = value;
        }
    }

    [XmlIgnore]
    public bool NationalPrefixSpecified { get; set; }
    private int _maxCallWaitingTones;

    [XmlElement(ElementName = "maxCallWaitingTones", IsNullable = false, Namespace = "")]
    public int MaxCallWaitingTones {
        get => _maxCallWaitingTones;
        set {
            MaxCallWaitingTonesSpecified = true;
            _maxCallWaitingTones = value;
        }
    }

    [XmlIgnore]
    public bool MaxCallWaitingTonesSpecified { get; set; }
    private int _timeBetweenCallWaitingTonesMilliseconds;

    [XmlElement(ElementName = "timeBetweenCallWaitingTonesMilliseconds", IsNullable = false, Namespace = "")]
    public int TimeBetweenCallWaitingTonesMilliseconds {
        get => _timeBetweenCallWaitingTonesMilliseconds;
        set {
            TimeBetweenCallWaitingTonesMillisecondsSpecified = true;
            _timeBetweenCallWaitingTonesMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeBetweenCallWaitingTonesMillisecondsSpecified { get; set; }
    private bool _disableNationalPrefixForOffNetCalls;

    [XmlElement(ElementName = "disableNationalPrefixForOffNetCalls", IsNullable = false, Namespace = "")]
    public bool DisableNationalPrefixForOffNetCalls {
        get => _disableNationalPrefixForOffNetCalls;
        set {
            DisableNationalPrefixForOffNetCallsSpecified = true;
            _disableNationalPrefixForOffNetCalls = value;
        }
    }

    [XmlIgnore]
    public bool DisableNationalPrefixForOffNetCallsSpecified { get; set; }
}
}
