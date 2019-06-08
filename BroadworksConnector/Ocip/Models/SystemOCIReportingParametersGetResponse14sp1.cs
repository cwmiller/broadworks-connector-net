using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemOCIReportingParametersGetResponse14sp1 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _serverPort;

    [XmlElement(ElementName = "serverPort", IsNullable = false, Namespace = "")]
    public int ServerPort {
        get => _serverPort;
        set {
            ServerPortSpecified = true;
            _serverPort = value;
        }
    }

    [XmlIgnore]
    public bool ServerPortSpecified { get; set; }
    private bool _enableConnectionPing;

    [XmlElement(ElementName = "enableConnectionPing", IsNullable = false, Namespace = "")]
    public bool EnableConnectionPing {
        get => _enableConnectionPing;
        set {
            EnableConnectionPingSpecified = true;
            _enableConnectionPing = value;
        }
    }

    [XmlIgnore]
    public bool EnableConnectionPingSpecified { get; set; }
    private int _connectionPingIntervalSeconds;

    [XmlElement(ElementName = "connectionPingIntervalSeconds", IsNullable = false, Namespace = "")]
    public int ConnectionPingIntervalSeconds {
        get => _connectionPingIntervalSeconds;
        set {
            ConnectionPingIntervalSecondsSpecified = true;
            _connectionPingIntervalSeconds = value;
        }
    }

    [XmlIgnore]
    public bool ConnectionPingIntervalSecondsSpecified { get; set; }
    private bool _alterPasswords;

    [XmlElement(ElementName = "alterPasswords", IsNullable = false, Namespace = "")]
    public bool AlterPasswords {
        get => _alterPasswords;
        set {
            AlterPasswordsSpecified = true;
            _alterPasswords = value;
        }
    }

    [XmlIgnore]
    public bool AlterPasswordsSpecified { get; set; }
    private bool _enablePublicIdentityReporting;

    [XmlElement(ElementName = "enablePublicIdentityReporting", IsNullable = false, Namespace = "")]
    public bool EnablePublicIdentityReporting {
        get => _enablePublicIdentityReporting;
        set {
            EnablePublicIdentityReportingSpecified = true;
            _enablePublicIdentityReporting = value;
        }
    }

    [XmlIgnore]
    public bool EnablePublicIdentityReportingSpecified { get; set; }
}
}
