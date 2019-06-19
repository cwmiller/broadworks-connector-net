using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ResellerVoiceMessagingGroupGetRequest.
    /// <see cref="ResellerVoiceMessagingGroupGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:336""}]")]
    public class ResellerVoiceMessagingGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _deliveryFromAddress;

        [XmlElement(ElementName = "deliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:336")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DeliveryFromAddress
        {
            get => _deliveryFromAddress;
            set
            {
                DeliveryFromAddressSpecified = true;
                _deliveryFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool DeliveryFromAddressSpecified { get; set; }

        private string _notificationFromAddress;

        [XmlElement(ElementName = "notificationFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:336")]
        [MinLength(1)]
        [MaxLength(80)]
        public string NotificationFromAddress
        {
            get => _notificationFromAddress;
            set
            {
                NotificationFromAddressSpecified = true;
                _notificationFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool NotificationFromAddressSpecified { get; set; }

        private string _voicePortalLockoutFromAddress;

        [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:336")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoicePortalLockoutFromAddress
        {
            get => _voicePortalLockoutFromAddress;
            set
            {
                VoicePortalLockoutFromAddressSpecified = true;
                _voicePortalLockoutFromAddress = value;
            }
        }

        [XmlIgnore]
        public bool VoicePortalLockoutFromAddressSpecified { get; set; }

    }
}
