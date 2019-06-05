using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessagingGroupGetVoicePortalMenusResponse19SendToPersonMenuKeys 
{
    private string _confirmSendingMessage;

    [XmlElement(ElementName = "confirmSendingMessage", IsNullable = false, Namespace = "")]
    public string ConfirmSendingMessage {
        get => _confirmSendingMessage;
        set {
            ConfirmSendingMessageSpecified = true;
            _confirmSendingMessage = value;
        }
    }

    [XmlIgnore]
    public bool ConfirmSendingMessageSpecified { get; set; }
    private string _cancelSendingMessage;

    [XmlElement(ElementName = "cancelSendingMessage", IsNullable = false, Namespace = "")]
    public string CancelSendingMessage {
        get => _cancelSendingMessage;
        set {
            CancelSendingMessageSpecified = true;
            _cancelSendingMessage = value;
        }
    }

    [XmlIgnore]
    public bool CancelSendingMessageSpecified { get; set; }
    private string _finishEnteringNumberWhereToSendMessageTo;

    [XmlElement(ElementName = "finishEnteringNumberWhereToSendMessageTo", IsNullable = false, Namespace = "")]
    public string FinishEnteringNumberWhereToSendMessageTo {
        get => _finishEnteringNumberWhereToSendMessageTo;
        set {
            FinishEnteringNumberWhereToSendMessageToSpecified = true;
            _finishEnteringNumberWhereToSendMessageTo = value;
        }
    }

    [XmlIgnore]
    public bool FinishEnteringNumberWhereToSendMessageToSpecified { get; set; }
    private string _finishForwardingOrSendingMessage;

    [XmlElement(ElementName = "finishForwardingOrSendingMessage", IsNullable = false, Namespace = "")]
    public string FinishForwardingOrSendingMessage {
        get => _finishForwardingOrSendingMessage;
        set {
            FinishForwardingOrSendingMessageSpecified = true;
            _finishForwardingOrSendingMessage = value;
        }
    }

    [XmlIgnore]
    public bool FinishForwardingOrSendingMessageSpecified { get; set; }
}
}
