using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeGetResponse : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false)]
    public int DelayBetweenNotificationSeconds { get; set; }
    [XmlElement(ElementName = "incomingAocHandling", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling { get; set; }
    [XmlElement(ElementName = "costInformationSource", IsNullable = false)]
    public string CostInformationSource { get; set; }
 }
}
