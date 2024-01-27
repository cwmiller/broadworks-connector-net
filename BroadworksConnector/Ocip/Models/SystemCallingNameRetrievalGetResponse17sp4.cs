using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemCallingNameRetrievalGetRequest17sp4.
    /// 
    /// Replaced by: SystemCallingNameRetrievalGetResponse24
    /// <see cref="SystemCallingNameRetrievalGetRequest17sp4"/>
    /// <see cref="SystemCallingNameRetrievalGetResponse24"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:21879""}]")]
    public class SystemCallingNameRetrievalGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected bool _triggerCNAMQueriesForAllNetworkCalls;

        [XmlElement(ElementName = "triggerCNAMQueriesForAllNetworkCalls", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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

        [XmlElement(ElementName = "sipExternalDatabaseNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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

        protected int _sipExternalDatabasePort;

        [XmlElement(ElementName = "sipExternalDatabasePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int SipExternalDatabasePort
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

        protected BroadWorksConnector.Ocip.Models.TransportProtocol _sipExternalDatabaseTransport;

        [XmlElement(ElementName = "sipExternalDatabaseTransport", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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

        protected string _soapExternalDatabaseNetAddress;

        [XmlElement(ElementName = "soapExternalDatabaseNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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

        protected bool _soapSupportsDNSSRV;

        [XmlElement(ElementName = "soapSupportsDNSSRV", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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

        protected BroadWorksConnector.Ocip.Models.CallingNameRetrievalSourceIdentity _callingNameSource;

        [XmlElement(ElementName = "callingNameSource", IsNullable = false, Namespace = "")]
        [Group(@"d8f04177e438f303b41c211e518706bf:21879")]
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
