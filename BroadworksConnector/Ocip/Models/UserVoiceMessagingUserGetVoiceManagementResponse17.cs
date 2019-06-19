using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the UserVoiceMessagingUserGetVoiceManagementRequest17.
    /// <see cref="UserVoiceMessagingUserGetVoiceManagementRequest17"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1903""}]")]
    public class UserVoiceMessagingUserGetVoiceManagementResponse17 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _isActive;

        [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool IsActiveSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMessageProcessing _processing;

        [XmlElement(ElementName = "processing", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool ProcessingSpecified { get; set; }

        private string _voiceMessageDeliveryEmailAddress;

        [XmlElement(ElementName = "voiceMessageDeliveryEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
        [MinLength(1)]
        [MaxLength(80)]
        public string VoiceMessageDeliveryEmailAddress
        {
            get => _voiceMessageDeliveryEmailAddress;
            set
            {
                VoiceMessageDeliveryEmailAddressSpecified = true;
                _voiceMessageDeliveryEmailAddress = value;
            }
        }

        [XmlIgnore]
        public bool VoiceMessageDeliveryEmailAddressSpecified { get; set; }

        private bool _usePhoneMessageWaitingIndicator;

        [XmlElement(ElementName = "usePhoneMessageWaitingIndicator", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool UsePhoneMessageWaitingIndicatorSpecified { get; set; }

        private bool _sendVoiceMessageNotifyEmail;

        [XmlElement(ElementName = "sendVoiceMessageNotifyEmail", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool SendVoiceMessageNotifyEmailSpecified { get; set; }

        private string _voiceMessageNotifyEmailAddress;

        [XmlElement(ElementName = "voiceMessageNotifyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool VoiceMessageNotifyEmailAddressSpecified { get; set; }

        private bool _sendCarbonCopyVoiceMessage;

        [XmlElement(ElementName = "sendCarbonCopyVoiceMessage", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool SendCarbonCopyVoiceMessageSpecified { get; set; }

        private string _voiceMessageCarbonCopyEmailAddress;

        [XmlElement(ElementName = "voiceMessageCarbonCopyEmailAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool VoiceMessageCarbonCopyEmailAddressSpecified { get; set; }

        private bool _transferOnZeroToPhoneNumber;

        [XmlElement(ElementName = "transferOnZeroToPhoneNumber", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool TransferOnZeroToPhoneNumberSpecified { get; set; }

        private string _transferPhoneNumber;

        [XmlElement(ElementName = "transferPhoneNumber", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool TransferPhoneNumberSpecified { get; set; }

        private bool _alwaysRedirectToVoiceMail;

        [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool AlwaysRedirectToVoiceMailSpecified { get; set; }

        private bool _busyRedirectToVoiceMail;

        [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool BusyRedirectToVoiceMailSpecified { get; set; }

        private bool _noAnswerRedirectToVoiceMail;

        [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool NoAnswerRedirectToVoiceMailSpecified { get; set; }

        private bool _outOfPrimaryZoneRedirectToVoiceMail;

        [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1903")]
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
        public bool OutOfPrimaryZoneRedirectToVoiceMailSpecified { get; set; }

    }
}
