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

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:336""}]")]
    public class ResellerVoiceMessagingGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected string _deliveryFromAddress;

        [XmlElement(ElementName = "deliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:336")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:336")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:336")]
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

    }
}
