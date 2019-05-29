using System;
using System.Xml.Serialization;
    using System.Collections.Generic;

namespace BroadworksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public  class SystemAdviceOfChargeGetResponse19sp1 : BroadworksConnector.Ocip.Models.C.OCIDataResponse
{
    [XmlElement(ElementName = "delayBetweenNotificationSeconds", IsNullable = false)]
    public int DelayBetweenNotificationSeconds { get; set; }
    [XmlElement(ElementName = "incomingAocHandling", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AdviceOfChargeIncomingAocHandling IncomingAocHandling { get; set; }
    [XmlElement(ElementName = "useOCSEnquiry", IsNullable = false)]
    public bool UseOCSEnquiry { get; set; }
    [XmlElement(ElementName = "OCSEnquiryType", IsNullable = false)]
    public BroadworksConnector.Ocip.Models.AdviceOfChargeOCSEnquiryType OCSEnquiryType { get; set; }
 }
}
