using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupNightForwardingModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode _nightForwarding;

    [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode NightForwarding {
        get => _nightForwarding;
        set {
            NightForwardingSpecified = true;
            _nightForwarding = value;
        }
    }

    [XmlIgnore]
    public bool NightForwardingSpecified { get; set; }
}
}
