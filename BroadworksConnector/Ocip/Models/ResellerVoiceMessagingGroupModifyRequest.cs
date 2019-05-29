using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerVoiceMessagingGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    [XmlElement(ElementName = "resellerId", IsNullable = false)]
    public string ResellerId { get; set; }
    [XmlElement(ElementName = "deliveryFromAddress", IsNullable = true)]
    public string DeliveryFromAddress { get; set; }
    [XmlElement(ElementName = "notificationFromAddress", IsNullable = true)]
    public string NotificationFromAddress { get; set; }
    [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = true)]
    public string VoicePortalLockoutFromAddress { get; set; }
 }
}
