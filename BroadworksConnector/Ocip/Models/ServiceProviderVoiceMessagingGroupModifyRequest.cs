using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify a service provider's or enterprise's voice messaging settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:478""}]")]
    public class ServiceProviderVoiceMessagingGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
        [MinLength(1)]
        [MaxLength(30)]
        public string ServiceProviderId
        {
            get => _serviceProviderId;
            set
            {
                ServiceProviderIdSpecified = true;
                _serviceProviderId = value;
            }
        }

        [XmlIgnore]
        protected bool ServiceProviderIdSpecified { get; set; }

        protected string _deliveryFromAddress;

        [XmlElement(ElementName = "deliveryFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
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

        protected string _notificationFromAddress;

        [XmlElement(ElementName = "notificationFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
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

        protected string _voicePortalLockoutFromAddress;

        [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
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

        protected bool _useSystemDefaultDeliveryFromAddress;

        [XmlElement(ElementName = "useSystemDefaultDeliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
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

        protected bool _useSystemDefaultNotificationFromAddress;

        [XmlElement(ElementName = "useSystemDefaultNotificationFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
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

        protected bool _useSystemDefaultVoicePortalLockoutFromAddress;

        [XmlElement(ElementName = "useSystemDefaultVoicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:478")]
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
