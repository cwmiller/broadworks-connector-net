using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
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
    private bool _sendPushNotificationForClickToDial;

    [XmlElement(ElementName = "sendPushNotificationForClickToDial", IsNullable = false, Namespace = "")]
    public bool SendPushNotificationForClickToDial {
        get => _sendPushNotificationForClickToDial;
        set {
            SendPushNotificationForClickToDialSpecified = true;
            _sendPushNotificationForClickToDial = value;
        }
    }

    [XmlIgnore]
    public bool SendPushNotificationForClickToDialSpecified { get; set; }
}
}
