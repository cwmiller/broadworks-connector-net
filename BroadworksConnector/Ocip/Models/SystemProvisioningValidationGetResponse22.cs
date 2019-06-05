using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemProvisioningValidationGetResponse22 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private bool _isNetworkServerQueryActive;

    [XmlElement(ElementName = "isNetworkServerQueryActive", IsNullable = false, Namespace = "")]
    public bool IsNetworkServerQueryActive {
        get => _isNetworkServerQueryActive;
        set {
            IsNetworkServerQueryActiveSpecified = true;
            _isNetworkServerQueryActive = value;
        }
    }

    [XmlIgnore]
    public bool IsNetworkServerQueryActiveSpecified { get; set; }
    private int _timeoutSeconds;

    [XmlElement(ElementName = "timeoutSeconds", IsNullable = false, Namespace = "")]
    public int TimeoutSeconds {
        get => _timeoutSeconds;
        set {
            TimeoutSecondsSpecified = true;
            _timeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool TimeoutSecondsSpecified { get; set; }
    private bool _denyMobilityNumberAsRedirectionDestination;

    [XmlElement(ElementName = "denyMobilityNumberAsRedirectionDestination", IsNullable = false, Namespace = "")]
    public bool DenyMobilityNumberAsRedirectionDestination {
        get => _denyMobilityNumberAsRedirectionDestination;
        set {
            DenyMobilityNumberAsRedirectionDestinationSpecified = true;
            _denyMobilityNumberAsRedirectionDestination = value;
        }
    }

    [XmlIgnore]
    public bool DenyMobilityNumberAsRedirectionDestinationSpecified { get; set; }
    private bool _denyEnterpriseNumberAsNetworkLocationDestination;

    [XmlElement(ElementName = "denyEnterpriseNumberAsNetworkLocationDestination", IsNullable = false, Namespace = "")]
    public bool DenyEnterpriseNumberAsNetworkLocationDestination {
        get => _denyEnterpriseNumberAsNetworkLocationDestination;
        set {
            DenyEnterpriseNumberAsNetworkLocationDestinationSpecified = true;
            _denyEnterpriseNumberAsNetworkLocationDestination = value;
        }
    }

    [XmlIgnore]
    public bool DenyEnterpriseNumberAsNetworkLocationDestinationSpecified { get; set; }
}
}
