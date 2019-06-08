using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
[Serializable]
[XmlRoot(Namespace = "")]
public enum AdviceOfChargeOCSEnquiryType{
    [XmlEnum(Name = "Service Price")]
    ServicePrice,
    [XmlEnum(Name = "Advice Of Charge")]
    AdviceOfCharge,
 }
}
