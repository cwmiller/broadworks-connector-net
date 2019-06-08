using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class EnterpriseBroadWorksMobileManagerGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _mobileManagerId;

    [XmlElement(ElementName = "mobileManagerId", IsNullable = false, Namespace = "")]
    public string MobileManagerId {
        get => _mobileManagerId;
        set {
            MobileManagerIdSpecified = true;
            _mobileManagerId = value;
        }
    }

    [XmlIgnore]
    public bool MobileManagerIdSpecified { get; set; }
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
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _localToCarrier;

    [XmlElement(ElementName = "localToCarrier", IsNullable = false, Namespace = "")]
    public bool LocalToCarrier {
        get => _localToCarrier;
        set {
            LocalToCarrierSpecified = true;
            _localToCarrier = value;
        }
    }

    [XmlIgnore]
    public bool LocalToCarrierSpecified { get; set; }
    private string _deactivationReason;

    [XmlElement(ElementName = "deactivationReason", IsNullable = false, Namespace = "")]
    public string DeactivationReason {
        get => _deactivationReason;
        set {
            DeactivationReasonSpecified = true;
            _deactivationReason = value;
        }
    }

    [XmlIgnore]
    public bool DeactivationReasonSpecified { get; set; }
    private bool _maxTxPerSecondEnabled;

    [XmlElement(ElementName = "maxTxPerSecondEnabled", IsNullable = false, Namespace = "")]
    public bool MaxTxPerSecondEnabled {
        get => _maxTxPerSecondEnabled;
        set {
            MaxTxPerSecondEnabledSpecified = true;
            _maxTxPerSecondEnabled = value;
        }
    }

    [XmlIgnore]
    public bool MaxTxPerSecondEnabledSpecified { get; set; }
    private int _maxTxPerSecond;

    [XmlElement(ElementName = "maxTxPerSecond", IsNullable = false, Namespace = "")]
    public int MaxTxPerSecond {
        get => _maxTxPerSecond;
        set {
            MaxTxPerSecondSpecified = true;
            _maxTxPerSecond = value;
        }
    }

    [XmlIgnore]
    public bool MaxTxPerSecondSpecified { get; set; }
    private bool _tldnEnabled;

    [XmlElement(ElementName = "tldnEnabled", IsNullable = false, Namespace = "")]
    public bool TldnEnabled {
        get => _tldnEnabled;
        set {
            TldnEnabledSpecified = true;
            _tldnEnabled = value;
        }
    }

    [XmlIgnore]
    public bool TldnEnabledSpecified { get; set; }
    private bool _genericNumberEnabled;

    [XmlElement(ElementName = "genericNumberEnabled", IsNullable = false, Namespace = "")]
    public bool GenericNumberEnabled {
        get => _genericNumberEnabled;
        set {
            GenericNumberEnabledSpecified = true;
            _genericNumberEnabled = value;
        }
    }

    [XmlIgnore]
    public bool GenericNumberEnabledSpecified { get; set; }
    private bool _mobileStateCheckEnabled;

    [XmlElement(ElementName = "mobileStateCheckEnabled", IsNullable = false, Namespace = "")]
    public bool MobileStateCheckEnabled {
        get => _mobileStateCheckEnabled;
        set {
            MobileStateCheckEnabledSpecified = true;
            _mobileStateCheckEnabled = value;
        }
    }

    [XmlIgnore]
    public bool MobileStateCheckEnabledSpecified { get; set; }
    private bool _locationBasedServicesEnabled;

    [XmlElement(ElementName = "locationBasedServicesEnabled", IsNullable = false, Namespace = "")]
    public bool LocationBasedServicesEnabled {
        get => _locationBasedServicesEnabled;
        set {
            LocationBasedServicesEnabledSpecified = true;
            _locationBasedServicesEnabled = value;
        }
    }

    [XmlIgnore]
    public bool LocationBasedServicesEnabledSpecified { get; set; }
}
}
