using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderBroadWorksMobilityGetResponse21sp1V2 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private BroadWorksConnector.Ocip.Models.BroadWorksMobilityServiceProviderSettingLevel _useSettingLevel;

    [XmlElement(ElementName = "useSettingLevel", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.BroadWorksMobilityServiceProviderSettingLevel UseSettingLevel {
        get => _useSettingLevel;
        set {
            UseSettingLevelSpecified = true;
            _useSettingLevel = value;
        }
    }

    [XmlIgnore]
    public bool UseSettingLevelSpecified { get; set; }
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
}
}
