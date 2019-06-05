using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    private int _delayBetweenNotificationSeconds;

    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false, Namespace = "")]
    public int DelayBetweenNotificationSeconds {
        get => _delayBetweenNotificationSeconds;
        set {
            DelayBetweenNotificationSecondsSpecified = true;
            _delayBetweenNotificationSeconds = value;
        }
    }

    [XmlIgnore]
    public bool DelayBetweenNotificationSecondsSpecified { get; set; }
    private BroadworksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling _incomingAocHandling;

    [XmlElement(ElementName = "incomingAocHandling", IsNullable = false, Namespace = "")]
    public BroadworksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling {
        get => _incomingAocHandling;
        set {
            IncomingAocHandlingSpecified = true;
            _incomingAocHandling = value;
        }
    }

    [XmlIgnore]
    public bool IncomingAocHandlingSpecified { get; set; }
    private string _costInformationSource;

    [XmlElement(ElementName = "costInformationSource", IsNullable = false, Namespace = "")]
    public string CostInformationSource {
        get => _costInformationSource;
        set {
            CostInformationSourceSpecified = true;
            _costInformationSource = value;
        }
    }

    [XmlIgnore]
    public bool CostInformationSourceSpecified { get; set; }
}
}
