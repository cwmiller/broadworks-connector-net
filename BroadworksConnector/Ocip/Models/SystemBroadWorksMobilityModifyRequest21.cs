using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemBroadWorksMobilityModifyRequest21 : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _enableInternalCLIDDelivery;

    [XmlElement(ElementName = "enableInternalCLIDDelivery", IsNullable = false, Namespace = "")]
    public bool EnableInternalCLIDDelivery {
        get => _enableInternalCLIDDelivery;
        set {
            EnableInternalCLIDDeliverySpecified = true;
            _enableInternalCLIDDelivery = value;
        }
    }

    [XmlIgnore]
    public bool EnableInternalCLIDDeliverySpecified { get; set; }
    private bool _includeRedirectForMobilityTermination;

    [XmlElement(ElementName = "includeRedirectForMobilityTermination", IsNullable = false, Namespace = "")]
    public bool IncludeRedirectForMobilityTermination {
        get => _includeRedirectForMobilityTermination;
        set {
            IncludeRedirectForMobilityTerminationSpecified = true;
            _includeRedirectForMobilityTermination = value;
        }
    }

    [XmlIgnore]
    public bool IncludeRedirectForMobilityTerminationSpecified { get; set; }
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
    private bool _enableEnhancedUnreachableStateChecking;

    [XmlElement(ElementName = "enableEnhancedUnreachableStateChecking", IsNullable = false, Namespace = "")]
    public bool EnableEnhancedUnreachableStateChecking {
        get => _enableEnhancedUnreachableStateChecking;
        set {
            EnableEnhancedUnreachableStateCheckingSpecified = true;
            _enableEnhancedUnreachableStateChecking = value;
        }
    }

    [XmlIgnore]
    public bool EnableEnhancedUnreachableStateCheckingSpecified { get; set; }
    private bool _enableNetworkCallBarringStatusCheck;

    [XmlElement(ElementName = "enableNetworkCallBarringStatusCheck", IsNullable = false, Namespace = "")]
    public bool EnableNetworkCallBarringStatusCheck {
        get => _enableNetworkCallBarringStatusCheck;
        set {
            EnableNetworkCallBarringStatusCheckSpecified = true;
            _enableNetworkCallBarringStatusCheck = value;
        }
    }

    [XmlIgnore]
    public bool EnableNetworkCallBarringStatusCheckSpecified { get; set; }
    private string _networkTranslationIndex;

    [XmlElement(ElementName = "networkTranslationIndex", IsNullable = true, Namespace = "")]
    public string NetworkTranslationIndex {
        get => _networkTranslationIndex;
        set {
            NetworkTranslationIndexSpecified = true;
            _networkTranslationIndex = value;
        }
    }

    [XmlIgnore]
    public bool NetworkTranslationIndexSpecified { get; set; }
}
}
