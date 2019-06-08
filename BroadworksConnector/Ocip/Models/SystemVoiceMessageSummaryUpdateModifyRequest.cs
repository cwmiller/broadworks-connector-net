using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemVoiceMessageSummaryUpdateModifyRequest : BroadWorksConnector.Ocip.Models.C.OCIRequest
{
    private bool _sendSavedAndUrgentMWIOnNotification;

    [XmlElement(ElementName = "sendSavedAndUrgentMWIOnNotification", IsNullable = false, Namespace = "")]
    public bool SendSavedAndUrgentMWIOnNotification {
        get => _sendSavedAndUrgentMWIOnNotification;
        set {
            SendSavedAndUrgentMWIOnNotificationSpecified = true;
            _sendSavedAndUrgentMWIOnNotification = value;
        }
    }

    [XmlIgnore]
    public bool SendSavedAndUrgentMWIOnNotificationSpecified { get; set; }
    private bool _sendMessageSummaryUpdateOnRegister;

    [XmlElement(ElementName = "sendMessageSummaryUpdateOnRegister", IsNullable = false, Namespace = "")]
    public bool SendMessageSummaryUpdateOnRegister {
        get => _sendMessageSummaryUpdateOnRegister;
        set {
            SendMessageSummaryUpdateOnRegisterSpecified = true;
            _sendMessageSummaryUpdateOnRegister = value;
        }
    }

    [XmlIgnore]
    public bool SendMessageSummaryUpdateOnRegisterSpecified { get; set; }
    private int _minTimeBetweenMWIOnRegister;

    [XmlElement(ElementName = "minTimeBetweenMWIOnRegister", IsNullable = false, Namespace = "")]
    public int MinTimeBetweenMWIOnRegister {
        get => _minTimeBetweenMWIOnRegister;
        set {
            MinTimeBetweenMWIOnRegisterSpecified = true;
            _minTimeBetweenMWIOnRegister = value;
        }
    }

    [XmlIgnore]
    public bool MinTimeBetweenMWIOnRegisterSpecified { get; set; }
}
}
