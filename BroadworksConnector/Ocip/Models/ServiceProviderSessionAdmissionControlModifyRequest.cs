using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private bool _restrictAggregateSessions;

    [XmlElement(ElementName = "restrictAggregateSessions", IsNullable = false, Namespace = "")]
    public bool RestrictAggregateSessions {
        get => _restrictAggregateSessions;
        set {
            RestrictAggregateSessionsSpecified = true;
            _restrictAggregateSessions = value;
        }
    }

    [XmlIgnore]
    public bool RestrictAggregateSessionsSpecified { get; set; }
    private int? _maxSessions;

    [XmlElement(ElementName = "maxSessions", IsNullable = true, Namespace = "")]
    public int? MaxSessions {
        get => _maxSessions;
        set {
            MaxSessionsSpecified = true;
            _maxSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxSessionsSpecified { get; set; }
    private int? _maxUserOriginatingSessions;

    [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = true, Namespace = "")]
    public int? MaxUserOriginatingSessions {
        get => _maxUserOriginatingSessions;
        set {
            MaxUserOriginatingSessionsSpecified = true;
            _maxUserOriginatingSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxUserOriginatingSessionsSpecified { get; set; }
    private int? _maxUserTerminatingSessions;

    [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = true, Namespace = "")]
    public int? MaxUserTerminatingSessions {
        get => _maxUserTerminatingSessions;
        set {
            MaxUserTerminatingSessionsSpecified = true;
            _maxUserTerminatingSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxUserTerminatingSessionsSpecified { get; set; }
    private bool _countIntraServiceProviderSessions;

    [XmlElement(ElementName = "countIntraServiceProviderSessions", IsNullable = false, Namespace = "")]
    public bool CountIntraServiceProviderSessions {
        get => _countIntraServiceProviderSessions;
        set {
            CountIntraServiceProviderSessionsSpecified = true;
            _countIntraServiceProviderSessions = value;
        }
    }

    [XmlIgnore]
    public bool CountIntraServiceProviderSessionsSpecified { get; set; }
}
}
