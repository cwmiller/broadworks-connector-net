using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to ServiceProviderVoiceMessagingGroupGetRequest.
    /// Contains the service provider's or enterprise's voice messaging settings.
    /// <see cref="ServiceProviderVoiceMessagingGroupGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:389""}]")]
    public class ServiceProviderVoiceMessagingGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private string _deliveryFromAddress;

        [XmlElement(ElementName = "deliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:389")]
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
        protected bool DeliveryFromAddressSpecified { get; set; }

        private string _notificationFromAddress;

        [XmlElement(ElementName = "notificationFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:389")]
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
        protected bool NotificationFromAddressSpecified { get; set; }

        private string _voicePortalLockoutFromAddress;

        [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:389")]
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
        protected bool VoicePortalLockoutFromAddressSpecified { get; set; }

        private bool _useSystemDefaultDeliveryFromAddress;

        [XmlElement(ElementName = "useSystemDefaultDeliveryFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:389")]
        public bool UseSystemDefaultDeliveryFromAddress
        {
            get => _useSystemDefaultDeliveryFromAddress;
            set
            {
                UseSystemDefaultDeliveryFromAddressSpecified = true;
                _useSystemDefaultDeliveryFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemDefaultDeliveryFromAddressSpecified { get; set; }

        private bool _useSystemDefaultNotificationFromAddress;

        [XmlElement(ElementName = "useSystemDefaultNotificationFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:389")]
        public bool UseSystemDefaultNotificationFromAddress
        {
            get => _useSystemDefaultNotificationFromAddress;
            set
            {
                UseSystemDefaultNotificationFromAddressSpecified = true;
                _useSystemDefaultNotificationFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemDefaultNotificationFromAddressSpecified { get; set; }

        private bool _useSystemDefaultVoicePortalLockoutFromAddress;

        [XmlElement(ElementName = "useSystemDefaultVoicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:389")]
        public bool UseSystemDefaultVoicePortalLockoutFromAddress
        {
            get => _useSystemDefaultVoicePortalLockoutFromAddress;
            set
            {
                UseSystemDefaultVoicePortalLockoutFromAddressSpecified = true;
                _useSystemDefaultVoicePortalLockoutFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool UseSystemDefaultVoicePortalLockoutFromAddressSpecified { get; set; }

    }
}
