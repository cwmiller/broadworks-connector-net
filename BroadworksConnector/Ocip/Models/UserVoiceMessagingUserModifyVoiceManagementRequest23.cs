using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the user's voice messaging voice management service setting.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:2149""}]")]
    public class UserVoiceMessagingUserModifyVoiceManagementRequest23 : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected string _userId;

        [XmlElement(ElementName = "userId", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        [MinLength(1)]
        [MaxLength(161)]
        public string UserId
        {
            get => _userId;
            set
            {
                UserIdSpecified = true;
                _userId = value;
            }
        }

        [XmlIgnore]
        protected bool UserIdSpecified { get; set; }

        protected bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool IsActive
        {
            get => _isActive;
            set
            {
                IsActiveSpecified = true;
                _isActive = value;
            }
        }

        [XmlIgnore]
        protected bool IsActiveSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing _processing;

        [XmlElement(ElementName = "processing", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing Processing
        {
            get => _processing;
            set
            {
                ProcessingSpecified = true;
                _processing = value;
            }
        }

        [XmlIgnore]
        protected bool ProcessingSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.EmailAddressList _voiceMessageDeliveryEmailAddress;

        [XmlElement(ElementName = "voiceMessageDeliveryEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public BroadWorksConnector.Ocip.Models.EmailAddressList VoiceMessageDeliveryEmailAddress
        {
            get => _voiceMessageDeliveryEmailAddress;
            set
            {
                VoiceMessageDeliveryEmailAddressSpecified = true;
                _voiceMessageDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageDeliveryEmailAddressSpecified { get; set; }

        protected bool _usePhoneMessageWaitingIndicator;

        [XmlElement(ElementName = "usePhoneMessageWaitingIndicator", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool UsePhoneMessageWaitingIndicator
        {
            get => _usePhoneMessageWaitingIndicator;
            set
            {
                UsePhoneMessageWaitingIndicatorSpecified = true;
                _usePhoneMessageWaitingIndicator = value;
            }
        }

        [XmlIgnore]
        protected bool UsePhoneMessageWaitingIndicatorSpecified { get; set; }

        protected bool _sendVoiceMessageNotifyEmail;

        [XmlElement(ElementName = "sendVoiceMessageNotifyEmail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool SendVoiceMessageNotifyEmail
        {
            get => _sendVoiceMessageNotifyEmail;
            set
            {
                SendVoiceMessageNotifyEmailSpecified = true;
                _sendVoiceMessageNotifyEmail = value;
            }
        }

        [XmlIgnore]
        protected bool SendVoiceMessageNotifyEmailSpecified { get; set; }

        protected string _voiceMessageNotifyEmailAddress;

        [XmlElement(ElementName = "voiceMessageNotifyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageNotifyEmailAddress
        {
            get => _voiceMessageNotifyEmailAddress;
            set
            {
                VoiceMessageNotifyEmailAddressSpecified = true;
                _voiceMessageNotifyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageNotifyEmailAddressSpecified { get; set; }

        protected bool _sendCarbonCopyVoiceMessage;

        [XmlElement(ElementName = "sendCarbonCopyVoiceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool SendCarbonCopyVoiceMessage
        {
            get => _sendCarbonCopyVoiceMessage;
            set
            {
                SendCarbonCopyVoiceMessageSpecified = true;
                _sendCarbonCopyVoiceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool SendCarbonCopyVoiceMessageSpecified { get; set; }

        protected string _voiceMessageCarbonCopyEmailAddress;

        [XmlElement(ElementName = "voiceMessageCarbonCopyEmailAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageCarbonCopyEmailAddress
        {
            get => _voiceMessageCarbonCopyEmailAddress;
            set
            {
                VoiceMessageCarbonCopyEmailAddressSpecified = true;
                _voiceMessageCarbonCopyEmailAddress = value;
            }
        }

        [XmlIgnore]
        protected bool VoiceMessageCarbonCopyEmailAddressSpecified { get; set; }

        protected bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool TransferOnZeroToPhoneNumber
        {
            get => _transferOnZeroToPhoneNumber;
            set
            {
                TransferOnZeroToPhoneNumberSpecified = true;
                _transferOnZeroToPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferOnZeroToPhoneNumberSpecified { get; set; }

        protected string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        [MinLength(1)]
        [MaxLength(30)]
        public string TransferPhoneNumber
        {
            get => _transferPhoneNumber;
            set
            {
                TransferPhoneNumberSpecified = true;
                _transferPhoneNumber = value;
            }
        }

        [XmlIgnore]
        protected bool TransferPhoneNumberSpecified { get; set; }

        protected bool _alwaysRedirectToVoiceMail;

        [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool AlwaysRedirectToVoiceMail
        {
            get => _alwaysRedirectToVoiceMail;
            set
            {
                AlwaysRedirectToVoiceMailSpecified = true;
                _alwaysRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool AlwaysRedirectToVoiceMailSpecified { get; set; }

        protected bool _busyRedirectToVoiceMail;

        [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool BusyRedirectToVoiceMail
        {
            get => _busyRedirectToVoiceMail;
            set
            {
                BusyRedirectToVoiceMailSpecified = true;
                _busyRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool BusyRedirectToVoiceMailSpecified { get; set; }

        protected bool _noAnswerRedirectToVoiceMail;

        [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool NoAnswerRedirectToVoiceMail
        {
            get => _noAnswerRedirectToVoiceMail;
            set
            {
                NoAnswerRedirectToVoiceMailSpecified = true;
                _noAnswerRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool NoAnswerRedirectToVoiceMailSpecified { get; set; }

        protected bool _outOfPrimaryZoneRedirectToVoiceMail;

        [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:2149")]
        public bool OutOfPrimaryZoneRedirectToVoiceMail
        {
            get => _outOfPrimaryZoneRedirectToVoiceMail;
            set
            {
                OutOfPrimaryZoneRedirectToVoiceMailSpecified = true;
                _outOfPrimaryZoneRedirectToVoiceMail = value;
            }
        }

        [XmlIgnore]
        protected bool OutOfPrimaryZoneRedirectToVoiceMailSpecified { get; set; }

    }
}
