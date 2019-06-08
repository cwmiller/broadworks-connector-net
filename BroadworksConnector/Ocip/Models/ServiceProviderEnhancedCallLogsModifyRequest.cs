using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderEnhancedCallLogsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _serviceProviderId;

    [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
    public string ServiceProviderId {
        get => _serviceProviderId;
        set {
            ServiceProviderIdSpecified = true;
            _serviceProviderId = value;
        }
    }

    [XmlIgnore]
    public bool ServiceProviderIdSpecified { get; set; }
    private int _maxLoggedCalls;

    [XmlElement(ElementName = "maxLoggedCalls", IsNullable = false, Namespace = "")]
    public int MaxLoggedCalls {
        get => _maxLoggedCalls;
        set {
            MaxLoggedCallsSpecified = true;
            _maxLoggedCalls = value;
        }
    }

    [XmlIgnore]
    public bool MaxLoggedCallsSpecified { get; set; }
    private int _callExpirationDays;

    [XmlElement(ElementName = "callExpirationDays", IsNullable = false, Namespace = "")]
    public int CallExpirationDays {
        get => _callExpirationDays;
        set {
            CallExpirationDaysSpecified = true;
            _callExpirationDays = value;
        }
    }

    [XmlIgnore]
    public bool CallExpirationDaysSpecified { get; set; }
}
}
