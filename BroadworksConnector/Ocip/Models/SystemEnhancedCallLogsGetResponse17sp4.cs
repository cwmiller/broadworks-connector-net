using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsGetRequest17sp4.
    /// The following elements are only used in AS data mode:
    /// isSendEnabled
    /// server1SendPort
    /// server1RetrievePort
    /// server2SendPort
    /// server2RetrievePort
    /// retransmissionDelayMilliSeconds
    /// maxTransmissions
    /// soapTimeoutSeconds
    /// useDBS
    /// The following elements are only used in AS data mode and not returned in XS data mode:
    /// server1NetAddress
    /// server2NetAddress
    /// sharedSecret
    /// Replaced by:SystemEnhancedCallLogsGetResponse20sp1 in AS data mode
    /// <see cref="SystemEnhancedCallLogsGetRequest17sp4"/>
    /// <see cref="SystemEnhancedCallLogsGetResponse20sp1"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:2964""}]")]
    public class SystemEnhancedCallLogsGetResponse17sp4 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isSendEnabled;

        [XmlElement(ElementName = "isSendEnabled", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        public bool IsSendEnabled
        {
            get => _isSendEnabled;
            set
            {
                IsSendEnabledSpecified = true;
                _isSendEnabled = value;
            }
        }

        [XmlIgnore]
        public bool IsSendEnabledSpecified { get; set; }

        private string _server1NetAddress;

        [XmlElement(ElementName = "server1NetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
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
        public bool Server1NetAddressSpecified { get; set; }

        private int _server1SendPort;

        [XmlElement(ElementName = "server1SendPort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int Server1SendPort
        {
            get => _server1SendPort;
            set
            {
                Server1SendPortSpecified = true;
                _server1SendPort = value;
            }
        }

        [XmlIgnore]
        public bool Server1SendPortSpecified { get; set; }

        private int _server1RetrievePort;

        [XmlElement(ElementName = "server1RetrievePort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int Server1RetrievePort
        {
            get => _server1RetrievePort;
            set
            {
                Server1RetrievePortSpecified = true;
                _server1RetrievePort = value;
            }
        }

        [XmlIgnore]
        public bool Server1RetrievePortSpecified { get; set; }

        private string _server2NetAddress;

        [XmlElement(ElementName = "server2NetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
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
        public bool Server2NetAddressSpecified { get; set; }

        private int _server2SendPort;

        [XmlElement(ElementName = "server2SendPort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int Server2SendPort
        {
            get => _server2SendPort;
            set
            {
                Server2SendPortSpecified = true;
                _server2SendPort = value;
            }
        }

        [XmlIgnore]
        public bool Server2SendPortSpecified { get; set; }

        private int _server2RetrievePort;

        [XmlElement(ElementName = "server2RetrievePort", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(1)]
        [MaxInclusive(65535)]
        public int Server2RetrievePort
        {
            get => _server2RetrievePort;
            set
            {
                Server2RetrievePortSpecified = true;
                _server2RetrievePort = value;
            }
        }

        [XmlIgnore]
        public bool Server2RetrievePortSpecified { get; set; }

        private string _sharedSecret;

        [XmlElement(ElementName = "sharedSecret", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
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
        public bool SharedSecretSpecified { get; set; }

        private int _retransmissionDelayMilliSeconds;

        [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(200)]
        [MaxInclusive(5000)]
        public int RetransmissionDelayMilliSeconds
        {
            get => _retransmissionDelayMilliSeconds;
            set
            {
                RetransmissionDelayMilliSecondsSpecified = true;
                _retransmissionDelayMilliSeconds = value;
            }
        }

        [XmlIgnore]
        public bool RetransmissionDelayMilliSecondsSpecified { get; set; }

        private int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int MaxTransmissions
        {
            get => _maxTransmissions;
            set
            {
                MaxTransmissionsSpecified = true;
                _maxTransmissions = value;
            }
        }

        [XmlIgnore]
        public bool MaxTransmissionsSpecified { get; set; }

        private int _soapTimeoutSeconds;

        [XmlElement(ElementName = "soapTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(1)]
        [MaxInclusive(120)]
        public int SoapTimeoutSeconds
        {
            get => _soapTimeoutSeconds;
            set
            {
                SoapTimeoutSecondsSpecified = true;
                _soapTimeoutSeconds = value;
            }
        }

        [XmlIgnore]
        public bool SoapTimeoutSecondsSpecified { get; set; }

        private bool _useDBS;

        [XmlElement(ElementName = "useDBS", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        public bool UseDBS
        {
            get => _useDBS;
            set
            {
                UseDBSSpecified = true;
                _useDBS = value;
            }
        }

        [XmlIgnore]
        public bool UseDBSSpecified { get; set; }

        private int _maxNonPagedResponseSize;

        [XmlElement(ElementName = "maxNonPagedResponseSize", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:2964")]
        [MinInclusive(100)]
        [MaxInclusive(1000)]
        public int MaxNonPagedResponseSize
        {
            get => _maxNonPagedResponseSize;
            set
            {
                MaxNonPagedResponseSizeSpecified = true;
                _maxNonPagedResponseSize = value;
            }
        }

        [XmlIgnore]
        public bool MaxNonPagedResponseSizeSpecified { get; set; }

    }
}
