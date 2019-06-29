using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemOCIReportingParametersGetListRequest.
    /// Contains a list of system OCI Reporting parameters.
    /// <see cref="SystemOCIReportingParametersGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""ab0042aa512abc10edb3c55e4b416b0b:5369""}]")]
    public class SystemOCIReportingParametersGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private int _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5369")]
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
        protected bool ServerPortSpecified { get; set; }

        private bool _enableConnectionPing;

        [XmlElement(ElementName = "enableConnectionPing", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5369")]
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
        protected bool EnableConnectionPingSpecified { get; set; }

        private int _connectionPingIntervalSeconds;

        [XmlElement(ElementName = "connectionPingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5369")]
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
        protected bool ConnectionPingIntervalSecondsSpecified { get; set; }

        private bool _alterPasswords;

        [XmlElement(ElementName = "alterPasswords", IsNullable = false, Namespace = "")]
        [Group(@"ab0042aa512abc10edb3c55e4b416b0b:5369")]
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
        protected bool AlterPasswordsSpecified { get; set; }

    }
}
