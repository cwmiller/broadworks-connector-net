using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIReportingParametersGetRequest22.
    /// Contains a list of system OCI Reporting parameters.
    /// <see cref="SystemOCIReportingParametersGetRequest22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""7f663d5135470c33ca64b0eed3c3aa0c:12729""}]")]
    public class SystemOCIReportingParametersGetResponse22 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12729")]
        [MinInclusive(1025)]
        [MaxInclusive(65535)]
        public int ServerPort
        {
            get => _serverPort;
            set
            {
                ServerPortSpecified = true;
                _serverPort = value;
            }
        }

        [XmlIgnore]
        public bool ServerPortSpecified { get; set; }

        private bool _enableConnectionPing;

        [XmlElement(ElementName = "enableConnectionPing", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12729")]
        public bool EnableConnectionPing
        {
            get => _enableConnectionPing;
            set
            {
                EnableConnectionPingSpecified = true;
                _enableConnectionPing = value;
            }
        }

        [XmlIgnore]
        public bool EnableConnectionPingSpecified { get; set; }

        private int _connectionPingIntervalSeconds;

        [XmlElement(ElementName = "connectionPingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12729")]
        [MinInclusive(1)]
        [MaxInclusive(86400)]
        public int ConnectionPingIntervalSeconds
        {
            get => _connectionPingIntervalSeconds;
            set
            {
                ConnectionPingIntervalSecondsSpecified = true;
                _connectionPingIntervalSeconds = value;
            }
        }

        [XmlIgnore]
        public bool ConnectionPingIntervalSecondsSpecified { get; set; }

        private bool _alterPasswords;

        [XmlElement(ElementName = "alterPasswords", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12729")]
        public bool AlterPasswords
        {
            get => _alterPasswords;
            set
            {
                AlterPasswordsSpecified = true;
                _alterPasswords = value;
            }
        }

        [XmlIgnore]
        public bool AlterPasswordsSpecified { get; set; }

        private bool _enablePublicIdentityReporting;

        [XmlElement(ElementName = "enablePublicIdentityReporting", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12729")]
        public bool EnablePublicIdentityReporting
        {
            get => _enablePublicIdentityReporting;
            set
            {
                EnablePublicIdentityReportingSpecified = true;
                _enablePublicIdentityReporting = value;
            }
        }

        [XmlIgnore]
        public bool EnablePublicIdentityReportingSpecified { get; set; }

        private bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Group(@"7f663d5135470c33ca64b0eed3c3aa0c:12729")]
        public bool Secure
        {
            get => _secure;
            set
            {
                SecureSpecified = true;
                _secure = value;
            }
        }

        [XmlIgnore]
        public bool SecureSpecified { get; set; }

    }
}
