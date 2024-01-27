using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// A service provider's or enterprise's voice messaging settings used in the context of add.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""e19a9072c2dad499e9f28837da5768db:7259""}]")]
    public class ServiceProviderVoiceMessagingGroupSettingsAdd
    {

        protected string _deliveryFromAddress;

        [XmlElement(ElementName = "deliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7259")]
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

        [XmlElement(ElementName = "notificationFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7259")]
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

        [XmlElement(ElementName = "voicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"e19a9072c2dad499e9f28837da5768db:7259")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:7259")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:7259")]
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
        [Group(@"e19a9072c2dad499e9f28837da5768db:7259")]
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
