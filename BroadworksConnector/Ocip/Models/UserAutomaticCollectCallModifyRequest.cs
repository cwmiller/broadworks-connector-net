using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserAutomaticCollectCallModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private string _userId;

    [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
    public string UserId {
        get => _userId;
        set {
            UserIdSpecified = true;
            _userId = value;
        }
    }

    [XmlIgnore]
    public bool UserIdSpecified { get; set; }
    private bool _enableAutomaticCollectCall;

    [XmlElement(ElementName = "enableAutomaticCollectCall", IsNullable = false, Namespace = "")]
    public bool EnableAutomaticCollectCall {
        get => _enableAutomaticCollectCall;
        set {
            EnableAutomaticCollectCallSpecified = true;
            _enableAutomaticCollectCall = value;
        }
    }

    [XmlIgnore]
    public bool EnableAutomaticCollectCallSpecified { get; set; }
}
}
