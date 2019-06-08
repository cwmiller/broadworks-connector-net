using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetResponse16 : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
{
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
    private bool _useDnInMailBody;

    [XmlElement(ElementName = "useDnInMailBody", IsNullable = false, Namespace = "")]
    public bool UseDnInMailBody {
        get => _useDnInMailBody;
        set {
            UseDnInMailBodySpecified = true;
            _useDnInMailBody = value;
        }
    }

    [XmlIgnore]
    public bool UseDnInMailBodySpecified { get; set; }
    private bool _useShortSubjectLine;

    [XmlElement(ElementName = "useShortSubjectLine", IsNullable = false, Namespace = "")]
    public bool UseShortSubjectLine {
        get => _useShortSubjectLine;
        set {
            UseShortSubjectLineSpecified = true;
            _useShortSubjectLine = value;
        }
    }

    [XmlIgnore]
    public bool UseShortSubjectLineSpecified { get; set; }
    private int _maxMessageLengthMinutes;

    [XmlElement(ElementName = "maxMessageLengthMinutes", IsNullable = false, Namespace = "")]
    public int MaxMessageLengthMinutes {
        get => _maxMessageLengthMinutes;
        set {
            MaxMessageLengthMinutesSpecified = true;
            _maxMessageLengthMinutes = value;
        }
    }

    [XmlIgnore]
    public bool MaxMessageLengthMinutesSpecified { get; set; }
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
    private string _defaultDeliveryFromAddress;

    [XmlElement(ElementName = "defaultDeliveryFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultDeliveryFromAddress {
        get => _defaultDeliveryFromAddress;
        set {
            DefaultDeliveryFromAddressSpecified = true;
            _defaultDeliveryFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultDeliveryFromAddressSpecified { get; set; }
    private string _defaultNotificationFromAddress;

    [XmlElement(ElementName = "defaultNotificationFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultNotificationFromAddress {
        get => _defaultNotificationFromAddress;
        set {
            DefaultNotificationFromAddressSpecified = true;
            _defaultNotificationFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultNotificationFromAddressSpecified { get; set; }
    private string _defaultVoicePortalLockoutFromAddress;

    [XmlElement(ElementName = "defaultVoicePortalLockoutFromAddress", IsNullable = false, Namespace = "")]
    public string DefaultVoicePortalLockoutFromAddress {
        get => _defaultVoicePortalLockoutFromAddress;
        set {
            DefaultVoicePortalLockoutFromAddressSpecified = true;
            _defaultVoicePortalLockoutFromAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultVoicePortalLockoutFromAddressSpecified { get; set; }
    private bool _useOutgoingMWIOnSMDI;

    [XmlElement(ElementName = "useOutgoingMWIOnSMDI", IsNullable = false, Namespace = "")]
    public bool UseOutgoingMWIOnSMDI {
        get => _useOutgoingMWIOnSMDI;
        set {
            UseOutgoingMWIOnSMDISpecified = true;
            _useOutgoingMWIOnSMDI = value;
        }
    }

    [XmlIgnore]
    public bool UseOutgoingMWIOnSMDISpecified { get; set; }
    private int _mwiDelayInSeconds;

    [XmlElement(ElementName = "mwiDelayInSeconds", IsNullable = false, Namespace = "")]
    public int MwiDelayInSeconds {
        get => _mwiDelayInSeconds;
        set {
            MwiDelayInSecondsSpecified = true;
            _mwiDelayInSeconds = value;
        }
    }

    [XmlIgnore]
    public bool MwiDelayInSecondsSpecified { get; set; }
    private BroadWorksConnector.Ocip.Models.SystemVoicePortalScope _voicePortalScope;

    [XmlElement(ElementName = "voicePortalScope", IsNullable = false, Namespace = "")]
    public BroadWorksConnector.Ocip.Models.SystemVoicePortalScope VoicePortalScope {
        get => _voicePortalScope;
        set {
            VoicePortalScopeSpecified = true;
            _voicePortalScope = value;
        }
    }

    [XmlIgnore]
    public bool VoicePortalScopeSpecified { get; set; }
    private bool _enterpriseVoicePortalLicensed;

    [XmlElement(ElementName = "enterpriseVoicePortalLicensed", IsNullable = false, Namespace = "")]
    public bool EnterpriseVoicePortalLicensed {
        get => _enterpriseVoicePortalLicensed;
        set {
            EnterpriseVoicePortalLicensedSpecified = true;
            _enterpriseVoicePortalLicensed = value;
        }
    }

    [XmlIgnore]
    public bool EnterpriseVoicePortalLicensedSpecified { get; set; }
    private bool _networkWideMessaging;

    [XmlElement(ElementName = "networkWideMessaging", IsNullable = false, Namespace = "")]
    public bool NetworkWideMessaging {
        get => _networkWideMessaging;
        set {
            NetworkWideMessagingSpecified = true;
            _networkWideMessaging = value;
        }
    }

    [XmlIgnore]
    public bool NetworkWideMessagingSpecified { get; set; }
    private bool _useExternalRouting;

    [XmlElement(ElementName = "useExternalRouting", IsNullable = false, Namespace = "")]
    public bool UseExternalRouting {
        get => _useExternalRouting;
        set {
            UseExternalRoutingSpecified = true;
            _useExternalRouting = value;
        }
    }

    [XmlIgnore]
    public bool UseExternalRoutingSpecified { get; set; }
    private string _defaultExternalRoutingAddress;

    [XmlElement(ElementName = "defaultExternalRoutingAddress", IsNullable = false, Namespace = "")]
    public string DefaultExternalRoutingAddress {
        get => _defaultExternalRoutingAddress;
        set {
            DefaultExternalRoutingAddressSpecified = true;
            _defaultExternalRoutingAddress = value;
        }
    }

    [XmlIgnore]
    public bool DefaultExternalRoutingAddressSpecified { get; set; }
}
}
