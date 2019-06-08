using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemCallingNameRetrievalGetResponse16sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
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

    [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = false, Namespace = "")]
    public string SipExternalDatabaseNetAddress {
        get => _sipExternalDatabaseNetAddress;
        set {
            SipExternalDatabaseNetAddressSpecified = true;
            _sipExternalDatabaseNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SipExternalDatabaseNetAddressSpecified { get; set; }
    private int _sipExternalDatabasePort;

    [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = false, Namespace = "")]
    public int SipExternalDatabasePort {
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

    [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = false, Namespace = "")]
    public string SoapExternalDatabaseNetAddress {
        get => _soapExternalDatabaseNetAddress;
        set {
            SoapExternalDatabaseNetAddressSpecified = true;
            _soapExternalDatabaseNetAddress = value;
        }
    }

    [XmlIgnore]
    public bool SoapExternalDatabaseNetAddressSpecified { get; set; }
    private bool _soapSupportsDNSSRV;

    [XmlElement(ElementName = "soapSupportsDNSSRV", IsNullable = false, Namespace = "")]
    public bool SoapSupportsDNSSRV {
        get => _soapSupportsDNSSRV;
        set {
            SoapSupportsDNSSRVSpecified = true;
            _soapSupportsDNSSRV = value;
        }
    }

    [XmlIgnore]
    public bool SoapSupportsDNSSRVSpecified { get; set; }
}
}
