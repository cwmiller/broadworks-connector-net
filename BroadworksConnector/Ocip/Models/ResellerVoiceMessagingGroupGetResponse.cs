using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class ResellerVoiceMessagingGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
    private string _deliveryFromAddress;

    [XmlElement(ElementName = "deliveryFromAddress", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "notificationFromAddress", IsNullable = false, Namespace = "")]
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

    [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
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
