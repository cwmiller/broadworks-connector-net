using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityGetResponse21sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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
    private int _imrnTimeoutMillisecnds;

    [XmlElement(ElementName = "imrnTimeoutMillisecnds", IsNullable = false, Namespace = "")]
    public int ImrnTimeoutMillisecnds {
        get => _imrnTimeoutMillisecnds;
        set {
            ImrnTimeoutMillisecndsSpecified = true;
            _imrnTimeoutMillisecnds = value;
        }
    }

    [XmlIgnore]
    public bool ImrnTimeoutMillisecndsSpecified { get; set; }
    private bool _enableInternalCLIDDeliveryAccessLocations;

    [XmlElement(ElementName = "enableInternalCLIDDeliveryAccessLocations", IsNullable = false, Namespace = "")]
    public bool EnableInternalCLIDDeliveryAccessLocations {
        get => _enableInternalCLIDDeliveryAccessLocations;
        set {
            EnableInternalCLIDDeliveryAccessLocationsSpecified = true;
            _enableInternalCLIDDeliveryAccessLocations = value;
        }
    }

    [XmlIgnore]
    public bool EnableInternalCLIDDeliveryAccessLocationsSpecified { get; set; }
}
}
