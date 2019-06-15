using System;
using System.Xml.Serialization;
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
     
    public class GroupVoiceMessagingGroupGetResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingGroupMailServerChoices _useMailServerSetting;

        [XmlElement(ElementName = "useMailServerSetting", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingGroupMailServerChoices UseMailServerSetting {
            get => _useMailServerSetting;
            set {
                UseMailServerSettingSpecified = true;
                _useMailServerSetting = value;
            }
        }

        [XmlIgnore]
        public bool UseMailServerSettingSpecified { get; set; }
        
        private bool _warnCallerBeforeRecordingVoiceMessage;

        [XmlElement(ElementName = "warnCallerBeforeRecordingVoiceMessage", IsNullable = false, Namespace = "")]
        public bool WarnCallerBeforeRecordingVoiceMessage {
            get => _warnCallerBeforeRecordingVoiceMessage;
            set {
                WarnCallerBeforeRecordingVoiceMessageSpecified = true;
                _warnCallerBeforeRecordingVoiceMessage = value;
            }
        }

        [XmlIgnore]
        public bool WarnCallerBeforeRecordingVoiceMessageSpecified { get; set; }
        
        private bool _allowUsersConfiguringAdvancedSettings;

        [XmlElement(ElementName = "allowUsersConfiguringAdvancedSettings", IsNullable = false, Namespace = "")]
        public bool AllowUsersConfiguringAdvancedSettings {
            get => _allowUsersConfiguringAdvancedSettings;
            set {
                AllowUsersConfiguringAdvancedSettingsSpecified = true;
                _allowUsersConfiguringAdvancedSettings = value;
            }
        }

        [XmlIgnore]
        public bool AllowUsersConfiguringAdvancedSettingsSpecified { get; set; }
        
        private bool _allowComposeOrForwardMessageToEntireGroup;

        [XmlElement(ElementName = "allowComposeOrForwardMessageToEntireGroup", IsNullable = false, Namespace = "")]
        public bool AllowComposeOrForwardMessageToEntireGroup {
            get => _allowComposeOrForwardMessageToEntireGroup;
            set {
                AllowComposeOrForwardMessageToEntireGroupSpecified = true;
                _allowComposeOrForwardMessageToEntireGroup = value;
            }
        }

        [XmlIgnore]
        public bool AllowComposeOrForwardMessageToEntireGroupSpecified { get; set; }
        
        private string _mailServerNetAddress;

        [XmlElement(ElementName = "mailServerNetAddress", IsNullable = false, Namespace = "")]
        public string MailServerNetAddress {
            get => _mailServerNetAddress;
            set {
                MailServerNetAddressSpecified = true;
                _mailServerNetAddress = value;
            }
        }

        [XmlIgnore]
        public bool MailServerNetAddressSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol _mailServerProtocol;

        [XmlElement(ElementName = "mailServerProtocol", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol MailServerProtocol {
            get => _mailServerProtocol;
            set {
                MailServerProtocolSpecified = true;
                _mailServerProtocol = value;
            }
        }

        [XmlIgnore]
        public bool MailServerProtocolSpecified { get; set; }
        
        private bool _realDeleteForImap;

        [XmlElement(ElementName = "realDeleteForImap", IsNullable = false, Namespace = "")]
        public bool RealDeleteForImap {
            get => _realDeleteForImap;
            set {
                RealDeleteForImapSpecified = true;
                _realDeleteForImap = value;
            }
        }

        [XmlIgnore]
        public bool RealDeleteForImapSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _maxMailboxLengthMinutes;

        [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes MaxMailboxLengthMinutes {
            get => _maxMailboxLengthMinutes;
            set {
                MaxMailboxLengthMinutesSpecified = true;
                _maxMailboxLengthMinutes = value;
            }
        }

        [XmlIgnore]
        public bool MaxMailboxLengthMinutesSpecified { get; set; }
        
        private bool _doesMessageAge;

        [XmlElement(ElementName = "doesMessageAge", IsNullable = false, Namespace = "")]
        public bool DoesMessageAge {
            get => _doesMessageAge;
            set {
                DoesMessageAgeSpecified = true;
                _doesMessageAge = value;
            }
        }

        [XmlIgnore]
        public bool DoesMessageAgeSpecified { get; set; }
        
        private BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays _holdPeriodDays;

        [XmlElement(ElementName = "holdPeriodDays", IsNullable = false, Namespace = "")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays HoldPeriodDays {
            get => _holdPeriodDays;
            set {
                HoldPeriodDaysSpecified = true;
                _holdPeriodDays = value;
            }
        }

        [XmlIgnore]
        public bool HoldPeriodDaysSpecified { get; set; }
        
    }
}
