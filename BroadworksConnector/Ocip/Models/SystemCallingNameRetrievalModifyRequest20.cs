using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modifies the system's calling name retrieval attributes.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following attributes are only used in AS data mode and ignored in XS data mode:
    /// - triggerCNAMQueriesForAllNetworkCalls
    /// - triggerCNAMQueriesForGroupAndEnterpriseCalls
    /// - queryProtocol
    /// - queryTimeoutMilliseconds
    /// - sipExternalDatabaseNetAddress
    /// - sipExternalDatabasePort
    /// - sipExternalDatabaseTransport
    /// - soapExternalDatabaseNetAddress
    /// - callingNameSource
    /// - routeAdvanceTimer
    /// - retryFailedCNAMServerInterval
    /// - ignoreRestrictedPresentationIndicator
    /// - supportsDNSSRV
    /// 
    /// The following attributes are only used in XS data mode and ignored in AS data mode:
    /// - callFilteringProvisioningEnabled
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ba51f415ebda0240287c719bc767eadf:104""}]")]
    public class SystemCallingNameRetrievalModifyRequest20 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool _triggerCNAMQueriesForAllNetworkCalls;

        [XmlElement(ElementName = "triggerCNAMQueriesForAllNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public bool TriggerCNAMQueriesForAllNetworkCalls
        {
            get => _triggerCNAMQueriesForAllNetworkCalls;
            set
            {
                TriggerCNAMQueriesForAllNetworkCallsSpecified = true;
                _triggerCNAMQueriesForAllNetworkCalls = value;
            }
        }

        [XmlIgnore]
        protected bool TriggerCNAMQueriesForAllNetworkCallsSpecified { get; set; }

        protected bool _triggerCNAMQueriesForGroupAndEnterpriseCalls;

        [XmlElement(ElementName = "triggerCNAMQueriesForGroupAndEnterpriseCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public bool TriggerCNAMQueriesForGroupAndEnterpriseCalls
        {
            get => _triggerCNAMQueriesForGroupAndEnterpriseCalls;
            set
            {
                TriggerCNAMQueriesForGroupAndEnterpriseCallsSpecified = true;
                _triggerCNAMQueriesForGroupAndEnterpriseCalls = value;
            }
        }

        [XmlIgnore]
        protected bool TriggerCNAMQueriesForGroupAndEnterpriseCallsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol _queryProtocol;

        [XmlElement(ElementName = "queryProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public BroadWorksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol QueryProtocol
        {
            get => _queryProtocol;
            set
            {
                QueryProtocolSpecified = true;
                _queryProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool QueryProtocolSpecified { get; set; }

        protected int _queryTimeoutMilliseconds;

        [XmlElement(ElementName = "queryTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        [MinInclusive(100)]
        [MaxInclusive(10000)]
        public int QueryTimeoutMilliseconds
        {
            get => _queryTimeoutMilliseconds;
            set
            {
                QueryTimeoutMillisecondsSpecified = true;
                _queryTimeoutMilliseconds = value;
            }
        }

        [XmlIgnore]
        protected bool QueryTimeoutMillisecondsSpecified { get; set; }

        protected string _sipExternalDatabaseNetAddress;

        [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SipExternalDatabaseNetAddress
        {
            get => _sipExternalDatabaseNetAddress;
            set
            {
                SipExternalDatabaseNetAddressSpecified = true;
                _sipExternalDatabaseNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SipExternalDatabaseNetAddressSpecified { get; set; }

        protected int? _sipExternalDatabasePort;

        [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? SipExternalDatabasePort
        {
            get => _sipExternalDatabasePort;
            set
            {
                SipExternalDatabasePortSpecified = true;
                _sipExternalDatabasePort = value;
            }
        }

        [XmlIgnore]
        protected bool SipExternalDatabasePortSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol _sipExternalDatabaseTransport;

        [XmlElement(ElementName = "sipExternalDatabaseTransport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public BroadWorksConnector.Ocip.Models.ExtendedTransportProtocol SipExternalDatabaseTransport
        {
            get => _sipExternalDatabaseTransport;
            set
            {
                SipExternalDatabaseTransportSpecified = true;
                _sipExternalDatabaseTransport = value;
            }
        }

        [XmlIgnore]
        protected bool SipExternalDatabaseTransportSpecified { get; set; }

        protected string _soapExternalDatabaseNetAddress;

        [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SoapExternalDatabaseNetAddress
        {
            get => _soapExternalDatabaseNetAddress;
            set
            {
                SoapExternalDatabaseNetAddressSpecified = true;
                _soapExternalDatabaseNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool SoapExternalDatabaseNetAddressSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity _callingNameSource;

        [XmlElement(ElementName = "callingNameSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public BroadWorksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity CallingNameSource
        {
            get => _callingNameSource;
            set
            {
                CallingNameSourceSpecified = true;
                _callingNameSource = value;
            }
        }

        [XmlIgnore]
        protected bool CallingNameSourceSpecified { get; set; }

        protected int _routeAdvanceTimer;

        [XmlElement(ElementName = "routeAdvanceTimer", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        [MinInclusive(100)]
        [MaxInclusive(2000)]
        public int RouteAdvanceTimer
        {
            get => _routeAdvanceTimer;
            set
            {
                RouteAdvanceTimerSpecified = true;
                _routeAdvanceTimer = value;
            }
        }

        [XmlIgnore]
        protected bool RouteAdvanceTimerSpecified { get; set; }

        protected int _retryFailedCNAMServerInterval;

        [XmlElement(ElementName = "retryFailedCNAMServerInterval", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        [MinInclusive(0)]
        [MaxInclusive(604800)]
        public int RetryFailedCNAMServerInterval
        {
            get => _retryFailedCNAMServerInterval;
            set
            {
                RetryFailedCNAMServerIntervalSpecified = true;
                _retryFailedCNAMServerInterval = value;
            }
        }

        [XmlIgnore]
        protected bool RetryFailedCNAMServerIntervalSpecified { get; set; }

        protected bool _ignoreRestrictedPresentationIndicator;

        [XmlElement(ElementName = "ignoreRestrictedPresentationIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public bool IgnoreRestrictedPresentationIndicator
        {
            get => _ignoreRestrictedPresentationIndicator;
            set
            {
                IgnoreRestrictedPresentationIndicatorSpecified = true;
                _ignoreRestrictedPresentationIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool IgnoreRestrictedPresentationIndicatorSpecified { get; set; }

        protected bool _supportsDNSSRV;

        [XmlElement(ElementName = "supportsDNSSRV", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public bool SupportsDNSSRV
        {
            get => _supportsDNSSRV;
            set
            {
                SupportsDNSSRVSpecified = true;
                _supportsDNSSRV = value;
            }
        }

        [XmlIgnore]
        protected bool SupportsDNSSRVSpecified { get; set; }

        protected bool _callFilteringProvisioningEnabled;

        [XmlElement(ElementName = "callFilteringProvisioningEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ba51f415ebda0240287c719bc767eadf:104")]
        public bool CallFilteringProvisioningEnabled
        {
            get => _callFilteringProvisioningEnabled;
            set
            {
                CallFilteringProvisioningEnabledSpecified = true;
                _callFilteringProvisioningEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool CallFilteringProvisioningEnabledSpecified { get; set; }

    }
}
