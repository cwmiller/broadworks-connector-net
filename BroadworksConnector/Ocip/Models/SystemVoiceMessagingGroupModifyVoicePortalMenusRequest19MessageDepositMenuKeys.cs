using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupModifyVoicePortalMenusRequest19MessageDepositMenuKeys 
{
    private string _enableMessageDeposit;

    [XmlElement(ElementName = "enableMessageDeposit", IsNullable = true, Namespace = "")]
    public string EnableMessageDeposit {
        get => _enableMessageDeposit;
        set {
            EnableMessageDepositSpecified = true;
            _enableMessageDeposit = value;
        }
    }

    [XmlIgnore]
    public bool EnableMessageDepositSpecified { get; set; }
    private string _disableMessageDeposit;

    [XmlElement(ElementName = "disableMessageDeposit", IsNullable = true, Namespace = "")]
    public string DisableMessageDeposit {
        get => _disableMessageDeposit;
        set {
            DisableMessageDepositSpecified = true;
            _disableMessageDeposit = value;
        }
    }

    [XmlIgnore]
    public bool DisableMessageDepositSpecified { get; set; }
    private string _listenToMessageDepositStatus;

    [XmlElement(ElementName = "listenToMessageDepositStatus", IsNullable = true, Namespace = "")]
    public string ListenToMessageDepositStatus {
        get => _listenToMessageDepositStatus;
        set {
            ListenToMessageDepositStatusSpecified = true;
            _listenToMessageDepositStatus = value;
        }
    }

    [XmlIgnore]
    public bool ListenToMessageDepositStatusSpecified { get; set; }
    private string _returnToPreviousMenu;

    [XmlElement(ElementName = "returnToPreviousMenu", IsNullable = false, Namespace = "")]
    public string ReturnToPreviousMenu {
        get => _returnToPreviousMenu;
        set {
            ReturnToPreviousMenuSpecified = true;
            _returnToPreviousMenu = value;
        }
    }

    [XmlIgnore]
    public bool ReturnToPreviousMenuSpecified { get; set; }
    private string _repeatMenu;

    [XmlElement(ElementName = "repeatMenu", IsNullable = true, Namespace = "")]
    public string RepeatMenu {
        get => _repeatMenu;
        set {
            RepeatMenuSpecified = true;
            _repeatMenu = value;
        }
    }

    [XmlIgnore]
    public bool RepeatMenuSpecified { get; set; }
}
}