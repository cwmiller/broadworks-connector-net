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
    /// <see cref="SuccessResponse"/>
    /// <see cref="ErrorResponse"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""d8f04177e438f303b41c211e518706bf:39464""}]")]
    public class SystemVoiceMessagingGroupModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest<BroadWorksConnector.Ocip.Models.C.SuccessResponse>
    {

        protected bool? _realDeleteForImap;

        [XmlElement(ElementName = "realDeleteForImap", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? RealDeleteForImap
        {
            get => _realDeleteForImap;
            set
            {
                RealDeleteForImapSpecified = (value != null);
                _realDeleteForImap = value;
            }
        }

        [XmlIgnore]
        protected bool RealDeleteForImapSpecified { get; set; }

        protected bool? _useDnInMailBody;

        [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? UseDnInMailBody
        {
            get => _useDnInMailBody;
            set
            {
                UseDnInMailBodySpecified = (value != null);
                _useDnInMailBody = value;
            }
        }

        [XmlIgnore]
        protected bool UseDnInMailBodySpecified { get; set; }

        protected bool? _useShortSubjectLine;

        [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? UseShortSubjectLine
        {
            get => _useShortSubjectLine;
            set
            {
                UseShortSubjectLineSpecified = (value != null);
                _useShortSubjectLine = value;
            }
        }

        [XmlIgnore]
        protected bool UseShortSubjectLineSpecified { get; set; }

        protected int? _maxGreetingLengthMinutes;

        [XmlElement(ElementName = "maxGreetingLengthMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        [MinInclusive(1)]
        [MaxInclusive(5)]
        public int? MaxGreetingLengthMinutes
        {
            get => _maxGreetingLengthMinutes;
            set
            {
                MaxGreetingLengthMinutesSpecified = (value != null);
                _maxGreetingLengthMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxGreetingLengthMinutesSpecified { get; set; }

        protected int? _maxMessageLengthMinutes;

        [XmlElement(ElementName = "maxMessageLengthMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        [MinInclusive(1)]
        [MaxInclusive(10)]
        public int? MaxMessageLengthMinutes
        {
            get => _maxMessageLengthMinutes;
            set
            {
                MaxMessageLengthMinutesSpecified = (value != null);
                _maxMessageLengthMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMessageLengthMinutesSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes? _maxMailboxLengthMinutes;

        [XmlElement(ElementName = "maxMailboxLengthMinutes", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailboxLengthMinutes? MaxMailboxLengthMinutes
        {
            get => _maxMailboxLengthMinutes;
            set
            {
                MaxMailboxLengthMinutesSpecified = (value != null);
                _maxMailboxLengthMinutes = value;
            }
        }

        [XmlIgnore]
        protected bool MaxMailboxLengthMinutesSpecified { get; set; }

        protected bool? _doesMessageAge;

        [XmlElement(ElementName = "doesMessageAge", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? DoesMessageAge
        {
            get => _doesMessageAge;
            set
            {
                DoesMessageAgeSpecified = (value != null);
                _doesMessageAge = value;
            }
        }

        [XmlIgnore]
        protected bool DoesMessageAgeSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays? _holdPeriodDays;

        [XmlElement(ElementName = "holdPeriodDays", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingHoldPeriodDays? HoldPeriodDays
        {
            get => _holdPeriodDays;
            set
            {
                HoldPeriodDaysSpecified = (value != null);
                _holdPeriodDays = value;
            }
        }

        [XmlIgnore]
        protected bool HoldPeriodDaysSpecified { get; set; }

        protected string _mailServerNetAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "mailServerNetAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
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

        protected BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol? _mailServerProtocol;

        [XmlElement(ElementName = "mailServerProtocol", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public BroadWorksConnector.Ocip.Models.VoiceMessagingMailServerProtocol? MailServerProtocol
        {
            get => _mailServerProtocol;
            set
            {
                MailServerProtocolSpecified = (value != null);
                _mailServerProtocol = value;
            }
        }

        [XmlIgnore]
        protected bool MailServerProtocolSpecified { get; set; }

        protected string _defaultDeliveryFromAddress;

        [XmlElement(ElementName = "defaultDeliveryFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultDeliveryFromAddress
        {
            get => _defaultDeliveryFromAddress;
            set
            {
                DefaultDeliveryFromAddressSpecified = (value != null);
                _defaultDeliveryFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultDeliveryFromAddressSpecified { get; set; }

        protected string _defaultNotificationFromAddress;

        [XmlElement(ElementName = "defaultNotificationFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultNotificationFromAddress
        {
            get => _defaultNotificationFromAddress;
            set
            {
                DefaultNotificationFromAddressSpecified = (value != null);
                _defaultNotificationFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultNotificationFromAddressSpecified { get; set; }

        protected string _defaultVoicePortalLockoutFromAddress;

        [XmlElement(ElementName = "defaultVoicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        [MinLength(1)]
        [MaxLength(80)]
        public string DefaultVoicePortalLockoutFromAddress
        {
            get => _defaultVoicePortalLockoutFromAddress;
            set
            {
                DefaultVoicePortalLockoutFromAddressSpecified = (value != null);
                _defaultVoicePortalLockoutFromAddress = value;
            }
        }

        [XmlIgnore]
        protected bool DefaultVoicePortalLockoutFromAddressSpecified { get; set; }

        protected bool? _useOutgoingMWIOnSMDI;

        [XmlElement(ElementName = "useOutgoingMWIOnSMDI", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? UseOutgoingMWIOnSMDI
        {
            get => _useOutgoingMWIOnSMDI;
            set
            {
                UseOutgoingMWIOnSMDISpecified = (value != null);
                _useOutgoingMWIOnSMDI = value;
            }
        }

        [XmlIgnore]
        protected bool UseOutgoingMWIOnSMDISpecified { get; set; }

        protected int? _mwiDelayInSeconds;

        [XmlElement(ElementName = "mwiDelayInSeconds", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        [MinInclusive(0)]
        [MaxInclusive(300)]
        public int? MwiDelayInSeconds
        {
            get => _mwiDelayInSeconds;
            set
            {
                MwiDelayInSecondsSpecified = (value != null);
                _mwiDelayInSeconds = value;
            }
        }

        [XmlIgnore]
        protected bool MwiDelayInSecondsSpecified { get; set; }

        protected BroadWorksConnector.Ocip.Models.SystemVoicePortalScope? _voicePortalScope;

        [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public BroadWorksConnector.Ocip.Models.SystemVoicePortalScope? VoicePortalScope
        {
            get => _voicePortalScope;
            set
            {
                VoicePortalScopeSpecified = (value != null);
                _voicePortalScope = value;
            }
        }

        [XmlIgnore]
        protected bool VoicePortalScopeSpecified { get; set; }

        protected bool? _networkWideMessaging;

        [XmlElement(ElementName = "networkWideMessaging", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? NetworkWideMessaging
        {
            get => _networkWideMessaging;
            set
            {
                NetworkWideMessagingSpecified = (value != null);
                _networkWideMessaging = value;
            }
        }

        [XmlIgnore]
        protected bool NetworkWideMessagingSpecified { get; set; }

        protected bool? _useExternalRouting;

        [XmlElement(ElementName = "useExternalRouting", IsNullable = false, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
        public bool? UseExternalRouting
        {
            get => _useExternalRouting;
            set
            {
                UseExternalRoutingSpecified = (value != null);
                _useExternalRouting = value;
            }
        }

        [XmlIgnore]
        protected bool UseExternalRoutingSpecified { get; set; }

        protected string _defaultExternalRoutingAddress;

        /// <remarks>Eraseable</remarks>
        [XmlElement(ElementName = "defaultExternalRoutingAddress", IsNullable = true, Namespace = "")]
        [Optional]
        [Group(@"d8f04177e438f303b41c211e518706bf:39464")]
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

    }
}
