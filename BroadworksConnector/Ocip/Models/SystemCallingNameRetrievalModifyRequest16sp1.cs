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
    /// Replaced by: SystemCallingNameRetrievalModifyRequest20
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// <see cref="SystemCallingNameRetrievalModifyRequest20"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:21186""}]")]
    public class SystemCallingNameRetrievalModifyRequest16sp1 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _triggerCNAMQueriesForAllNetworkCalls;

        [XmlElement(ElementName = "triggerCNAMQueriesForAllNetworkCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private bool _triggerCNAMQueriesForGroupAndEnterpriseCalls;

        [XmlElement(ElementName = "triggerCNAMQueriesForGroupAndEnterpriseCalls", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private BroadWorksConnector.Ocip.Models.CallingNameRetrievalQueryProtocol _queryProtocol;

        [XmlElement(ElementName = "queryProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private int _queryTimeoutMilliseconds;

        [XmlElement(ElementName = "queryTimeoutMilliseconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private string _sipExternalDatabaseNetAddress;

        [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private int? _sipExternalDatabasePort;

        [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private BroadWorksConnector.Ocip.Models.TransportProtocol _sipExternalDatabaseTransport;

        [XmlElement(ElementName = "sipExternalDatabaseTransport", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
        public BroadWorksConnector.Ocip.Models.TransportProtocol SipExternalDatabaseTransport
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

        private string _soapExternalDatabaseNetAddress;

        [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

        private bool _soapSupportsDNSSRV;

        [XmlElement(ElementName = "soapSupportsDNSSRV", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
        public bool SoapSupportsDNSSRV
        {
            get => _soapSupportsDNSSRV;
            set
            {
                SoapSupportsDNSSRVSpecified = true;
                _soapSupportsDNSSRV = value;
            }
        }

        [XmlIgnore]
        protected bool SoapSupportsDNSSRVSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity _callingNameSource;

        [XmlElement(ElementName = "callingNameSource", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:21186")]
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

    }
}
