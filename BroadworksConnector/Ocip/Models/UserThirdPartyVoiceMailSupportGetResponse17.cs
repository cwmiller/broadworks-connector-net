using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class UserThirdPartyVoiceMailSupportGetResponse17 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private bool _isActive;

    [XmlElement(ElementName = "isActive", IsNullable = false, Namespace = "")]
    public bool IsActive {
        get => _isActive;
        set {
            IsActiveSpecified = true;
            _isActive = value;
        }
    }

    [XmlIgnore]
    public bool IsActiveSpecified { get; set; }
    private bool _busyRedirectToVoiceMail;

    [XmlElement(ElementName = "busyRedirectToVoiceMail", IsNullable = false, Namespace = "")]
    public bool BusyRedirectToVoiceMail {
        get => _busyRedirectToVoiceMail;
        set {
            BusyRedirectToVoiceMailSpecified = true;
            _busyRedirectToVoiceMail = value;
        }
    }

    [XmlIgnore]
    public bool BusyRedirectToVoiceMailSpecified { get; set; }
    private bool _noAnswerRedirectToVoiceMail;

    [XmlElement(ElementName = "noAnswerRedirectToVoiceMail", IsNullable = false, Namespace = "")]
    public bool NoAnswerRedirectToVoiceMail {
        get => _noAnswerRedirectToVoiceMail;
        set {
            NoAnswerRedirectToVoiceMailSpecified = true;
            _noAnswerRedirectToVoiceMail = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerRedirectToVoiceMailSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection _serverSelection;

    [XmlElement(ElementName = "serverSelection", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportServerSelection ServerSelection {
        get => _serverSelection;
        set {
            ServerSelectionSpecified = true;
            _serverSelection = value;
        }
    }

    [XmlIgnore]
    public bool ServerSelectionSpecified { get; set; }
    private string _userServer;

    [XmlElement(ElementName = "userServer", IsNullable = false, Namespace = "")]
    public string UserServer {
        get => _userServer;
        set {
            UserServerSpecified = true;
            _userServer = value;
        }
    }

    [XmlIgnore]
    public bool UserServerSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType _mailboxIdType;

    [XmlElement(ElementName = "mailboxIdType", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportMailboxIdType MailboxIdType {
        get => _mailboxIdType;
        set {
            MailboxIdTypeSpecified = true;
            _mailboxIdType = value;
        }
    }

    [XmlIgnore]
    public bool MailboxIdTypeSpecified { get; set; }
    private string _mailboxURL;

    [XmlElement(ElementName = "mailboxURL", IsNullable = false, Namespace = "")]
    public string MailboxURL {
        get => _mailboxURL;
        set {
            MailboxURLSpecified = true;
            _mailboxURL = value;
        }
    }

    [XmlIgnore]
    public bool MailboxURLSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportNumberOfRings _noAnswerNumberOfRings;

    [XmlElement(ElementName = "noAnswerNumberOfRings", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.ThirdPartyVoiceMailSupportNumberOfRings NoAnswerNumberOfRings {
        get => _noAnswerNumberOfRings;
        set {
            NoAnswerNumberOfRingsSpecified = true;
            _noAnswerNumberOfRings = value;
        }
    }

    [XmlIgnore]
    public bool NoAnswerNumberOfRingsSpecified { get; set; }
    private bool _alwaysRedirectToVoiceMail;

    [XmlElement(ElementName = "alwaysRedirectToVoiceMail", IsNullable = false, Namespace = "")]
    public bool AlwaysRedirectToVoiceMail {
        get => _alwaysRedirectToVoiceMail;
        set {
            AlwaysRedirectToVoiceMailSpecified = true;
            _alwaysRedirectToVoiceMail = value;
        }
    }

    [XmlIgnore]
    public bool AlwaysRedirectToVoiceMailSpecified { get; set; }
    private bool _outOfPrimaryZoneRedirectToVoiceMail;

    [XmlElement(ElementName = "outOfPrimaryZoneRedirectToVoiceMail", IsNullable = false, Namespace = "")]
    public bool OutOfPrimaryZoneRedirectToVoiceMail {
        get => _outOfPrimaryZoneRedirectToVoiceMail;
        set {
            OutOfPrimaryZoneRedirectToVoiceMailSpecified = true;
            _outOfPrimaryZoneRedirectToVoiceMail = value;
        }
    }

    [XmlIgnore]
    public bool OutOfPrimaryZoneRedirectToVoiceMailSpecified { get; set; }
}
}
