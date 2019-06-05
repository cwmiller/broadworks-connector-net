using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19ReplyMessageMenuKeys 
{
    private string _sendReplyToCaller;

    [XmlElement(ElementName = "sendReplyToCaller", IsNullable = false, Namespace = "")]
    public string SendReplyToCaller {
        get => _sendReplyToCaller;
        set {
            SendReplyToCallerSpecified = true;
            _sendReplyToCaller = value;
        }
    }

    [XmlIgnore]
    public bool SendReplyToCallerSpecified { get; set; }
    private string _changeCurrentReply;

    [XmlElement(ElementName = "changeCurrentReply", IsNullable = false, Namespace = "")]
    public string ChangeCurrentReply {
        get => _changeCurrentReply;
        set {
            ChangeCurrentReplySpecified = true;
            _changeCurrentReply = value;
        }
    }

    [XmlIgnore]
    public bool ChangeCurrentReplySpecified { get; set; }
    private string _listenToCurrentReply;

    [XmlElement(ElementName = "listenToCurrentReply", IsNullable = false, Namespace = "")]
    public string ListenToCurrentReply {
        get => _listenToCurrentReply;
        set {
            ListenToCurrentReplySpecified = true;
            _listenToCurrentReply = value;
        }
    }

    [XmlIgnore]
    public bool ListenToCurrentReplySpecified { get; set; }
    private string _setOrClearUrgentIndicator;

    [XmlElement(ElementName = "setOrClearUrgentIndicator", IsNullable = false, Namespace = "")]
    public string SetOrClearUrgentIndicator {
        get => _setOrClearUrgentIndicator;
        set {
            SetOrClearUrgentIndicatorSpecified = true;
            _setOrClearUrgentIndicator = value;
        }
    }

    [XmlIgnore]
    public bool SetOrClearUrgentIndicatorSpecified { get; set; }
    private string _setOrClearConfidentialIndicator;

    [XmlElement(ElementName = "setOrClearConfidentialIndicator", IsNullable = false, Namespace = "")]
    public string SetOrClearConfidentialIndicator {
        get => _setOrClearConfidentialIndicator;
        set {
            SetOrClearConfidentialIndicatorSpecified = true;
            _setOrClearConfidentialIndicator = value;
        }
    }

    [XmlIgnore]
    public bool SetOrClearConfidentialIndicatorSpecified { get; set; }
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

    [XmlElement(ElementName = "repeatMenu", IsNullable = false, Namespace = "")]
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
