using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "deliveryFromAddress", IsNullable = false)]
    public string DeliveryFromAddress { get; set; }
    [XmlElement(ElementName = "notificationFromAddress", IsNullable = false)]
    public string NotificationFromAddress { get; set; }
    [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = false)]
    public string VoicePortalLockoutFromAddress { get; set; }
    [XmlElement(ElementName = "useSystemDefaultDeliveryFromAddress", IsNullable = false)]
    public bool UseSystemDefaultDeliveryFromAddress { get; set; }
    [XmlElement(ElementName = "useSystemDefaultNotificationFromAddress", IsNullable = false)]
    public bool UseSystemDefaultNotificationFromAddress { get; set; }
    [XmlElement(ElementName = "useSystemDefaultVoicePortalLockoutFromAddress", IsNullable = false)]
    public bool UseSystemDefaultVoicePortalLockoutFromAddress { get; set; }
 }
}
