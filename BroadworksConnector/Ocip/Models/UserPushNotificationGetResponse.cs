using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserPushNotificationGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "sendPushNotificationForClickToDial", IsNullable = false)]
    public bool SendPushNotificationForClickToDial { get; set; }
 }
}
