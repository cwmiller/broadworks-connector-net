using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Request to modify the group's voice messaging settings.
    /// The response is either SuccessResponse or ErrorResponse.
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:240""}]")]
    public class GroupVoiceMessagingGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private string _serviceProviderId;

        [XmlElement(ElementName = "serviceProviderId", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
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

        private string _groupId;

        [XmlElement(ElementName = "groupId", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        [MinLength(1)]
        [MaxLength(30)]
        public string GroupId
        {
            get => _groupId;
            set
            {
                GroupIdSpecified = true;
                _groupId = value;
            }
        }

        [XmlIgnore]
        protected bool GroupIdSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingGroupMailServerChoices _useMailServerSetting;

        [XmlElement(ElementName = "useMailServerSetting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingGroupMailServerChoices UseMailServerSetting
        {
            get => _useMailServerSetting;
            set
            {
                UseMailServerSettingSpecified = true;
                _useMailServerSetting = value;
            }
        }

        [XmlIgnore]
        protected bool UseMailServerSettingSpecified { get; set; }

        private bool _warnCallerBeforeRecordingVoiceMessage;

        [XmlElement(ElementName = "warnCallerBeforeRecordingVoiceMessage", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public bool WarnCallerBeforeRecordingVoiceMessage
        {
            get => _warnCallerBeforeRecordingVoiceMessage;
            set
            {
                WarnCallerBeforeRecordingVoiceMessageSpecified = true;
                _warnCallerBeforeRecordingVoiceMessage = value;
            }
        }

        [XmlIgnore]
        protected bool WarnCallerBeforeRecordingVoiceMessageSpecified { get; set; }

        private bool _allowUsersConfiguringAdvancedSettings;

        [XmlElement(ElementName = "allowUsersConfiguringAdvancedSettings", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public bool AllowUsersConfiguringAdvancedSettings
        {
            get => _allowUsersConfiguringAdvancedSettings;
            set
            {
                AllowUsersConfiguringAdvancedSettingsSpecified = true;
                _allowUsersConfiguringAdvancedSettings = value;
            }
        }

        [XmlIgnore]
        protected bool AllowUsersConfiguringAdvancedSettingsSpecified { get; set; }

        private bool _allowComposeOrForwardMessageToEntireGroup;

        [XmlElement(ElementName = "allowComposeOrForwardMessageToEntireGroup", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public bool AllowComposeOrForwardMessageToEntireGroup
        {
            get => _allowComposeOrForwardMessageToEntireGroup;
            set
            {
                AllowComposeOrForwardMessageToEntireGroupSpecified = true;
                _allowComposeOrForwardMessageToEntireGroup = value;
            }
        }

        [XmlIgnore]
        protected bool AllowComposeOrForwardMessageToEntireGroupSpecified { get; set; }

        private string _mailServerNetAddress;

        [XmlElement(ElementName = "mailServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        [MinLength(1)]
        [MaxLength(80)]
        public string MailServerNetAddress
        {
            get => _mailServerNetAddress;
            set
            {
                MailServerNetAddressSpecified = true;
                _mailServerNetAddress = value;
            }
        }

        [XmlIgnore]
        protected bool MailServerNetAddressSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _mailServerProtocol;

        [XmlElement(ElementName = "mailServerProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol MailServerProtocol
        {
            get => _mailServerProtocol;
            set
            {
                MailServerProtocolSpecified = true;
                _mailServerProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool MailServerProtocolSpecified { get; set; }

        private bool _realDeleteForImap;

        [XmlElement(ElementName = "realDeleteForImap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public bool RealDeleteForImap
        {
            get => _realDeleteForImap;
            set
            {
                RealDeleteForImapSpecified = true;
                _realDeleteForImap = value;
            }
        }

        [XmlIgnore]
        protected bool RealDeleteForImapSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _maxMailboxLengthMinutes;

        [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes MaxMailboxLengthMinutes
        {
            get => _maxMailboxLengthMinutes;
            set
            {
                MaxMailboxLengthMinutesSpecified = true;
                _maxMailboxLengthMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMailboxLengthMinutesSpecified { get; set; }

        private bool _doesMessageAge;

        [XmlElement(ElementName = "doesMessageAge", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public bool DoesMessageAge
        {
            get => _doesMessageAge;
            set
            {
                DoesMessageAgeSpecified = true;
                _doesMessageAge = value;
            }
        }

        [XmlIgnore]
        protected bool DoesMessageAgeSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays _holdPeriodDays;

        [XmlElement(ElementName = "holdPeriodDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:240")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays HoldPeriodDays
        {
            get => _holdPeriodDays;
            set
            {
                HoldPeriodDaysSpecified = true;
                _holdPeriodDays = value;
            }
        }

        [XmlIgnore]
        protected bool HoldPeriodDaysSpecified { get; set; }

    }
}
