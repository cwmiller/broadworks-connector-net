using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemVoiceMessagingGroupGetRequest21.
    /// The following elements are only used in AS data mode:
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
    /// vmOnlySystem
    /// clientInitiatedMailServerSessionTimeoutMinutes
    /// recordingAudioFileFormat
    /// 
    /// Replaced by: SystemVoiceMessagingGroupGetResponse22 in AS data mode
    /// <see cref="SystemVoiceMessagingGroupGetRequest21"/>
    /// <see cref="SystemVoiceMessagingGroupGetResponse22"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""de4d76f01f337fe4694212ec9f771753:12253""}]")]
    public class SystemVoiceMessagingGroupGetResponse21 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        private bool _realDeleteForImap;

        [XmlElement(ElementName = "realDeleteForImap", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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

        [XmlElement(ElementName = "mailServerNetAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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

        private bool _enterpriseVoicePortalLicensed;

        [XmlElement(ElementName = "enterpriseVoicePortalLicensed", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
        public bool EnterpriseVoicePortalLicensed
        {
            get => _enterpriseVoicePortalLicensed;
            set
            {
                EnterpriseVoicePortalLicensedSpecified = true;
                _enterpriseVoicePortalLicensed = value;
            }
        }

        [XmlIgnore]
        protected bool EnterpriseVoicePortalLicensedSpecified { get; set; }

        private bool _networkWideMessaging;

        [XmlElement(ElementName = "networkWideMessaging", IsNullable = false, Namespace = "")]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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

        [XmlElement(ElementName = "defaultExternalRoutingAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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
        [Group(@"de4d76f01f337fe4694212ec9f771753:12253")]
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

    }
}
