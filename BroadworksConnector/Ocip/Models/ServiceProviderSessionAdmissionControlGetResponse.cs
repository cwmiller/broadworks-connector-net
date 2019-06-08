using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderSessionAdmissionControlGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private int _maxSessions;

    [XmlElement(ElementName = "maxSessions", IsNullable = false, Namespace = "")]
    public int MaxSessions {
        get => _maxSessions;
        set {
            MaxSessionsSpecified = true;
            _maxSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxSessionsSpecified { get; set; }
    private int _maxUserOriginatingSessions;

    [XmlElement(ElementName = "maxUserOriginatingSessions", IsNullable = false, Namespace = "")]
    public int MaxUserOriginatingSessions {
        get => _maxUserOriginatingSessions;
        set {
            MaxUserOriginatingSessionsSpecified = true;
            _maxUserOriginatingSessions = value;
        }
    }

    [XmlIgnore]
    public bool MaxUserOriginatingSessionsSpecified { get; set; }
    private int _maxUserTerminatingSessions;

    [XmlElement(ElementName = "maxUserTerminatingSessions", IsNullable = false, Namespace = "")]
    public int MaxUserTerminatingSessions {
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
