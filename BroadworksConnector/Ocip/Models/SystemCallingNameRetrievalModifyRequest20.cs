using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _triggerCNAMQueriesForAllNetworkCalls;

    [XmlElement(ElementName = "triggerCNAMQueriesForAllNetworkCalls", IsNullable = false, Namespace = "")]
    public bool TriggerCNAMQueriesForAllNetworkCalls {
        get => _triggerCNAMQueriesForAllNetworkCalls;
        set {
            TriggerCNAMQueriesForAllNetworkCallsSpecified = true;
            _triggerCNAMQueriesForAllNetworkCalls = value;
        }
    }

    [XmlIgnore]
    public bool TriggerCNAMQueriesForAllNetworkCallsSpecified { get; set; }
    private bool _triggerCNAMQueriesForGroupAndEnterpriseCalls;

    [XmlElement(ElementName = "triggerCNAMQueriesForGroupAndEnterpriseCalls", IsNullable = false, Namespace = "")]
    public bool TriggerCNAMQueriesForGroupAndEnterpriseCalls {
        get => _triggerCNAMQueriesForGroupAndEnterpriseCalls;
        set {
            TriggerCNAMQueriesForGroupAndEnterpriseCallsSpecified = true;
            _triggerCNAMQueriesForGroupAndEnterpriseCalls = value;
        }
    }

    [XmlIgnore]
    public bool TriggerCNAMQueriesForGroupAndEnterpriseCallsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol _queryProtocol;

    [XmlElement(ElementName = "queryProtocol", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol QueryProtocol {
        get => _queryProtocol;
        set {
            QueryProtocolSpecified = true;
            _queryProtocol = value;
        }
    }

    [XmlIgnore]
    public bool QueryProtocolSpecified { get; set; }
    private int _queryTimeoutMilliseconds;

    [XmlElement(ElementName = "queryTimeoutMilliseconds", IsNullable = false, Namespace = "")]
    public int QueryTimeoutMilliseconds {
        get => _queryTimeoutMilliseconds;
        set {
            QueryTimeoutMillisecondsSpecified = true;
            _queryTimeoutMilliseconds = value;
        }
    }

    [XmlIgnore]
    public bool QueryTimeoutMillisecondsSpecified { get; set; }
    private string _sipExternalDatabaseNetAddress;

    [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = true, Namespace = "")]
    public string SipExternalDatabaseNetAddress {
        get => _sipExternalDatabaseNetAddress;
        set {
            SipExternalDatabaseNetAddressSpecified = true;
            _sipExternalDatabaseNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SipExternalDatabaseNetAddressSpecified { get; set; }
    private int? _sipExternalDatabasePort;

    [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = true, Namespace = "")]
    public int? SipExternalDatabasePort {
        get => _sipExternalDatabasePort;
        set {
            SipExternalDatabasePortSpecified = true;
            _sipExternalDatabasePort = value;
        }
    }

    [XmlIgnore]
    public bool SipExternalDatabasePortSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.TransportProtocol _sipExternalDatabaseTransport;

    [XmlElement(ElementName = "sipExternalDatabaseTransport", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.TransportProtocol SipExternalDatabaseTransport {
        get => _sipExternalDatabaseTransport;
        set {
            SipExternalDatabaseTransportSpecified = true;
            _sipExternalDatabaseTransport = value;
        }
    }

    [XmlIgnore]
    public bool SipExternalDatabaseTransportSpecified { get; set; }
    private string _soapExternalDatabaseNetAddress;

    [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = true, Namespace = "")]
    public string SoapExternalDatabaseNetAddress {
        get => _soapExternalDatabaseNetAddress;
        set {
            SoapExternalDatabaseNetAddressSpecified = true;
            _soapExternalDatabaseNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SoapExternalDatabaseNetAddressSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity _callingNameSource;

    [XmlElement(ElementName = "callingNameSource", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity CallingNameSource {
        get => _callingNameSource;
        set {
            CallingNameSourceSpecified = true;
            _callingNameSource = value;
        }
    }

    [XmlIgnore]
    public bool CallingNameSourceSpecified { get; set; }
    private int _routeAdvanceTimer;

    [XmlElement(ElementName = "routeAdvanceTimer", IsNullable = false, Namespace = "")]
    public int RouteAdvanceTimer {
        get => _routeAdvanceTimer;
        set {
            RouteAdvanceTimerSpecified = true;
            _routeAdvanceTimer = value;
        }
    }

    [XmlIgnore]
    public bool RouteAdvanceTimerSpecified { get; set; }
    private int _retryFailedCNAMServerInterval;

    [XmlElement(ElementName = "retryFailedCNAMServerInterval", IsNullable = false, Namespace = "")]
    public int RetryFailedCNAMServerInterval {
        get => _retryFailedCNAMServerInterval;
        set {
            RetryFailedCNAMServerIntervalSpecified = true;
            _retryFailedCNAMServerInterval = value;
        }
    }

    [XmlIgnore]
    public bool RetryFailedCNAMServerIntervalSpecified { get; set; }
    private bool _ignoreRestrictedPresentationIndicator;

    [XmlElement(ElementName = "ignoreRestrictedPresentationIndicator", IsNullable = false, Namespace = "")]
    public bool IgnoreRestrictedPresentationIndicator {
        get => _ignoreRestrictedPresentationIndicator;
        set {
            IgnoreRestrictedPresentationIndicatorSpecified = true;
            _ignoreRestrictedPresentationIndicator = value;
        }
    }

    [XmlIgnore]
    public bool IgnoreRestrictedPresentationIndicatorSpecified { get; set; }
    private bool _supportsDNSSRV;

    [XmlElement(ElementName = "supportsDNSSRV", IsNullable = false, Namespace = "")]
    public bool SupportsDNSSRV {
        get => _supportsDNSSRV;
        set {
            SupportsDNSSRVSpecified = true;
            _supportsDNSSRV = value;
        }
    }

    [XmlIgnore]
    public bool SupportsDNSSRVSpecified { get; set; }
}
}
