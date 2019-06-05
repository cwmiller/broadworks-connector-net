using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserGroupNightForwardingModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
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
    private BroadworksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode _nightForwarding;

    [XmlElement(ElementName = "nightForwarding", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.GroupNightForwardingUserServiceActivationMode NightForwarding {
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
