using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ServiceProviderVoiceMessagingGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "serviceProviderId", IsNullable = false)]
    public string ServiceProviderId { get; set; }
    [XmlElement(ElementName = "deliveryFromAddress", IsNullable = true)]
    public string DeliveryFromAddress { get; set; }
    [XmlElement(ElementName = "notificationFromAddress", IsNullable = true)]
    public string NotificationFromAddress { get; set; }
    [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = true)]
    public string VoicePortalLockoutFromAddress { get; set; }
    [XmlElement(ElementName = "useSystemDefaultDeliveryFromAddress", IsNullable = false)]
    public bool UseSystemDefaultDeliveryFromAddress { get; set; }
    [XmlElement(ElementName = "useSystemDefaultNotificationFromAddress", IsNullable = false)]
    public bool UseSystemDefaultNotificationFromAddress { get; set; }
    [XmlElement(ElementName = "useSystemDefaultVoicePortalLockoutFromAddress", IsNullable = false)]
    public bool UseSystemDefaultVoicePortalLockoutFromAddress { get; set; }
 }
}
