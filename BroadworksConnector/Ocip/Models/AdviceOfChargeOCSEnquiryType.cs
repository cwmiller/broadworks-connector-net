using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Choices for type of OCS enquiry that Advice Of Charge Services sends to OCS.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum AdviceOfChargeOCSEnquiryType
    {
        [XmlEnum(Name = "Service Price")]
        ServicePrice,
        [XmlEnum(Name = "Advice Of Charge")]
        AdviceOfCharge,
    }
}
