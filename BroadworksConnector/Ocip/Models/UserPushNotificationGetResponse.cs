using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
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
