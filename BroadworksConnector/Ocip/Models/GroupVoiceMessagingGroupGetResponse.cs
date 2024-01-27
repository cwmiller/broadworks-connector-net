using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to GroupVoiceMessagingGroupGetRequest.
    /// Contains the group's voice messaging settings.
    /// <see cref="GroupVoiceMessagingGroupGetRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""1fea1222b6a78aa7b98fd5c41bdae113:130""}]")]
    public class GroupVoiceMessagingGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingGroupMailServerChoices _useMailServerSetting;

        [XmlElement(ElementName = "useMailServerSetting", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected bool _warnCallerBeforeRecordingVoiceMessage;

        [XmlElement(ElementName = "warnCallerBeforeRecordingVoiceMessage", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected bool _allowUsersConfiguringAdvancedSettings;

        [XmlElement(ElementName = "allowUsersConfiguringAdvancedSettings", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected bool _allowComposeOrForwardMessageToEntireGroup;

        [XmlElement(ElementName = "allowComposeOrForwardMessageToEntireGroup", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected string _mailServerNetAddress;

        [XmlElement(ElementName = "mailServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _mailServerProtocol;

        [XmlElement(ElementName = "mailServerProtocol", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected bool _realDeleteForImap;

        [XmlElement(ElementName = "realDeleteForImap", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _maxMailboxLengthMinutes;

        [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected bool _doesMessageAge;

        [XmlElement(ElementName = "doesMessageAge", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays _holdPeriodDays;

        [XmlElement(ElementName = "holdPeriodDays", IsNullable = false, Namespace = "")]
        [Group(@"1fea1222b6a78aa7b98fd5c41bdae113:130")]
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
