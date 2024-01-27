using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the reseller level data associated with Voice Messaging.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:354""}]")]
    public class ResellerVoiceMessagingGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _resellerId;

        [XmlElement(ElementName = "resellerId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:354")]
        [MinLength(1)]
        [MaxLength(36)]
        public string ResellerId
        {
            get => _resellerId;
            set
            {
                ResellerIdSpecified = true;
                _resellerId = value;
            }
        }

        [XmlIgnore]
        protected bool ResellerIdSpecified { get; set; }

        protected string _deliveryFromAddress;

        [XmlElement(ElementName = "deliveryFromAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:354")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:354")]
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
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:354")]
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
