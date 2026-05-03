using System;
using System.Xml.Serialization;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// MWI Delivery To Mobile Endpoint template types.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]
    public enum MWIDeliveryToMobileEndpointTemplateType23
    {
        [XmlEnum(Name = "Default")]
        Default,
        [XmlEnum(Name = "Single New No Previous Message")]
        SingleNewNoPreviousMessage,
        [XmlEnum(Name = "Single New With Previous Message")]
        SingleNewWithPreviousMessage,
        [XmlEnum(Name = "Multiple New Messages")]
        MultipleNewMessages,
        [XmlEnum(Name = "Missed call alert for Unconditional voice mail forwarding")]
        MissedcallalertforUnconditionalvoicemailforwarding,
        [XmlEnum(Name = "Missed call alert for Busy voice mail forwarding")]
        MissedcallalertforBusyvoicemailforwarding,
        [XmlEnum(Name = "Missed call alert for Not Reachable voice mail forwarding")]
        MissedcallalertforNotReachablevoicemailforwarding,
        [XmlEnum(Name = "Missed call alert for No Answer voice mail forwarding")]
        MissedcallalertforNoAnswervoicemailforwarding,
    }
}
