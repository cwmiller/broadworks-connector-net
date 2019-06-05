using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerVoiceMessagingGroupModifyRequest : BroadworksConnector.Ocip.Models.C.OCIRequest
{
    private string _resellerId;

    [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
    public string ResellerId {
        get => _resellerId;
        set {
            ResellerIdSpecified = true;
            _resellerId = value;
        }
    }

    [XmlIgnore]
    public bool ResellerIdSpecified { get; set; }
    private string _deliveryFromAddress;

    [XmlElement(ElementName = "deliveryFromAddress", IsNullable = true, Namespace = "")]
    public string DeliveryFromAddress {
        get => _deliveryFromAddress;
        set {
            DeliveryFromAddressSpecified = true;
            _deliveryFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DeliveryFromAddressSpecified { get; set; }
    private string _notificationFromAddress;

    [XmlElement(ElementName = "notificationFromAddress", IsNullable = true, Namespace = "")]
    public string NotificationFromAddress {
        get => _notificationFromAddress;
        set {
            NotificationFromAddressSpecified = true;
            _notificationFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool NotificationFromAddressSpecified { get; set; }
    private string _voicePortalLockoutFromAddress;

    [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = true, Namespace = "")]
    public string VoicePortalLockoutFromAddress {
        get => _voicePortalLockoutFromAddress;
        set {
            VoicePortalLockoutFromAddressSpecified = true;
            _voicePortalLockoutFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalLockoutFromAddressSpecified { get; set; }
}
}
