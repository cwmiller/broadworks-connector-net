using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Modify the system level data associated with Voice Messaging.
    /// The response is either a SuccessResponse or an ErrorResponse.
    /// 
    /// The following elements are only used in AS/Amplify data mode:
    /// realDeleteForImap
    /// useDnInMailBody
    /// useShortSubjectLine
    /// maxMessageLengthMinutes
    /// maxMailboxLengthMinutes
    /// doesMessageAge
    /// holdPeriodDays
    /// mailServerNetAddress
    /// mailServerProtocol
    /// defaultDeliveryFromAddress
    /// defaultNotificationFromAddress
    /// useOutgoingMWIOnSMDI
    /// mwiDelayInSeconds
    /// voicePortalScope
    /// enterpriseVoicePortalLicensed
    /// networkWideMessaging
    /// useExternalRouting
    /// defaultExternalRoutingAddress
    /// vmOnlySystem, element is ignored in Amplify data mode.
    /// clientInitiatedMailServerSessionTimeoutMinutes
    /// recordingAudioFileFormat
    /// allowVoicePortalAccessFromVMDepositMenu
    /// The following elements are only used in AS data mode and ignored in XS data mode:
    /// storageSelection
    /// vmBucketName
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:1164""}]")]
    public class SystemVoiceMessagingGroupModifyRequest16 : BroadWorksConnector.Ocip.Models.C.OCIRequest
    {

        private bool _realDeleteForImap;

        [XmlElement(ElementName = "realDeleteForImap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
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

        private bool _useDnInMailBody;

        [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool UseDnInMailBody
        {
            get => _useDnInMailBody;
            set
            {
                UseDnInMailBodySpecified = true;
                _useDnInMailBody = value;
            }
        }

        [XmlIgnore]
        protected bool UseDnInMailBodySpecified { get; set; }

        private bool _useShortSubjectLine;

        [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool UseShortSubjectLine
        {
            get => _useShortSubjectLine;
            set
            {
                UseShortSubjectLineSpecified = true;
                _useShortSubjectLine = value;
            }
        }

        [XmlIgnore]
        protected bool UseShortSubjectLineSpecified { get; set; }

        private int _maxMessageLengthMinutes;

        [XmlElement(ElementName = "maxMessageLengthMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int MaxMessageLengthMinutes
        {
            get => _maxMessageLengthMinutes;
            set
            {
                MaxMessageLengthMinutesSpecified = true;
                _maxMessageLengthMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMessageLengthMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes _maxMailboxLengthMinutes;

        [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
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

        private string _mailServerNetAddress;

        [XmlElement(ElementName = "mailServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
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
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
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

        private string _defaultDeliveryFromAddress;

        [XmlElement(ElementName = "defaultDeliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultDeliveryFromAddress
        {
            get => _defaultDeliveryFromAddress;
            set
            {
                DefaultDeliveryFromAddressSpecified = true;
                _defaultDeliveryFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultDeliveryFromAddressSpecified { get; set; }

        private string _defaultNotificationFromAddress;

        [XmlElement(ElementName = "defaultNotificationFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultNotificationFromAddress
        {
            get => _defaultNotificationFromAddress;
            set
            {
                DefaultNotificationFromAddressSpecified = true;
                _defaultNotificationFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultNotificationFromAddressSpecified { get; set; }

        private string _defaultVoicePortalLockoutFromAddress;

        [XmlElement(ElementName = "defaultVoicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultVoicePortalLockoutFromAddress
        {
            get => _defaultVoicePortalLockoutFromAddress;
            set
            {
                DefaultVoicePortalLockoutFromAddressSpecified = true;
                _defaultVoicePortalLockoutFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultVoicePortalLockoutFromAddressSpecified { get; set; }

        private bool _useOutgoingMWIOnSMDI;

        [XmlElement(ElementName = "useOutgoingMWIOnSMDI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool UseOutgoingMWIOnSMDI
        {
            get => _useOutgoingMWIOnSMDI;
            set
            {
                UseOutgoingMWIOnSMDISpecified = true;
                _useOutgoingMWIOnSMDI = value;
            }
        }

        [XmlIgnore]
        protected bool UseOutgoingMWIOnSMDISpecified { get; set; }

        private int _mwiDelayInSeconds;

        [XmlElement(ElementName = "mwiDelayInSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinInclusive(0)]
        [MaxInclusive(300)]
        public int MwiDelayInSeconds
        {
            get => _mwiDelayInSeconds;
            set
            {
                MwiDelayInSecondsSpecified = true;
                _mwiDelayInSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool MwiDelayInSecondsSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.SystemVoicePortalScope _voicePortalScope;

        [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public BroadWorksConnector.Ocip.Models.SystemVoicePortalScope VoicePortalScope
        {
            get => _voicePortalScope;
            set
            {
                VoicePortalScopeSpecified = true;
                _voicePortalScope = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalScopeSpecified { get; set; }

        private bool _networkWideMessaging;

        [XmlElement(ElementName = "networkWideMessaging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool NetworkWideMessaging
        {
            get => _networkWideMessaging;
            set
            {
                NetworkWideMessagingSpecified = true;
                _networkWideMessaging = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkWideMessagingSpecified { get; set; }

        private bool _useExternalRouting;

        [XmlElement(ElementName = "useExternalRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool UseExternalRouting
        {
            get => _useExternalRouting;
            set
            {
                UseExternalRoutingSpecified = true;
                _useExternalRouting = value;
            }
        }

        [XmlIgnore]
        protected bool UseExternalRoutingSpecified { get; set; }

        private string _defaultExternalRoutingAddress;

        [XmlElement(ElementName = "defaultExternalRoutingAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinLength(1)]
        [MaxLength(161)]
        public string DefaultExternalRoutingAddress
        {
            get => _defaultExternalRoutingAddress;
            set
            {
                DefaultExternalRoutingAddressSpecified = true;
                _defaultExternalRoutingAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultExternalRoutingAddressSpecified { get; set; }

        private bool _vmOnlySystem;

        [XmlElement(ElementName = "vmOnlySystem", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool VmOnlySystem
        {
            get => _vmOnlySystem;
            set
            {
                VmOnlySystemSpecified = true;
                _vmOnlySystem = value;
            }
        }

        [XmlIgnore]
        protected bool VmOnlySystemSpecified { get; set; }

        private int _clientInitiatedMailServerSessionTimeoutMinutes;

        [XmlElement(ElementName = "clientInitiatedMailServerSessionTimeoutMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int ClientInitiatedMailServerSessionTimeoutMinutes
        {
            get => _clientInitiatedMailServerSessionTimeoutMinutes;
            set
            {
                ClientInitiatedMailServerSessionTimeoutMinutesSpecified = true;
                _clientInitiatedMailServerSessionTimeoutMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool ClientInitiatedMailServerSessionTimeoutMinutesSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingRecordingAudioFileFormat _recordingAudioFileFormat;

        [XmlElement(ElementName = "recordingAudioFileFormat", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingRecordingAudioFileFormat RecordingAudioFileFormat
        {
            get => _recordingAudioFileFormat;
            set
            {
                RecordingAudioFileFormatSpecified = true;
                _recordingAudioFileFormat = value;
            }
        }

        [XmlIgnore]
        protected bool RecordingAudioFileFormatSpecified { get; set; }

        private bool _allowVoicePortalAccessFromVMDepositMenu;

        [XmlElement(ElementName = "allowVoicePortalAccessFromVMDepositMenu", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public bool AllowVoicePortalAccessFromVMDepositMenu
        {
            get => _allowVoicePortalAccessFromVMDepositMenu;
            set
            {
                AllowVoicePortalAccessFromVMDepositMenuSpecified = true;
                _allowVoicePortalAccessFromVMDepositMenu = value;
            }
        }

        [XmlIgnore]
        protected bool AllowVoicePortalAccessFromVMDepositMenuSpecified { get; set; }

        private BroadWorksConnector.Ocip.Models.VoiceMessagingStorageMode _storageSelection;

        [XmlElement(ElementName = "storageSelection", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingStorageMode StorageSelection
        {
            get => _storageSelection;
            set
            {
                StorageSelectionSpecified = true;
                _storageSelection = value;
            }
        }

        [XmlIgnore]
        protected bool StorageSelectionSpecified { get; set; }

        private string _vmBucketName;

        [XmlElement(ElementName = "vmBucketName", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:1164")]
        [MinLength(3)]
        [MaxLength(256)]
        public string VmBucketName
        {
            get => _vmBucketName;
            set
            {
                VmBucketNameSpecified = true;
                _vmBucketName = value;
            }
        }

        [XmlIgnore]
        protected bool VmBucketNameSpecified { get; set; }

    }
}
