using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Enhanced Call Logs.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// The following elements are only used in AS data mode:
    /// isSendEnabled
    /// server1NetAddress
    /// server1SendPort
    /// server1RetrievePort
    /// server2NetAddress
    /// server2SendPort
    /// server2RetrievePort
    /// sharedSecret
    /// retransmissionDelayMilliSeconds
    /// maxTransmissions
    /// soapTimeoutSeconds
    /// useDBS
    /// eclQueryApplicationURL
    /// eclQueryDataRepositoryURL
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:30671""}]")]
    public class SystemEnhancedCallLogsModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _isSendEnabled;

        [XmlElement(ElementName = "isSendEnabled", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        public bool? IsSendEnabled
        {
            get => _isSendEnabled;
            set
            {
                IsSendEnabledSpecified = (value != null);
                _isSendEnabled = value;
            }
        }

        [XmlIgnore]
        protected bool IsSendEnabledSpecified { get; set; }

        protected string _server1NetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "server1NetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Server1NetAddress
        {
            get => _server1NetAddress;
            set
            {
                Server1NetAddressSpecified = true;
                _server1NetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool Server1NetAddressSpecified { get; set; }

        protected int? _server1SendPort;

        [XmlElement(ElementName = "server1SendPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? Server1SendPort
        {
            get => _server1SendPort;
            set
            {
                Server1SendPortSpecified = (value != null);
                _server1SendPort = value;
            }
        }

        [XmlIgnore]
        protected bool Server1SendPortSpecified { get; set; }

        protected int? _server1RetrievePort;

        [XmlElement(ElementName = "server1RetrievePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? Server1RetrievePort
        {
            get => _server1RetrievePort;
            set
            {
                Server1RetrievePortSpecified = (value != null);
                _server1RetrievePort = value;
            }
        }

        [XmlIgnore]
        protected bool Server1RetrievePortSpecified { get; set; }

        protected string _server2NetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "server2NetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinLength(1)]
        [MaxLength(80)]
        public string Server2NetAddress
        {
            get => _server2NetAddress;
            set
            {
                Server2NetAddressSpecified = true;
                _server2NetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool Server2NetAddressSpecified { get; set; }

        protected int? _server2SendPort;

        [XmlElement(ElementName = "server2SendPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int? Server2SendPort
        {
            get => _server2SendPort;
            set
            {
                Server2SendPortSpecified = (value != null);
                _server2SendPort = value;
            }
        }

        [XmlIgnore]
        protected bool Server2SendPortSpecified { get; set; }

        protected int? _server2RetrievePort;

        [XmlElement(ElementName = "server2RetrievePort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int? Server2RetrievePort
        {
            get => _server2RetrievePort;
            set
            {
                Server2RetrievePortSpecified = (value != null);
                _server2RetrievePort = value;
            }
        }

        [XmlIgnore]
        protected bool Server2RetrievePortSpecified { get; set; }

        protected string _sharedSecret;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "sharedSecret", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinLength(1)]
        [MaxLength(80)]
        public string SharedSecret
        {
            get => _sharedSecret;
            set
            {
                SharedSecretSpecified = true;
                _sharedSecret = value;
            }
        }

        [XmlIgnore]
        protected bool SharedSecretSpecified { get; set; }

        protected int? _retransmissionDelayMilliSeconds;

        [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(200)]
        [MaxInclusive(5000)]
        public int? RetransmissionDelayMilliSeconds
        {
            get => _retransmissionDelayMilliSeconds;
            set
            {
                RetransmissionDelayMilliSecondsSpecified = (value != null);
                _retransmissionDelayMilliSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool RetransmissionDelayMilliSecondsSpecified { get; set; }

        protected int? _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int? MaxTransmissions
        {
            get => _maxTransmissions;
            set
            {
                MaxTransmissionsSpecified = (value != null);
                _maxTransmissions = value;
            }
        }

        [XmlIgnore]
        protected bool MaxTransmissionsSpecified { get; set; }

        protected int? _soapTimeoutSeconds;

        [XmlElement(ElementName = "soapTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int? SoapTimeoutSeconds
        {
            get => _soapTimeoutSeconds;
            set
            {
                SoapTimeoutSecondsSpecified = (value != null);
                _soapTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool SoapTimeoutSecondsSpecified { get; set; }

        protected bool? _useDBS;

        [XmlElement(ElementName = "useDBS", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        public bool? UseDBS
        {
            get => _useDBS;
            set
            {
                UseDBSSpecified = (value != null);
                _useDBS = value;
            }
        }

        [XmlIgnore]
        protected bool UseDBSSpecified { get; set; }

        protected int? _maxNonPagedResponseSize;

        [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinInclusive(100)]
        [MaxInclusive(1000)]
        public int? MaxNonPagedResponseSize
        {
            get => _maxNonPagedResponseSize;
            set
            {
                MaxNonPagedResponseSizeSpecified = (value != null);
                _maxNonPagedResponseSize = value;
            }
        }

        [XmlIgnore]
        protected bool MaxNonPagedResponseSizeSpecified { get; set; }

        protected string _eclQueryApplicationURL;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "eclQueryApplicationURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EclQueryApplicationURL
        {
            get => _eclQueryApplicationURL;
            set
            {
                EclQueryApplicationURLSpecified = true;
                _eclQueryApplicationURL = value;
            }
        }

        [XmlIgnore]
        protected bool EclQueryApplicationURLSpecified { get; set; }

        protected string _eclQueryDataRepositoryURL;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "eclQueryDataRepositoryURL", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:30671")]
        [MinLength(1)]
        [MaxLength(256)]
        public string EclQueryDataRepositoryURL
        {
            get => _eclQueryDataRepositoryURL;
            set
            {
                EclQueryDataRepositoryURLSpecified = true;
                _eclQueryDataRepositoryURL = value;
            }
        }

        [XmlIgnore]
        protected bool EclQueryDataRepositoryURLSpecified { get; set; }

    }
}
