using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemShInterfaceParametersModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _hssRealm;

    [XmlElement(ElementName = "hssRealm", IsNullable = true, Namespace = "")]
    public string HssRealm {
        get => _hssRealm;
        set {
            HssRealmSpecified = true;
            _hssRealm = value;
        }
    }

    [XmlIgnore]
    public bool HssRealmSpecified { get; set; }
    private int _requestTimeoutSeconds;

    [XmlElement(ElementName = "requestTimeoutSeconds", IsNullable = false, Namespace = "")]
    public int RequestTimeoutSeconds {
        get => _requestTimeoutSeconds;
        set {
            RequestTimeoutSecondsSpecified = true;
            _requestTimeoutSeconds = value;
        }
    }

    [XmlIgnore]
    public bool RequestTimeoutSecondsSpecified { get; set; }
    private int _publicIdentityRefreshDelaySeconds;

    [XmlElement(ElementName = "publicIdentityRefreshDelaySeconds", IsNullable = false, Namespace = "")]
    public int PublicIdentityRefreshDelaySeconds {
        get => _publicIdentityRefreshDelaySeconds;
        set {
            PublicIdentityRefreshDelaySecondsSpecified = true;
            _publicIdentityRefreshDelaySeconds = value;
        }
    }

    [XmlIgnore]
    public bool PublicIdentityRefreshDelaySecondsSpecified { get; set; }
}
}
