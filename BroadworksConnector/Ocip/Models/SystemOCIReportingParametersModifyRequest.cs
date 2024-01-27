using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify OCI Reporting system parameters.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:14013""}]")]
    public class SystemOCIReportingParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected int _serverPort;

        [XmlElement(ElementName = "serverPort", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14013")]
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

        protected bool _enableConnectionPing;

        [XmlElement(ElementName = "enableConnectionPing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14013")]
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

        protected int _connectionPingIntervalSeconds;

        [XmlElement(ElementName = "connectionPingIntervalSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14013")]
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

        protected bool _alterPasswords;

        [XmlElement(ElementName = "alterPasswords", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14013")]
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

        protected bool _enablePublicIdentityReporting;

        [XmlElement(ElementName = "enablePublicIdentityReporting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14013")]
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
        protected bool EnablePublicIdentityReportingSpecified { get; set; }

        protected bool _secure;

        [XmlElement(ElementName = "secure", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"da582a1f8028404e70d260cf1f891033:14013")]
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
        protected bool SecureSpecified { get; set; }

    }
}
