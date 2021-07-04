using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemEnhancedCallLogsGetRequest.
    /// <see cref="SystemEnhancedCallLogsGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:26502""}]")]
    public class SystemEnhancedCallLogsGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isSendEnabled;

        [XmlElement(ElementName = "isSendEnabled", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool IsSendEnabledSpecified { get; set; }

        private string _server1NetAddress;

        [XmlElement(ElementName = "server1NetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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

        private int _server1SendPort;

        [XmlElement(ElementName = "server1SendPort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool Server1SendPortSpecified { get; set; }

        private int _server1RetrievePort;

        [XmlElement(ElementName = "server1RetrievePort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool Server1RetrievePortSpecified { get; set; }

        private string _server2NetAddress;

        [XmlElement(ElementName = "server2NetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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

        private int _server2SendPort;

        [XmlElement(ElementName = "server2SendPort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool Server2SendPortSpecified { get; set; }

        private int _server2RetrievePort;

        [XmlElement(ElementName = "server2RetrievePort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool Server2RetrievePortSpecified { get; set; }

        private string _sharedSecret;

        [XmlElement(ElementName = "sharedSecret", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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

        private int _retransmissionDelayMilliSeconds;

        [XmlElement(ElementName = "retransmissionDelayMilliSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool RetransmissionDelayMilliSecondsSpecified { get; set; }

        private int _maxTransmissions;

        [XmlElement(ElementName = "maxTransmissions", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool MaxTransmissionsSpecified { get; set; }

        private int _soapTimeoutSeconds;

        [XmlElement(ElementName = "soapTimeoutSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:26502")]
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
        protected bool SoapTimeoutSecondsSpecified { get; set; }

    }
}
